using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjemploWebService
{
    /// <summary>
    /// Summary description for Ejemplo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Ejemplo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double Suma(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Resta(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Division(double a, double b)
        {
            double respuesta;
            if (b != 0)
            {
                respuesta = a / b;
            } else
            {
                respuesta = 0;
            }
            return respuesta;
        }
    }
}
