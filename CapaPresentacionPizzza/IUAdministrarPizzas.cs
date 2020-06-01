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
    public partial class IUAdministrarPizzas : Form
    {
        ControladorPizzza objAdminP = new ControladorPizzza();
        string nombrePizz;
        public void setNombrePizz(string nom)
        {
            nombrePizz = nom;
        }
        public IUAdministrarPizzas()
        {
            InitializeComponent();
        }
        public IUAdministrarPizzas(string nombre)
        {
            InitializeComponent();
            nombrePizz = nombre;

        }
        public string Get()
        {
          return  nombrePizz;
        }

        private void AdministrarPizzas_Load(object sender, EventArgs e)
        {
           
            dgCambiarMenu.DataSource = objAdminP.TraerMenuPizzeriaId(nombrePizz);

    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbInsertar.Checked)
            {
                if (txtPizza.Text.Equals("") || txtPrecio.Text.Equals("") || cbTamaño.Text.Equals(""))
                {
                    MessageBox.Show("Llene todos los campos");
                }
                else
                {
                    objAdminP.InsertarPizza(nombrePizz, txtPizza.Text, cbTamaño.Text, Convert.ToDouble(txtPrecio.Text));
                    dgCambiarMenu.DataSource = objAdminP.TraerMenuPizzeriaId(nombrePizz);
                    txtPizza.Text = "";
                    txtPrecio.Text = "";
                    
                }
                    
            }
            else if (rbBorrar.Checked)
            {
                txtPizza.Text = "";
                txtPrecio.Text = "";
                int id = Convert.ToInt32(dgCambiarMenu.CurrentRow.Cells[0].Value);
                objAdminP.EliminarPizza(id);
                dgCambiarMenu.DataSource = objAdminP.TraerMenuPizzeriaId(nombrePizz);
            }
            else if (rbModificar.Checked)
            {
                if (txtPizza.Text.Equals("") || txtPrecio.Text.Equals("") || cbTamaño.Text.Equals(""))
                {
                    MessageBox.Show("Llene todos los campos");
                }
                else
                {
                    int id = Convert.ToInt32(dgCambiarMenu.CurrentRow.Cells[0].Value);
                    objAdminP.ActualizarPizza(id, nombrePizz, txtPizza.Text, cbTamaño.Text, Convert.ToDouble(txtPrecio.Text));
                    dgCambiarMenu.DataSource = objAdminP.TraerMenuPizzeriaId(nombrePizz);
                    txtPizza.Text = "";
                    txtPrecio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = dgCambiarMenu.DataSource as DataTable;
            string nomP = dt.Rows[0][1].ToString();
            IUAdminPizzeria adm = new IUAdminPizzeria(nomP);
            adm.Visible = true;
            Visible = false;
        }

        private void txtPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
