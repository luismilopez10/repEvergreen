using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Mensaje;

namespace pryEvergreenMensajeria.BusinessRule.Mensaje
{
    public interface itfMensaje
    {
        string fncIngresarMensaje(mdlMensaje objMdlMensaje);
        List<mdlMensaje> fncConsultarMensaje(mdlMensaje objMdlMensaje);
    }
}
