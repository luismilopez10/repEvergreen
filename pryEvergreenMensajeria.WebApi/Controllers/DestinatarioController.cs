using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryEvergreenMensajeria.BusinessRule.Destinatario;
using pryEvergreenMensajeria.Model.Destinatario;

namespace pryEvergreenMensajeria.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DestinatarioController : ControllerBase
    {

        [HttpGet("fncIngresarDestinatario")]
        public string fncIngresarDestinatario(string strNombre, string strEmail, string strTelefono)
        {
            mdlDestinatario objMdlDestinatario = new mdlDestinatario();
            clsDestinatario objClsDestinatario = new clsDestinatario();
            objMdlDestinatario.strNombre = strNombre;
            objMdlDestinatario.strEmail = strEmail;
            objMdlDestinatario.strTelefono = strTelefono;
            return objClsDestinatario.fncIngresarDestinatario(objMdlDestinatario);
        }

        [HttpGet("fncConsultarDestinatario")]
        public List<mdlDestinatario> fncConsultarDestinatario()
        {
            mdlDestinatario objMdlDestinatario = new mdlDestinatario();
            clsDestinatario objClsDestinatario = new clsDestinatario();
            return objClsDestinatario.fncConsultarDestinatario(objMdlDestinatario);
        }

        [HttpGet("fncConsultarDestinatarioId")]
        public List<mdlDestinatario> fncConsultarDestinatarioId(int intIdDestinatario)
        {
            mdlDestinatario objMdlDestinatario = new mdlDestinatario();
            clsDestinatario objClsDestinatario = new clsDestinatario();
            objMdlDestinatario.intIdDestinatario = intIdDestinatario;
            return objClsDestinatario.fncConsultarDestinatarioId(objMdlDestinatario);
        }
    }
}
