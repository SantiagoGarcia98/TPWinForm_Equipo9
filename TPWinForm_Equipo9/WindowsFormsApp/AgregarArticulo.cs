using negocio;
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


namespace WindowsFormsApp
{
    public partial class AgregarArticulo : Form
    {

        private Articulo articulo;
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            btnAgregar.Text = "Modificar Articulo";
            textBox1.Text = articulo.Nombre;
            textBox3.Text = articulo.Codigo;
            textBox4.Text = articulo.Precio.ToString();
            textBox6.Text = articulo.Descripcion;


        }
        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
          DataMarca listadoMarca = new DataMarca();
          DataCategoria listadoCategoria = new DataCategoria();
            try
            {
                List<Marca> marcas = listadoMarca.listar();
                List<Categoria> categorias = listadoCategoria.listar();

                cmbMarca.DataSource = marcas;
                cmdCategoria.DataSource = categorias;

                if (articulo != null)
                {
                    cmbMarca.SelectedItem = marcas.Find(x => x.Id == articulo.NombreMarca.Id);
                    cmdCategoria.SelectedItem = categorias.Find(x => x.Id == articulo.TipoCategoria.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
             
            } 


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))

            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }


            decimal precio;

            if(!decimal.TryParse(textBox4.Text, out precio) || precio <=0)
            {
                MessageBox.Show("El precio debe ser un numero valido mayor a 0.");
                return;
            }
            try
            {
                if (articulo != null)
                {
                    articulo.Nombre = textBox1.Text;
                    articulo.Codigo = textBox3.Text;
                    articulo.Precio = precio;
                    articulo.Descripcion = textBox6.Text;

                    articulo.NombreMarca = (Marca)cmbMarca.SelectedItem;
                    articulo.TipoCategoria = (Categoria)cmdCategoria.SelectedItem;

                    DataArticulo datos = new DataArticulo();
                    datos.ModificarArticulo(articulo);

                    MessageBox.Show("Artículo modificado correctamente.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
