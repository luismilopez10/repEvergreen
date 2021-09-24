using NUnit.Framework;

using System.Net.Http;

namespace pryEvergreenMensajeria.NUnit
{
    public class tscEvergreenMensajeria
    {

        //-------------------------------Canal Test-------------------------------
        [Test]
        public void fncIngresarCanalTest()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncIngresarCanal?strTipoCanal=AAA";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        [Test]
        public void fncConsultarCanalTest()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Canal/fncConsultarCanal";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //-------------------------------Canal Test-------------------------------
        [Test]
        public void fncIngresarMensajeTest()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Mensaje/fncIngresarMensaje?intIdCanal=1&strAsunto=Prueba&strCuerpo=Mensaje%20de%20prueba&strRemitente=000&strDestinatario=111";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        [Test]
        public void fncConsultarMensajeTest()
        {
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Mensaje/fncConsultarMensaje";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}