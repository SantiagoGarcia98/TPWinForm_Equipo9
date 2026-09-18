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

namespace WindowsFormsApp
{
    public partial class DetalleArticulo : Form
    {
        private Articulo articulo;

        public DetalleArticulo()
        {
            InitializeComponent();
        }

        public DetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            lblDatoNombre.Text = articulo.Nombre;
            lblDatoCodigo.Text = articulo.Codigo;
            lblDatoPrecio.Text = articulo.Precio.ToString();
            lblDatoMarca.Text = articulo.NombreMarca.ToString();
            lblDatoCategoria.Text = articulo.TipoCategoria.ToString();
            lblDatoDescripcion.Text = articulo.Descripcion;
        }

        private void btnVolverDetalleArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
