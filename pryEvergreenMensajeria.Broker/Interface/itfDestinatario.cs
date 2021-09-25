using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Destinatario;

namespace pryEvergreenMensajeria.Broker.Interface
{
    public interface itfDestinatario
    {
        string fncIngresarDestinatario(mdlDestinatario objMdlDestinatario);
        List<mdlDestinatario> fncConsultarDestinatario(mdlDestinatario objMdlDestinatario);
        List<mdlDestinatario> fncConsultarDestinatarioId(mdlDestinatario objMdlDestinatario);
    }
}
