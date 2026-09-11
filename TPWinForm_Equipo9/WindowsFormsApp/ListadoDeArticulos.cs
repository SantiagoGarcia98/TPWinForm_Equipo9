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
    public partial class ListadoDeArticulos : Form
    {
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
            dgvArticulos.DataSource = dataArt.ListarArticulo();

        }
    }
}
