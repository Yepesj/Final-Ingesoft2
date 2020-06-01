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
using Comunes;
namespace CapaPresentacionPizzza
{
    public partial class IULoginPizzeria : Form
    {
        public IULoginPizzeria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorPizzza objpizzaPizzeria= new ControladorPizzza();
            SqlDataReader loguearP;
            string nombreP = txtNombreP.Text; 
            List<Class1> objc = new List<Class1>();
            ControladorPizzza pizzeria = new ControladorPizzza();
            objc = pizzeria.NombrePizzeria(nombreP);
            loguearP = objpizzaPizzeria.IniciarSesionP(txtNombreP.Text, txtContraseñaP.Text);
            if (loguearP.Read() == true)
            {

                IUAdminPizzeria pizza = new IUAdminPizzeria(txtNombreP.Text);
                //pizza.setVariableNombre(txtNombreP.Text);
                pizza.Visible = true;
                Visible = false;
                
               
            }
            else
            {
                MessageBox.Show("Nombre o contraseña no válidos");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IuLoginj login = new IuLoginj();
            login.Visible = true;
            Visible = false;
        }

        private void LoginPizzeria_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreP_Leave(object sender, EventArgs e)
        {
            if (txtNombreP.Text == "")
            {
                txtNombreP.Text = "Nombre";
                txtNombreP.ForeColor = Color.DarkGray;
               
            }
        }

        private void txtNombreP_Enter(object sender, EventArgs e)
        {
            if (txtNombreP.Text == "Nombre")
            {
                txtNombreP.Text = "";
                txtNombreP.ForeColor = Color.DarkGray;
                
            }
        }

        private void txtContraseñaP_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaP.Text == "")
            {
                txtContraseñaP.Text = "Contraseña";
                txtContraseñaP.ForeColor = Color.DarkGray;
                txtContraseñaP.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseñaP_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaP.Text == "Contraseña")
            {
                txtContraseñaP.Text = "";
                txtContraseñaP.ForeColor = Color.DarkGray;
                txtContraseñaP.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
