using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Configuration;

namespace CapaDatosPizzza
{
    public class BaseDeDatosSql: SqlBase
    {

        // private conexion conexion = new conexion();
        private SqlDataReader leer;
        private string Email, Nombres, Contraeña;
        private string Mensaje;
        //private SqlCommand Comando = new SqlCommand();

        public void GuardarUsuario(string nombre, string contraseña, string correo, string telefono, string direccion)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CADENACONEXION"]);
            SqlCommand sqlCmd = new SqlCommand("uspRegistrar", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            sqlCmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = contraseña;
            sqlCmd.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = correo;
            sqlCmd.Parameters.Add("@telefono", SqlDbType.BigInt).Value = telefono;
            sqlCmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            cn.Open();
            sqlCmd.ExecuteNonQuery();
            cn.Close();

        }
        /*public void GuardarUsuario(string nombre, string contraseña, string correo, string telefono, string direccion)
        {

            SqlConnection objCn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Pizzza;Data Source=DESKTOP-A8G78CI");
            SqlCommand sqlCmd = new SqlCommand("uspRegistrar", objCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            sqlCmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = contraseña;
            sqlCmd.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = correo;
            sqlCmd.Parameters.Add("@telefono", SqlDbType.BigInt).Value = telefono;
            sqlCmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            objCn.Open();
            sqlCmd.ExecuteNonQuery();
            cn.Close();

        }*/
        public SqlDataReader Login(string correo, string contraseña) { 
        
            
           
            SqlCommand sqlCmd = new SqlCommand("uspIniciarSesion", cn,tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            sqlCmd.Parameters.Add("@Correo", SqlDbType.NVarChar,50).Value=correo;
            sqlCmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar,50).Value=contraseña;
            leer = sqlCmd.ExecuteReader();
            //cn.Close();
            Console.WriteLine(leer);
            return leer;

        }

