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
    public partial class IU_CambiarContraseña : Form
    {
        string correoUsuario;
        public IU_CambiarContraseña()
        {
            InitializeComponent();
        }
        public IU_CambiarContraseña(string correo)
        {
            InitializeComponent();
            correoUsuario = correo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtContraseña.Text.Equals(""))
            {
                //Llamar método para cambiar contraseña
                ControladorPizzza objCambiarContrseña = new ControladorPizzza();
                objCambiarContrseña.CambiarContraseña(txtCorreoUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Se cambio la contraseña");
                IuLoginj login = new IuLoginj();
                login.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            IuLoginj login = new IuLoginj();
            login.Visible = true;
            Visible = false;
        }

        private void IU_CambiarContraseña_Load(object sender, EventArgs e)
        {
            txtCorreoUsuario.Text = correoUsuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
