using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploConsumir
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_suma_Click(object sender, EventArgs e)
        {
            WebServiceEj.EjemploSoapClient sumar = new WebServiceEj.EjemploSoapClient();
            lblresultado.Text = sumar.Suma(double.Parse(valora.Text), double.Parse(valorb.Text)).ToString();
        }

        protected void btn_resta_Click(object sender, EventArgs e)
        {
            WebServiceEj.EjemploSoapClient restar = new WebServiceEj.EjemploSoapClient();
            lblresultado.Text = restar.Resta(double.Parse(valora.Text), double.Parse(valorb.Text)).ToString();
        }

        protected void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            WebServiceEj.EjemploSoapClient multiplicar = new WebServiceEj.EjemploSoapClient();
            lblresultado.Text = multiplicar.Multiplicacion(double.Parse(valora.Text), double.Parse(valorb.Text)).ToString();
        }

        protected void btn_division_Click(object sender, EventArgs e)
        {
            WebServiceEj.EjemploSoapClient dividir = new WebServiceEj.EjemploSoapClient();
            lblresultado.Text = dividir.Division(double.Parse(valora.Text), double.Parse(valorb.Text)).ToString();
        }
    }
}