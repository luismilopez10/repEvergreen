using NUnit.Framework;

using System.Net.Http;

namespace pryEvergreenMensajeria.NUnit
{
    public class tscCanal
    {

        //------------Ingresar------------
        [TestCase]
        [Test]
        public void fncIngresarCanalTestCase1()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncIngresarCanal?strTipoCanal=AAA";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //------------Consultar------------
        [TestCase]
        [Test]
        public void fncConsultarCanalTestCase1()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncConsultarCanal";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}
