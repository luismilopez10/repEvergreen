using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Destinatario;
using pryEvergreenMensajeria.Broker.Operation;

namespace pryEvergreenMensajeria.BusinessRule.Destinatario
{
    public class clsDestinatario : itfDestinatario
    {
        private optDestinatario objOptDestinatario = null;
        public clsDestinatario()
        {
            objOptDestinatario = new optDestinatario();
        }


        public string fncIngresarDestinatario(mdlDestinatario objMdlDestinatario)
        {
            return objOptDestinatario.fncIngresarDestinatario(objMdlDestinatario);
        }

        public List<mdlDestinatario> fncConsultarDestinatario(mdlDestinatario objMdlDestinatario)
        {
            return objOptDestinatario.fncConsultarDestinatario(objMdlDestinatario);
        }

        public List<mdlDestinatario> fncConsultarDestinatarioId(mdlDestinatario objMdlDestinatario)
        {
            return objOptDestinatario.fncConsultarDestinatarioId(objMdlDestinatario);
        }
    }
}
