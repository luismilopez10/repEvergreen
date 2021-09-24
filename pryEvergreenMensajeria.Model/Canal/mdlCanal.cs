using System;
using System.Collections.Generic;
using System.Text;

namespace pryEvergreenMensajeria.Model.Canal
{
    public class mdlCanal
    {
        public int intIdCanal { get; set; }
        public string strTipoCanal { get; set; }
        public DateTime dtmFecha { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }

        public mdlCanal()
        {
        }
    }
}