        public SqlDataReader LoginPizzeria(string nombre, string contraseña)
        {
            
            SqlCommand sqlCmd = new SqlCommand("uspLoginPizzeria", cn,tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            sqlCmd.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = nombre;
            sqlCmd.Parameters.Add("@contraseña", SqlDbType.NVarChar, 50).Value = contraseña;
            leer = sqlCmd.ExecuteReader();
            //sqlCn.Close();
            Console.WriteLine(leer);
            return leer;

        }


        public DataTable TraerPizzeria()
        {

            DataTable nombrePizzeria = new DataTable();
            
            SqlCommand sqlCmd = new SqlCommand("uspTraerNombrePizzeria", cn,tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            
            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(nombrePizzeria);
            cn.Close();
            return nombrePizzeria;

        }
        public DataTable TraerMenu(string nombre)
        {

            DataTable menu = new DataTable();
            
            SqlCommand sqlCmd = new SqlCommand("uspTraerMenu", cn,tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Pizzeria", SqlDbType.NVarChar).Value = nombre;
            
            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(menu);
            cn.Close();
            return menu;

        }
        public DataTable TraerMenuId(string nombre)
        {

            DataTable menu = new DataTable();

            SqlCommand sqlCmd = new SqlCommand("uspTraerMenuConId", cn, tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Pizzeria", SqlDbType.NVarChar).Value = nombre;

            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(menu);
            cn.Close();
            return menu;

        }

        public DataTable TraerAdiciones(string nombre)
        {

            DataTable menu = new DataTable();
            
            SqlCommand sqlCmd = new SqlCommand("uspAdiciones", cn,tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombre;
            
            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(menu);
            cn.Close();
            return menu;

        }
        public DataTable TraerAdicionesId(string nombre)
        {

            DataTable menu = new DataTable();

            SqlCommand sqlCmd = new SqlCommand("uspAdicionesId", cn, tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombre;

            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(menu);
            cn.Close();
            return menu;

        }
        public void InsertarMenu(string nombrePizzeria, string pizza, string tamaño, double precio)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspInesertarPizza", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombrePizzeria;
            sqlCmd.Parameters.Add("@pizza", SqlDbType.NVarChar).Value = pizza;
            sqlCmd.Parameters.Add("@tamaño", SqlDbType.NVarChar).Value = tamaño;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
           

            sqlCmd.ExecuteNonQuery();
            

        }
        public void BorrarMenu(int id)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspEliminarPizza", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCmd.ExecuteNonQuery();


        }
        public void ActualizarPizza(int id , string nombrePizzeria, string pizza, string tamaño , double precio)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspActualizarP", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombrePizzeria;
            sqlCmd.Parameters.Add("@pizza", SqlDbType.NVarChar).Value = pizza;
            sqlCmd.Parameters.Add("@tamaño", SqlDbType.NVarChar).Value = tamaño;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
            sqlCmd.ExecuteNonQuery();


        }

        public void InsertarAdicion(string nombrePizzeria, string producto, double precio)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspInesertarAdicion", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombrePizzeria;
            sqlCmd.Parameters.Add("@producto", SqlDbType.NVarChar).Value = producto;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Money).Value = precio;


            sqlCmd.ExecuteNonQuery();


        }
        public void ActualizarAdicion(int id, string nombrePizzeria, string producto, double precio)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspActualizarAdicion", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCmd.Parameters.Add("@nombrepizzeria", SqlDbType.NVarChar).Value = nombrePizzeria;
            sqlCmd.Parameters.Add("@producto", SqlDbType.NVarChar).Value = producto;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Money).Value = precio;
            sqlCmd.ExecuteNonQuery();


        }
        public void BorrarAdicion(int id)
        {
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand("uspEliminarAdicion", cn, tran);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCmd.ExecuteNonQuery();
        }
        public void CambiarContraseña(string correo , string contraseñaNueva)
        {

            // SqlCommand sqlCmd = new SqlCommand("uspActualizarContraseña", cn, tran);
            SqlConnection objCn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Pizzza;Data Source=DESKTOP-A8G78CI");
            SqlCommand sqlCmd = new SqlCommand("uspActualizarContraseña", objCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@coreo", SqlDbType.NVarChar).Value = correo;
            sqlCmd.Parameters.Add("@ContraseñaN", SqlDbType.NVarChar).Value = contraseñaNueva;
            objCn.Open();
            sqlCmd.ExecuteNonQuery();
            objCn.Close();
        }
        public void CambiarContraseñaP(string nombreP, string contraseñaNueva)
        {

            //SqlCommand sqlCmd = new SqlCommand("uspActualizarContraseña", cn, tran);
            //SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CADENACONEXION"]);
            SqlConnection objCn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Pizzza;Data Source=DESKTOP-A8G78CI");
            SqlCommand sqlCmd = new SqlCommand("uspActualizarContraseñaP", objCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombreP;
            sqlCmd.Parameters.Add("@ContraseñaN", SqlDbType.NVarChar).Value = contraseñaNueva;
            objCn.Open();
            sqlCmd.ExecuteNonQuery();
            objCn.Close();
        }
        public DataTable TraerGraficaVentas()
        {
            
            DataTable Grafica = new DataTable();
            //SqlConnection objCn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Pizzza;Data Source=DESKTOP-ANDRES\SQLEXPRESS");
            //SqlCommand sqlCmd = new SqlCommand("uspTraerGrafica", objCn);
            SqlCommand sqlCmd = new SqlCommand("uspTraerGrafica", cn, tran);
            SqlDataAdapter nombreCan = new SqlDataAdapter(sqlCmd);
            sqlCmd.CommandType = CommandType.StoredProcedure;    
            sqlCmd.ExecuteNonQuery();
            nombreCan.Fill(Grafica);
            /*cn.Close();*/
            return Grafica;

        }
        public void ActualizarPrecio( string nombrePizzeria, double precio)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["CADENACONEXION"]);
            SqlCommand sqlCmd = new SqlCommand("uspActualizarPrecio", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@nombreP", SqlDbType.NVarChar).Value = nombrePizzeria;
            sqlCmd.Parameters.Add("@venta", SqlDbType.Money).Value = precio;
            cn.Open();
            sqlCmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}
