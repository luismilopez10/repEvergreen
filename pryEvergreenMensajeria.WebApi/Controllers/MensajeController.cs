using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryEvergreenMensajeria.BusinessRule.Mensaje;
using pryEvergreenMensajeria.Model.Mensaje;

namespace pryEvergreenMensajeria.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MensajeController : ControllerBase
    {

        [HttpGet("fncIngresarMensaje")]
        public string fncIngresarMensaje(int intIdCanal, int intIdDestinatario, string strAsunto, string strCuerpo, string strRemitente)
        {
            mdlMensaje objMdlMensaje = new mdlMensaje();
            clsMensaje objClsMensaje = new clsMensaje();
            objMdlMensaje.intIdCanal = intIdCanal;
            objMdlMensaje.intIdDestinatario = intIdDestinatario;
            objMdlMensaje.strAsunto = strAsunto;
            objMdlMensaje.strCuerpo = strCuerpo;
            objMdlMensaje.strRemitente = strRemitente;
            return objClsMensaje.fncIngresarMensaje(objMdlMensaje);
        }

        [HttpGet("fncConsultarMensaje")]
        public List<mdlMensaje> fncConsultarMensaje()
        {
            mdlMensaje objMdlMensaje = new mdlMensaje();
            clsMensaje objClsMensaje = new clsMensaje();
            return objClsMensaje.fncConsultarMensaje(objMdlMensaje);
        }
    }
}
