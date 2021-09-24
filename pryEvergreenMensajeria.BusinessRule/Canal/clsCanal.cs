using System;
using System.Collections.Generic;
using System.Text;

using pryEvergreenMensajeria.Model.Canal;
using pryEvergreenMensajeria.Broker.Operation;

namespace pryEvergreenMensajeria.BusinessRule.Canal
{
    public class clsCanal : itfCanal
    {
        private optCanal objOptCanal = null;
        public clsCanal()
        {
            objOptCanal = new optCanal();
        }


        public string fncIngresarCanal(mdlCanal objMdlCanal)
        {
            return objOptCanal.fncIngresarCanal(objMdlCanal);
        }

        public List<mdlCanal> fncConsultarCanal(mdlCanal objMdlCanal)
        {
            return objOptCanal.fncConsultarCanal(objMdlCanal);
        }
    }
}
