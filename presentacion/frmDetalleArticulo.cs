using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;

        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = $"Detalle de {articulo.Nombre}";
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblCodigoRes.Text = articulo.Codigo;
            lblNombreRes.Text = articulo.Nombre;
            lblDescripcionRes.Text = articulo.Descripcion;
            lblPrecioRes.Text = articulo.Precio.ToString();
            cargarImagen(articulo.ImagenUrl);
            lblMarcaRes.Text = articulo.Marca.Descripcion;
            lblCategoriaRes.Text = articulo.Categoria.Descripcion;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
