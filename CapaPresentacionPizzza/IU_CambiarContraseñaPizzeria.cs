using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegociosPizzza;

namespace CapaPresentacionPizzza
{
    public partial class IU_CambiarContraseñaPizzeria : Form
    {
        string nombrePizzeria;
        public IU_CambiarContraseñaPizzeria()
        {
            InitializeComponent();
        }
        public IU_CambiarContraseñaPizzeria(string nombre)
        {
            InitializeComponent();
            nombrePizzeria = nombre;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (!txtCambiarContraseña.Text.Equals(""))
            {
                ControladorPizzza objCambiarCtr = new ControladorPizzza();
                objCambiarCtr.CambiarContraseñaP(txtNombrePizzeria.Text, txtCambiarContraseña.Text);
                MessageBox.Show("Se cambio la Contraseña");
                IULoginPizzeria objLoginPizzeria = new IULoginPizzeria();
                objLoginPizzeria.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void IU_CambiarContraseñaPizzeria_Load(object sender, EventArgs e)
        {
            txtNombrePizzeria.Text = nombrePizzeria;
        }


        private void txtCambiarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtCambiarContraseña.Text == "")
            {
                txtCambiarContraseña.Text = "Nueva Contraseña" +
                    "";
                txtCambiarContraseña.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombrePizzeria_Leave(object sender, EventArgs e)
        {
            if (txtNombrePizzeria.Text == "")
            {
                txtNombrePizzeria.Text = "Correo electrónico";
                txtNombrePizzeria.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombrePizzeria_Enter(object sender, EventArgs e)
        {
            if (txtNombrePizzeria.Text == "Nombre Pizzeria")
            {
                txtNombrePizzeria.Text = "";
                txtNombrePizzeria.ForeColor = Color.DarkGray;
                
            }
        }

        private void txtCambiarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtCambiarContraseña.Text == "Nueva Contraseña")
            {
                txtCambiarContraseña.Text = "";
                txtCambiarContraseña.ForeColor = Color.DarkGray;
                txtCambiarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
