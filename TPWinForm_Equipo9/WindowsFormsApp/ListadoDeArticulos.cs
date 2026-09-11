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
    public partial class ListadoDeArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public ListadoDeArticulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoDeArticulos_Load(object sender, EventArgs e)
        {
            DataArticulo dataArt = new DataArticulo();
            listaArticulos = dataArt.ListarArticulo();
            dgvArticulos.DataSource = listaArticulos;

            CmbFiltroArticulo.Items.Add("ID");
            CmbFiltroArticulo.Items.Add("CODIGO");
            CmbFiltroArticulo.Items.Add("NOMBRE");
            CmbFiltroArticulo.Items.Add("DESCRIPCION");
            CmbFiltroArticulo.Items.Add("MARCA");
            CmbFiltroArticulo.Items.Add("CATEGORIA");
            CmbFiltroArticulo.Items.Add("PRECIO");
            CmbFiltroArticulo.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtFilterArticulo.Text.ToUpper();
            string campo = CmbFiltroArticulo.SelectedItem.ToString();

            List<Articulo> filtrada;

            if (campo == "ID")
            {
                filtrada = listaArticulos.FindAll(x => x.id.ToString().Contains(texto));
            }
            else if (campo == "CODIGO")
            {
                filtrada = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(texto));
            }
            else if (campo == "NOMBRE")
            {
                filtrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(texto));
            }
            else if (campo == "DESCRIPCION")
            {
                filtrada = listaArticulos.FindAll(x => x.Descripcion.ToUpper().Contains(texto));
            }
            else if (campo == "MARCA")
            {
                filtrada = listaArticulos.FindAll(x => x.NombreMarca.descripcion.ToUpper().Contains(texto));
            }
            else if (campo == "CATEGORIA")
            {
                filtrada = listaArticulos.FindAll(x => x.TipoCategoria.descripcion.ToUpper().Contains(texto));
            }
            else if (campo == "PRECIO")
            {
                filtrada = listaArticulos.FindAll(x => x.Precio.ToString().Contains(texto));
            }
            else {
                filtrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = filtrada;
        }
    }
}
