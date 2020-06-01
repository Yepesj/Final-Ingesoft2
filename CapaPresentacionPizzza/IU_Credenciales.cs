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
    public partial class IU_Creden : Form
    {
        public IU_Creden()
        {
            InitializeComponent();
          

        }
        ControladorPizzza objControladorPizza = new ControladorPizzza();
   
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ControladorPizzza objControlador = new ControladorPizzza();

            //Llamar método sql para guardar las credenciales en la base de datos
           
            if ((txtNombre.Text.Equals("")) || txtNombre.Text.Equals("Nombre De Usuario") || txtContraseña.Text.Equals("Contraseña") || txtContraseña.Text.Equals("Confirmar Contraseña") || (txtContraseña.Text.Equals(""))|| (txtCorreo.Text.Equals(""))|| (txtNumero.Text.Equals(""))||( txtDireccion.Text.Equals(""))||(txtDireccion.Text.Equals("Dirección")))
            {

                MessageBox.Show("Llene todos los campos");

            }
            else
            {
                
                if (txtContraseña.Text.Equals(txtConfirmarContraseña.Text))
                {
                    if (objControladorPizza.email_bien_escrito(txtCorreo.Text) == true)
                    {

                        if (objControlador.ValidarNumero(txtNumero.Text))
                        {
                            
                         objControladorPizza.IngresarDatos(txtNombre.Text, txtContraseña.Text, txtCorreo.Text, txtNumero.Text, txtDireccion.Text);
                         IuLoginj login = new IuLoginj();
                         login.Visible = true;
                         Visible = false;
                         }
                        else
                        {
                            MessageBox.Show("Número de teléfono inválido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Correo electrónico inválido");
                    }


                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IuLoginj login = new IuLoginj();
            login.Visible = true;
            Visible = false;
        }

        private void IU_Creden_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "")
            {
                txtConfirmarContraseña.Text = "Confirmar Contraseña";
                txtConfirmarContraseña.ForeColor = Color.DarkGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "Confirmar Contraseña")
            {
                txtConfirmarContraseña.Text = "";
                txtConfirmarContraseña.ForeColor = Color.DarkGray;
                txtConfirmarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre De Usuario")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre De Usuario";
                txtNombre.ForeColor = Color.DarkGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo Electrónico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.DarkGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo Electrónico";
                txtCorreo.ForeColor = Color.DarkGray;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Número De Teléfono";
                txtNumero.ForeColor = Color.DarkGray;
            }
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Número De Teléfono")
            {
                txtNumero.Text = "";
                txtNumero.ForeColor = Color.DarkGray;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.DarkGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
