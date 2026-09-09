using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            btnIngresoNombre.Enabled = false;
        }
        private void controlbotones()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(Char.IsLetter))
            {
                btnIngresoNombre.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                }
                btnIngresoNombre.Enabled = false;
                txtNombre.Focus();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }

        private void btnIngresoNombre_Click(object sender, EventArgs e)
        {
            using (Administracion administracion = new Administracion(txtNombre.Text))
                administracion.ShowDialog();
        }
    }
}
