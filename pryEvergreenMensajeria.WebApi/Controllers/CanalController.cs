using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using pryEvergreenMensajeria.BusinessRule.Canal;
using pryEvergreenMensajeria.Model.Canal;

namespace pryEvergreenMensajeria.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CanalController : ControllerBase
    {

        [HttpGet("fncIngresarCanal")]
        public string fncIngresarCanal(string strTipoCanal)
        {
            mdlCanal objMdlCanal = new mdlCanal();
            clsCanal objClsCanal = new clsCanal();
            objMdlCanal.strTipoCanal = strTipoCanal;
            return objClsCanal.fncIngresarCanal(objMdlCanal);
        }

        [HttpGet("fncConsultarCanal")]
        public List<mdlCanal> fncConsultarCanal()
        {
            mdlCanal objMdlCanal = new mdlCanal();
            clsCanal objClsCanal = new clsCanal();
            return objClsCanal.fncConsultarCanal(objMdlCanal);
        }
    }
}
