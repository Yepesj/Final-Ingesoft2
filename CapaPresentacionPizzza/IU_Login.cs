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
using System.Data.Sql;
using System.Data.SqlClient;



namespace CapaPresentacionPizzza
{
    public partial class IuLoginj : Form
    {
        public IuLoginj()
        {
            InitializeComponent();
        }

        private void IuLoginj_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IU_Creden registro = new IU_Creden();
            registro.Visible = true;
            Visible = false;
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IU_CambiarContraseña cambiar = new IU_CambiarContraseña();
            cambiar.Visible=true;
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Método para validar nombre y contraseña sql

            ControladorPizzza objpizzaP = new ControladorPizzza();
            SqlDataReader loguearC;
            loguearC = objpizzaP.iniciarSesionC(txtCorreo.Text,txtContraseña.Text);
            if (loguearC.Read() == true)
            {

                IU_Pizzeria pizza = new IU_Pizzeria(txtCorreo.Text);
                pizza.Visible = true;
                Visible = false;
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válidos");
            }

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IULoginPizzeria pizza = new IULoginPizzeria();
            pizza.Visible = true;
            Visible = false;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo Electronico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsuario_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo Electronico";
                txtCorreo.ForeColor = Color.DarkGray;
            }
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IU_Grafica objGrafica = new IU_Grafica();
            objGrafica.Visible = true;
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
