using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Canal;

namespace pryEvergreenMensajeria.Broker.Interface
{
    public interface itfCanal
    {
        string fncIngresarCanal(mdlCanal objMdlCanal);
        List<mdlCanal> fncConsultarCanal(mdlCanal objMdlCanal);
        List<mdlCanal> fncConsultarCanalId(mdlCanal objMdlCanal);
    }
}
