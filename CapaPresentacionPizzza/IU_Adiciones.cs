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
    public partial class IU_Adiciones : Form
    {
        string nombrePizzeria;
        double totalPizza;
        public IU_Adiciones()
        {
            InitializeComponent();
        }
        public IU_Adiciones(double tpizza, string nombre)
        {
            InitializeComponent();
            totalPizza = tpizza;
            nombrePizzeria = nombre;
        }
     
        double totalAdiciones=0;
        ControladorPizzza objPizza = new ControladorPizzza();
       
      
        string variable;
        public string setVariableAdiciones(string x)
        {
            variable = x;
            return variable;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBordeQueso_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double precio = Convert.ToDouble(dgAd.CurrentRow.Cells[2].Value.ToString());
                totalAdiciones += precio;
                MessageBox.Show("Se ha adicionado con éxito");
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // string precio = dgMenus.CurrentCell.Value.ToString();
            dt = dgAd.DataSource as DataTable;
            string precio = dgAd.CurrentRow.Cells[2].Value.ToString();
            IUFactura fact = new IUFactura(totalPizza, totalAdiciones, nombrePizzeria);
            fact.Visible = true;
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IUListaMenus lm = new IUListaMenus(nombrePizzeria);
            
            lm.Visible = true;
            Visible = false;
            
        }

        private void IU_Adiciones_Load(object sender, EventArgs e)
        {
            IUListaMenus obj = new IUListaMenus();
            IU_Pizzeria nuevaPizzeria = new IU_Pizzeria();
            dgAd.DataSource = objPizza.TraerAdiciones(nombrePizzeria);
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
