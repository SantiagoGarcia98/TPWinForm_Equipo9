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


namespace WindowsFormsApp
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
          DataMarca listadoMarca = new DataMarca();
          DataCategoria listadoCategoria = new DataCategoria();
            try
            {
                cmbMarca.DataSource = listadoMarca.listar();
                cmdCategoria.DataSource = listadoCategoria.listar();           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
             
            }


        }
    }
}
