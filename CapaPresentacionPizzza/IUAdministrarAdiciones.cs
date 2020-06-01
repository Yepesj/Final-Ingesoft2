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
    public partial class IUAdministrarAdiciones : Form
    {
        public IUAdministrarAdiciones()
        {
            InitializeComponent();
        }
        ControladorPizzza objAdminP = new ControladorPizzza();
        string nombrePizz;
        public void setNombrePizz(string nom)
        {
            nombrePizz = nom;
        }
       
        public IUAdministrarAdiciones(string nombre)
        {
            InitializeComponent();
            nombrePizz = nombre;

        }

        public string Get()
        {
            return nombrePizz;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbInsertarAdicion.Checked)
            {
                if (txtPrecio.Text.Equals("") || txtProducto.Text.Equals(""))
                {
                    MessageBox.Show("Llene todos los campos");
                }
                else
                {
                    objAdminP.InsertarAdiciones(nombrePizz, txtProducto.Text, Convert.ToDouble(txtPrecio.Text));
                    dgCambiarAdiciones.DataSource = objAdminP.TraerAdicionesId(nombrePizz);
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                }
            }
            else if (rbBorrarAdicion.Checked)
            {
                txtProducto.Text = "";
                txtPrecio.Text = "";
                int id = Convert.ToInt32(dgCambiarAdiciones.CurrentRow.Cells[0].Value);
                objAdminP.EliminarAdicion(id);
                dgCambiarAdiciones.DataSource = objAdminP.TraerAdicionesId(nombrePizz);
            }
            else if (rbModificarAdicion.Checked)
            {
                if (txtPrecio.Text.Equals("") || txtProducto.Text.Equals(""))
                {
                    MessageBox.Show("Llene todos los campos");
                }
                else
                {
                    int id = Convert.ToInt32(dgCambiarAdiciones.CurrentRow.Cells[0].Value);
                    objAdminP.ActualizarAdicion(id, nombrePizz, txtProducto.Text, Convert.ToDouble(txtPrecio.Text));
                    dgCambiarAdiciones.DataSource = objAdminP.TraerAdicionesId(nombrePizz);
                    txtProducto.Text = "";
                    txtPrecio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AdministrarAdiciones_Load(object sender, EventArgs e)
        {
            dgCambiarAdiciones.DataSource = objAdminP.TraerAdicionesId(nombrePizz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // string precio = dgMenus.CurrentCell.Value.ToString();
            dt = dgCambiarAdiciones.DataSource as DataTable;
            string nombre = dt.Rows[0][1].ToString();


            //string n = dgCambiarAdiciones.CurrentRow.Cells[1].ToString();
            IUAdminPizzeria adm = new IUAdminPizzeria(nombre);
          
            adm.Visible = true;
            Visible = false;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
