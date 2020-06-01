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
    public partial class IUAdminPizzeria : Form
    {
        public IUAdminPizzeria()
        {
            InitializeComponent();
        }
        string nomPizz;
      /* public void setVariableNombre(string nom)
        {
            variableNombre = nom;
            
        }*/
        public IUAdminPizzeria(string no)
        {
            InitializeComponent();
            nomPizz=no;
        }
      /* public string GetNombre()
        {
            return variableNombre;
        }*/
        IUAdministrarPizzas x = new IUAdministrarPizzas();
        private void button1_Click(object sender, EventArgs e)
        {
            if(rbPizzas.Checked)
            {

                IUAdministrarPizzas pizz = new IUAdministrarPizzas(nomPizz);
                //pizz.setNombrePizz(variableNombre);
                pizz.Visible = true;
                Visible = false;
               
            }
            else if(rbAdiciones.Checked)
            {
                IUAdministrarAdiciones adi = new IUAdministrarAdiciones(nomPizz);
            //adi.setNombrePizz(variableNombre);
                adi.Visible = true;
                Visible = false;
            }
            else if (rbGraficar.Checked)
            {
                IU_Grafica graft = new IU_Grafica(nomPizz);
                graft.Visible = true;
                Visible = false;
            }
           
        }

        private void AdminPizzeria_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IULoginPizzeria Lp = new IULoginPizzeria();
            Lp.Visible = true;
            Visible = false;
        }

        private void rbAdiciones_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lnCambiarC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IU_CambiarContraseñaPizzeria objCambiarCtrPizz = new IU_CambiarContraseñaPizzeria(nomPizz);
            objCambiarCtrPizz.Visible = true;
            Visible = false;
        }

        private void rbGraficar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
