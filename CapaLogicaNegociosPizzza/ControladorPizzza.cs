using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosPizzza;
using Comunes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaLogicaNegociosPizzza
{

    public class ControladorPizzza
    {
        string nombrePiz;
        double totalPedido = 0;
        double totalPizza;
        double totalAdiciones = 0;

        public ControladorPizzza(double totalPiz, double totalAdici)
        {
            totalPizza = totalPiz;
            totalAdiciones += totalAdici;
            totalPedido = totalPedido + totalPizza;
        }
        public ControladorPizzza()
        {

        }
        public double Obtener()
        {
            return totalPedido;
        }
        public List<Class1> NombrePizzeria(string pizzeria)
        {
            List<Class1> obj1 = new List<Class1>();
            obj1.Add(new Class1
            {
                NombPizzeria = pizzeria
            });
            return obj1;
        }
        public List<Class1> NombrePizzeriaAdmin(string pizzeria)
        {
            List<Class1> obj1 = new List<Class1>();
            obj1.Add(new Class1
            {
                NombPizzeria = pizzeria
            });
            return obj1;
        }

        public void setNombrePiz(string nPizze)
        {
            nombrePiz = nPizze;
        }
        public string getNombrePiz()
        {
            return nombrePiz;
        }
        BaseDeDatosSql objUsuarioCliente = new BaseDeDatosSql();
        BaseDeDatosSql objPizzeria = new BaseDeDatosSql();
        BaseDeDatosSql objGrafica = new BaseDeDatosSql();
        private double total;

        public double Adiciones(double valor)
        {
            total += valor;
            return valor;
        }

        public static double Pizza(double valor)
        {
            return valor;
        }
        public double Total(double precio)
        {
            return totalPedido += precio;
        }

        public void IngresarDatos(string nombre, string contraseña, string correo, string telefono, string direccion)
        {
            objUsuarioCliente.GuardarUsuario(nombre, contraseña, correo, telefono, direccion);
        }
        public static Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool ValidarNumero(string cadena)
        {
            Regex reg = new Regex("[0-9]");

            bool esUnNumero = reg.IsMatch(cadena);

            return esUnNumero;


        }
        public DataTable TraerPizzeria()
        {
            DataTable nuevo = new DataTable();
            nuevo = objPizzeria.TraerPizzeria();
            return nuevo;
        }
        public DataTable TraerMenuPizzeria(string nombrePizzeria)
        {
            DataTable nuevo = new DataTable();
            nuevo = objPizzeria.TraerMenu(nombrePizzeria);
            return nuevo;
        }
        public DataTable TraerMenuPizzeriaId(string nombrePizzeria)
        {
            DataTable nuevo = new DataTable();
            nuevo = objPizzeria.TraerMenuId(nombrePizzeria);
            return nuevo;
        }

        public DataTable TraerAdiciones(string nombrePizzeria)
        {
            DataTable nuevo = new DataTable();
            nuevo = objPizzeria.TraerAdiciones(nombrePizzeria);
            return nuevo;
        }

        public SqlDataReader iniciarSesionC(string correo, string contraseña)
        {

            SqlDataReader loguearC;
            loguearC = objPizzeria.Login(correo, contraseña);
            return loguearC;
        }
        public SqlDataReader IniciarSesionP(string nombreP, string contraseña)
        {
            SqlDataReader LoguearP;
            LoguearP = objPizzeria.LoginPizzeria(nombreP, contraseña);
            return LoguearP;
        }

        public void ActualizarPizza(int id, string nombrePizzeria, string pizza, string tamaño, double precio)
        {
            objPizzeria.ActualizarPizza(id, nombrePizzeria, pizza, tamaño, precio);
        }

        public void InsertarPizza(string nombreP, string pizza, string tamaño, double precioP)
        {

            objPizzeria.InsertarMenu(nombreP, pizza, tamaño, precioP);

        }

        public void EliminarPizza(int id)
        {
            objPizzeria.BorrarMenu(id);
        }
        public void InsertarAdiciones(string nombreP, string producto, double precioP)
        {

            objPizzeria.InsertarAdicion(nombreP, producto, precioP);

        }
        public void ActualizarAdicion(int id, string nombrePizzeria, string producto, double precio)
        {
            objPizzeria.ActualizarAdicion(id, nombrePizzeria, producto, precio);
        }
        public void EliminarAdicion(int id)
        {
            objPizzeria.BorrarAdicion(id);
        }
        public DataTable TraerAdicionesId(string nombrePizzeria)
        {
            DataTable nuevo = new DataTable();
            nuevo = objPizzeria.TraerAdicionesId(nombrePizzeria);
            return nuevo;
        }
        public void CambiarContraseña(string correo , string ContraseñaNueva )
        {
            BaseDeDatosSql objCambioContraseña = new BaseDeDatosSql();
            objCambioContraseña.CambiarContraseña(correo, ContraseñaNueva);
        }
        public void CambiarContraseñaP(string nombreP, string ContraseñaNueva)
        {
            BaseDeDatosSql objCambioContraseña = new BaseDeDatosSql();
            objCambioContraseña.CambiarContraseñaP(nombreP, ContraseñaNueva);
        }
        public DataTable TraerGrafica()
        {
            DataTable Grafica = new DataTable();
            Grafica = objGrafica.TraerGraficaVentas();
            return Grafica;
        }
        public void ActualizarPrecioVentas(string nombrePizzeria, double precio)
        {
            objPizzeria.ActualizarPrecio(nombrePizzeria, precio);
        }

    }
}
