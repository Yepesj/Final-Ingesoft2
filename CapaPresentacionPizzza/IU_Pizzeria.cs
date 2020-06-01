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
using Comunes;
namespace CapaPresentacionPizzza
{
    public partial class IU_Pizzeria : Form
    {
        string user;
        public IU_Pizzeria()
        {
            InitializeComponent();
        }
        public IU_Pizzeria(string usuario)
        {
            user = usuario;
            InitializeComponent();
        }
        ControladorPizzza objPizzeria = new ControladorPizzza();
        private void IU_Pizzeria_Load(object sender, EventArgs e)
        {
            dgPizzerias.DataSource = objPizzeria.TraerPizzeria();
         
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Método para escoger pizza SQL

            string nombreP = dgPizzerias.CurrentCell.Value.ToString();
            List<Class1> objc = new List<Class1>();
            ControladorPizzza pizzeria = new ControladorPizzza();
            objc = pizzeria.NombrePizzeria(nombreP);
            if (!nombreP.Equals(""))
            {
                IUListaMenus objListaMenus = new IUListaMenus();
                IUListaMenus adiciones = new IUListaMenus ();
                adiciones.SetVariable(nombreP);
                objPizzeria.setNombrePiz(nombreP);
                adiciones.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Selecciones una pizzería");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IuLoginj login = new IuLoginj();
            login.Visible = true;
            Visible = false;
        }

        private void dgPizzerias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IU_CambiarContraseña login = new IU_CambiarContraseña(user);
            login.Visible = true;
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
