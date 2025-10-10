using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpWindowsForms
{
    public partial class FormModificar : Form
    {
        private Articulo articulo = null;

        public FormModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            CargarControles();
            CargarDatos(articulo);
        }

        private void CargarControles()
        {
            MarcaNegocio mNegocio = new MarcaNegocio();
            CategoriaNegocio cNegocio = new CategoriaNegocio();

            cboMarca.DataSource = mNegocio.listar();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";

            cboCategoria.DataSource = cNegocio.listar();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";
        }
        private void CargarDatos(Articulo articulo)
        {
            txtCodigo.Text = articulo.Codigo.ToString();
            txtNombre.Text = articulo.Nombre.ToString();
            txtDescripcion.Text = articulo.Descripcion.ToString();
            if (articulo.IdCategoria != null)
                cboCategoria.SelectedValue = articulo.IdCategoria.Id;

            if (articulo.marca != null)
                cboMarca.SelectedValue = articulo.marca.Id;

            txtPrecio.Text = articulo.Precio.ToString();
            CargarListaImagenes();
            if (cboImagenes.Items.Count > 0)
            {
                cboImagenes.SelectedIndex = 0;
                CargarImagen(articulo.Imagen[0]);
            }
        }
        private void CargarListaImagenes()
        {
            cboImagenes.Items.Clear();
            cboImagenes.Text = "";

            foreach (string Image in articulo.Imagen)
            {
                cboImagenes.Items.Add(Image);
            }
        }
        private void CargarImagen(string url)
        {
            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://png.pngtree.com/png-vector/20230407/ourmid/pngtree-placeholder-line-icon-vector-png-image_6691835.png");
            }
        }

        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarImagen(cboImagenes.SelectedItem.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(ChequearCambios(articulo)))
            {
                Close();
                MessageBox.Show("No hubo cambios");
                return;
            }
            if (!ValidarDatos())
            {
                return;
            }
            ModificarArticuloBD();
        }

        private void ModificarArticuloBD()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.marca = (Marca)cboMarca.SelectedItem;
            articulo.IdCategoria = (Categoria)cboCategoria.SelectedItem;
            articulo.Precio = (Convert.ToDecimal(txtPrecio.Text));
            articulo.Imagen.Clear();

            foreach (string imagen in cboImagenes.Items)
            {
                articulo.Imagen.Add(imagen);
            }

            try
            {
                negocio.modificar(articulo);
                MessageBox.Show("Articulo Modificado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        //VALIDACIONES
        private bool ChequearCambios(Articulo articulo)
        {
            if (txtCodigo.Text == articulo.Codigo &&
                txtNombre.Text == articulo.Nombre &&
                txtDescripcion.Text == articulo.Descripcion &&
                cboCategoria.SelectedValue == articulo.IdCategoria &&
                (int)cboMarca.SelectedValue == articulo.marca.Id &&
                txtPrecio.Text == articulo.Precio.ToString())
            {

                if (articulo.Imagen.Count != cboImagenes.Items.Count)
                { return true; }

                int contador = 0;

                foreach (var imagen in cboImagenes.Items)
                {
                    if (imagen.ToString() != articulo.Imagen[contador])
                    { return true; }
                    contador++;
                }

                return false;
            }
            return true;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (txtImagen.Text == "")
            { return; }

            foreach (string image in articulo.Imagen)
            {
                if (image == txtImagen.Text)
                {
                    cboImagenes.SelectedItem = txtImagen.Text;
                    return;
                }
            }

            cboImagenes.Items.Add(txtImagen.Text);
            cboImagenes.SelectedItem = txtImagen.Text;
            txtImagen.Clear();
            CargarImagen(cboImagenes.SelectedItem.ToString());
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if (cboImagenes.Items.Count == 0)
            {
                return;
            }

            int indice = cboImagenes.SelectedIndex;
            cboImagenes.Items.RemoveAt(indice);

            if (cboImagenes.Items.Count > 0)
            {
                cboImagenes.SelectedIndex = 0;
            }
        }
        private bool ValidarDatos()
        {
            lblCamposObligatorios.Visible = false;
            lblErrorCodigo.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorPrecio.Visible = false;

            bool validado = true;

            if (txtCodigo.Text == "")
            {
                lblCamposObligatorios.Visible = true;
                lblErrorCodigo.Visible = true;
                validado = false;
            }

            if (txtNombre.Text == "")
            {
                lblCamposObligatorios.Visible = true;
                lblErrorNombre.Visible = true;
                validado = false;
            }

            if (!ValidarDecimal(txtPrecio.Text))
            {
                lblErrorPrecio.Visible = true;
                validado = false;
            }

            return validado;
        }

        private bool ValidarDecimal(string numero)
        {
            if (decimal.TryParse(numero, out decimal num))
                return true;
            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
