using NUnit.Framework;

using System.Net.Http;

namespace pryEvergreenMensajeria.NUnit
{
    public class tscCanal
    {

        //------------Ingresar------------
        [Test]
        public void fncIngresarCanalTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncIngresarCanal?strTipoCanal=AAA";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //------------Consultar------------
        [Test]
        public void fncConsultarCanalTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncConsultarCanal";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}
