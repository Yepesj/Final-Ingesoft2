using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CapaLogicaNegociosPizzza;

namespace CapaPresentacionPizzza
{
    public partial class IUFactura : Form
    {
        ControladorPizzza objP = new ControladorPizzza();
        double totalPizza;
        double totalAdiciones;
        double totalPedido;
        string nombre;
        public IUFactura()
        {
            InitializeComponent();
        }

        public IUFactura(double pizza, double add, string nombrePizz)
        {
            InitializeComponent();
            totalPizza = pizza;
            totalAdiciones = add;
            nombre = nombrePizz;
            totalPedido = totalPizza + totalAdiciones;

        }
        ControladorPizzza objControlador = new ControladorPizzza();
        
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Cerrar()
        {
         
        }
        private void Factura_Load(object sender, EventArgs e)
        {
            label3.Text = nombre;
            totalPedido = totalPizza + totalAdiciones+2000;
            txtDomicilio.Text = "2000";
            txtTotal.Text = totalPedido.ToString();
            txtPizza.Text = totalPizza.ToString();
            txtAdiciones.Text = totalAdiciones.ToString();
            objP.ActualizarPrecioVentas(nombre,totalPedido);
            
            

        }

        private void txtAdiciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IuLoginj volverAlInicio = new IuLoginj();
            volverAlInicio.Visible = true;
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
