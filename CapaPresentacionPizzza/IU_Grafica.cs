using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaLogicaNegociosPizzza;
using System.Data.SqlClient;

namespace CapaPresentacionPizzza
{
    public partial class IU_Grafica : Form
    {
        string nombreP;
        public IU_Grafica()
        {
            InitializeComponent();
        }
        public IU_Grafica(string nombrePizz)
        {
            InitializeComponent();
            nombreP = nombrePizz;
        }

        DataRow DR;

        private void IU_Grafica_Load(object sender, EventArgs e)
        {
            ControladorPizzza objGrafica = new ControladorPizzza();
            this.chart1.Palette = ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("Ingresos totales");
            if (objGrafica.TraerGrafica().Rows.Count>0)
            {
                for (int i = 0; i < objGrafica.TraerGrafica().Rows.Count; i++)
                {
                    DR = objGrafica.TraerGrafica().Rows[i];
                    Series series = this.chart1.Series.Add(DR.ItemArray[0].ToString());
                    series.Points.Add(Convert.ToDouble(DR.ItemArray[1]));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUAdminPizzeria objAdmin = new IUAdminPizzeria(nombreP);
            objAdmin.Visible = true;
            Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
