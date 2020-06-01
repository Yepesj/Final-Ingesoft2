using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaLogicaNegociosPizzza;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacionPizzza
{
    public partial class IUListaMenus : Form
    {
        public IUListaMenus()
        {
            InitializeComponent();
        }
        double tpizza;
        public IUListaMenus(double total)
        {
            InitializeComponent();
           tpizza = total;
        }
        public IUListaMenus(string nombre)
        {
            InitializeComponent();
           np=nombre;
        }
        string np;
        IU_Adiciones objAdiciones = new IU_Adiciones();
        public string SetVariable(string nomPizzeria)
        {
            np = nomPizzeria;
          
            return np;
        }
      

        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaMenus_Load(object sender, EventArgs e)
        {
            
            label1.Text = Retornar();
            ControladorPizzza pi = new ControladorPizzza();
            dgMenus.DataSource = pi.TraerMenuPizzeria(np);
           
         
          




        }
        public string Retornar()
        {
            return np;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorPizzza pi = new ControladorPizzza();
               
        
            DataTable dt = new DataTable();
           // string precio = dgMenus.CurrentCell.Value.ToString();
            dt = dgMenus.DataSource as DataTable;
            

            string nombre = dt.Rows[0][0].ToString();
            string precio = dgMenus.CurrentRow.Cells[3].Value.ToString();
            
           // MessageBox.Show(precio);

           
                 dgMenus.DataSource = pi.TraerMenuPizzeria(np);
                //IU_Adiciones ir = new IU_Adiciones();
                IU_Adiciones irPizza = new IU_Adiciones(double.Parse(precio),nombre);
                irPizza.Visible = true;
                this.Visible = false;
              
            
         
                
            
          

        }

        private void dgMenus_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            IU_Pizzeria lsitaPizzeria = new IU_Pizzeria();
            lsitaPizzeria.Visible = true;
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
