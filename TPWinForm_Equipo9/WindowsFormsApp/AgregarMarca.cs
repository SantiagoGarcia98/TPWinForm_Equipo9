using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Debe ingresar una marca.");
                return;
            }

           Marca marca = new Marca();
           marca.descripcion = txtMarca.Text;

            DataMarca datos = new DataMarca();
            datos.AgregarMarca(marca);

            MessageBox.Show("Marca agregada correctamente.");
            Close();

        }

        private void BtnSaveNewCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCategoria.Text))
            {
                MessageBox.Show("Debe ingresar una categoria para agregar.");
                return;
            }else if(!Regex.IsMatch(txtBoxCategoria.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("La categoria solo puede contener letras y espacios.");
                return;
            }
            

            Categoria categoria = new Categoria();
            categoria.descripcion = txtBoxCategoria.Text;
            DataCategoria datos = new DataCategoria();
            datos.agregarCategoria(categoria);

            MessageBox.Show("Categoria agregada correctamente.");
            Close();

        }

        private void AgregarMarca_Load(object sender, EventArgs e)
        {
            DataMarca listMarca = new DataMarca();
            DataCategoria listCat = new DataCategoria();
            try
            {
                List<Marca> marca = listMarca.listar();
                List<Categoria> categoria = listCat.listar();

                cmbEliminarMarca.DataSource = marca;
                cmbEliminarMarca.DisplayMember = "Descripcion";
                cmbEliminarMarca.ValueMember = "Id";

                cmbEliminarCategoria.DataSource = categoria;
                cmbEliminarCategoria.DisplayMember = "Descripcion";
                cmbEliminarCategoria.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca marc= (Marca)cmbEliminarMarca.SelectedItem;
            int idEliminar = marc.Id;

            DataMarca data = new DataMarca();
            data.EliminarMarca(idEliminar);

            MessageBox.Show("Marca eliminada correctamente.");
            Close();

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = (Categoria)cmbEliminarCategoria.SelectedItem;
            int idEliminar = cat.Id;

            DataCategoria data = new DataCategoria();
            data.EliminarCategoria(idEliminar);

            MessageBox.Show("Categoria eliminada correctamente.");
            Close();
        }

        private void btnVolverGestionMarcCat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
