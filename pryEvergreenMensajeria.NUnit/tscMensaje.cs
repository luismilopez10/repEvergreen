using NUnit.Framework;

using System.Net.Http;

namespace pryEvergreenMensajeria.NUnit
{
    public class tscMensaje
    {

        //------------Ingresar------------
        [Test]
        public void fncIngresarMensajeTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Mensaje/fncIngresarMensaje?intIdCanal=1&intIdDestinatario=1&strAsunto=Prueba&strCuerpo=Mensaje%20de%20prueba&strRemitente=000";


            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //------------Consultar------------
        [Test]
        public void fncConsultarMensajeTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Mensaje/fncConsultarMensaje";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}