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
        List<Imagen> imagenes = new List<Imagen>();    
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

            btnAgregar.Text = "Modificar Articulo";
            txtNombre.Text = articulo.Nombre;
            txtCodigo.Text = articulo.Codigo;
            txtPrecio.Text = articulo.Precio.ToString();
            txtDescripcion.Text = articulo.Descripcion;


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
                cmbCategoria.DataSource = categorias;

                if (articulo != null)
                {
                    cmbMarca.SelectedItem = marcas.Find(x => x.Id == articulo.NombreMarca.Id);
                    cmbCategoria.SelectedItem = categorias.Find(x => x.Id == articulo.TipoCategoria.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
             
            } 


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataArticulo aux = new DataArticulo();

            if(string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))

            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }


            decimal precio;

            if(!decimal.TryParse(txtPrecio.Text, out precio) || precio <=0)
            {
                MessageBox.Show("El precio debe ser un numero valido mayor a 0.");
                return;
            }
            try
            {
                if (articulo != null)
                {
                    articulo.Nombre = txtNombre.Text;
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Precio = precio;
                    articulo.Descripcion = txtDescripcion.Text;

                    articulo.NombreMarca = (Marca)cmbMarca.SelectedItem;
                    articulo.TipoCategoria = (Categoria)cmbCategoria.SelectedItem;

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


            try
            {
                if (!ValidarDatos())
                {
                    articulo = new Articulo();
                    articulo.Nombre = txtNombre.Text;
                    articulo.NombreMarca =(Marca)cmbMarca.SelectedItem;
                    articulo.TipoCategoria = (Categoria)cmbCategoria.SelectedItem;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.urlImagen = imagenes;
                   
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnImagenAgregar_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen();
            try
            {
                imagen.Url = txtImagen.Text;
                if (!(string.IsNullOrEmpty(txtImagen.Text)))
                {
                    imagenes.Add(imagen);
                    txtImagen.Text =string.Empty;
                    MessageBox.Show("Imagen agregada al articulo");
                }
                else
                {
                    MessageBox.Show("Por favor complete con una URL y luego presione el boton");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidarDatos()
        {
            if (cmbCategoria.SelectedIndex < 0)
            {
                return true;
            }
            if (cmbMarca.SelectedIndex <0)
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                return true;
            }
            if (!verificarNumeros())
            {
                return true;
            }

            return false;
        }
        private bool verificarNumeros()
        {
            foreach (char c in txtPrecio.Text)
            {
                if (!(Char.IsNumber(c)))
                    return false;
            }
            return true;
        }
    }
}
