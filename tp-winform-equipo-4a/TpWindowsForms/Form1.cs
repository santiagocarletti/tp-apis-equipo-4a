using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TpWindowsForms
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();

            cboCampo.Items.Add("Nombre"); 
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                //formateo de la celda para moneda
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvArticulos.Columns["Precio"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("es-AR");


                dgvArticulos.Columns["Id"].Visible = false;
                //dgvArticulos.Columns["Imagen"].Visible = false;
                //pbxArticulos.Load(listaArticulos[0].Imagen.ImagenUrl);
                //jueves

                //DOMINGO
                //pbxArticulos.Load(listaArticulos[0].Imagen[0]);
                if (dgvArticulos.Rows.Count > 0)
                {
                    dgvArticulos.Rows[0].Selected = true;
                    dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
                    pbxArticulos.Load(listaArticulos[0].Imagen[0]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                return;
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //cargarImagen(seleccionado.Imagen.ImagenUrl);
            //jueves
            cargarImagen(seleccionado.Imagen[0]);
            //viernes
            CargarListaImagenes();
            if (cboImagenes.Items.Count > 0)
            {
                cboImagenes.SelectedIndex = 0;
                cargarImagen((string)cboImagenes.Items[0]);
            }
        }
        private void CargarListaImagenes()
        {
            if (dgvArticulos.CurrentRow == null)
            { return; }

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            cboImagenes.Items.Clear();

            foreach (string Image in seleccionado.Imagen)
            {
                cboImagenes.Items.Add(Image);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://png.pngtree.com/png-vector/20230407/ourmid/pngtree-placeholder-line-icon-vector-png-image_6691835.png");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar alta = new FormAgregar();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FormModificar modificar = new FormModificar(seleccionado);
                modificar.ShowDialog();
            }
        }
        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarImagen((string)cboImagenes.SelectedItem);
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que querer eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaArticulosFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 3)
            {
                listaArticulosFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.marca.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaArticulosFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulosFiltrada;
            dgvArticulos.Columns["Id"].Visible = false;

            if (dgvArticulos.CurrentRow == null)
            {
                btnModificar.Enabled = false;
                btnBorrar.Enabled = false;
                btnDetalles.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
                btnDetalles.Enabled = true;
            }
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el campo");
                return true;
            }
            if (cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el criterio");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if(validarSoloNumeros(txtBusquedaAvanzada.Text))
                {
                    MessageBox.Show("solo números");
                    return true;
                }
            }
            return false;
        }
        private bool validarSoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (char.IsNumber(caracter))
                    return false;

            }
            return true;
        }
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }

                List<Articulo> listaArticulosFiltrada;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBusquedaAvanzada.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

                if (dgvArticulos.CurrentRow == null)
                {
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                    btnDetalles.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnBorrar.Enabled = true;
                    btnDetalles.Enabled = true;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Mayor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Finaliza con");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = listaArticulos;
            txtBusquedaAvanzada.Clear();
            cboCampo.Items.Clear();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
            cboCriterio.Items.Clear();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dgvArticulos.CurrentRow;
                int idArticulo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articuloSeleccionado = negocio.obtenerPorId(idArticulo);

                if (articuloSeleccionado != null)
                {
                    FormDetalles detalles = new FormDetalles(articuloSeleccionado);
                    detalles.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un artículo de la lista.");
            }
        }
    }
}
