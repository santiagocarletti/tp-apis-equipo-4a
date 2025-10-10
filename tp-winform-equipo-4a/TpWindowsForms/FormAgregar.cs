using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TpWindowsForms
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarFiltro()
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Ingrese código del artículo");
                return true;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre del artículo");
                return true;
            }

            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la marca");
                return true;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la categoría");
                return true;
            }
            if (validarSoloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese solo números en el precio");
                return true;
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo Arti = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                //jueves
                Arti.Imagen = new List<string>();

                Arti.Codigo = txtNumero.Text;
                Arti.Nombre = txtNombre.Text;
                Arti.Descripcion = txtDescripcion.Text;
                Arti.marca = (Marca)cboMarca.SelectedItem;
                Arti.IdCategoria = (Categoria)cboCategoria.SelectedItem;
                Arti.Precio = decimal.Parse(txtPrecio.Text);
                Arti.Imagen.Add(txtImagenUrl.Text);

                //Lanza excepcion
                negocio.agregar(Arti);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio cNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.SelectedIndex = -1;
                cboCategoria.DataSource = cNegocio.listar();
                cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://png.pngtree.com/png-vector/20230407/ourmid/pngtree-placeholder-line-icon-vector-png-image_6691835.png");
            }
        }

        private void lblImagenUrl_Click(object sender, EventArgs e)
        {

        }
    }
}
