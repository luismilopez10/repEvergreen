using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Mensaje;
using pryEvergreenMensajeria.Broker.Operation;

namespace pryEvergreenMensajeria.BusinessRule.Mensaje
{
    public class clsMensaje : itfMensaje
    {
        private optMensaje objOptMensaje = null;
        public clsMensaje()
        {
            objOptMensaje = new optMensaje();
        }


        public string fncIngresarMensaje(mdlMensaje objMdlMensaje)
        {
            return objOptMensaje.fncIngresarMensaje(objMdlMensaje);
        }

        public List<mdlMensaje> fncConsultarMensaje(mdlMensaje objMdlMensaje)
        {
            return objOptMensaje.fncConsultarMensaje(objMdlMensaje);
        }
    }
}
