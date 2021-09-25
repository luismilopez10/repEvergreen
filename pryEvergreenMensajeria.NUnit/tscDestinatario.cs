using NUnit.Framework;

using System.Net.Http;

namespace pryEvergreenMensajeria.NUnit
{
    public class tscDestinatario
    {

        //------------Ingresar------------
        [Test]
        public void fncIngresarDestinatarioTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Destinatario/fncIngresarDestinatario?strNombre=AAA&strEmail=AAA&strTelefono=000";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        //------------Consultar------------
        [Test]
        public void fncConsultarDestinatarioTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Destinatario/fncConsultarDestinatario";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }


        [Test]
        public void fncConsultarDestinatarioIdTest()
        {
            // API Azure
            string strURL = @"https://pryevergreenmensajeriawebapi20210924150107.azurewebsites.net/api/Destinatario/fncConsultarDestinatarioId?intIdDestinatario=1";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}
