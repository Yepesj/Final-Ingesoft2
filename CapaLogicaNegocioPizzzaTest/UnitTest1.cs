using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaLogicaNegociosPizzza;
using System.Data.SqlClient;
using System.Data;

namespace CapaLogicaNegocioPizzzaTest
{
    [TestClass]
    public class ControladorPizzaTest 
    {
        [TestMethod]
        public void TestEmailBienEscrito()
        {
            bool respuestaEsperada = true;
            bool EmailLogicaNegocio = ControladorPizzza.email_bien_escrito("Analzate@ulasallista.com");

            Assert.AreEqual(respuestaEsperada, EmailLogicaNegocio);
        }

        [TestMethod]
        public void TestEmailMalEscritoSinArroba()
        {
            bool respuestaEsperada = false;
            bool EmailLogicaNegocio = ControladorPizzza.email_bien_escrito("Analzate@ulasallista.com");

            Assert.AreEqual(respuestaEsperada, EmailLogicaNegocio);
        }

        [TestMethod]
        public void TestEmailMalEscritoVacio()
        {
            bool respuestaEsperada = false;
            bool EmailLogicaNegocio = ControladorPizzza.email_bien_escrito(" ");

            Assert.AreEqual(respuestaEsperada, EmailLogicaNegocio);
        }

        [TestMethod]
        public void TestValidarNumero()
        {
            bool respuestaEsperada = true;
            bool NumeroBienEscritoLogicaDeNegocio = ControladorPizzza.ValidarNumero("3124558796");

            Assert.AreEqual(respuestaEsperada, NumeroBienEscritoLogicaDeNegocio);
        }

        [TestMethod]
        public void TestPizza()
        {
            double respuestaEsperada = 20000.0;
            double Pizza = ControladorPizzza.Pizza(20000.0);

            Assert.AreEqual(respuestaEsperada, Pizza);
        }

    }
}
