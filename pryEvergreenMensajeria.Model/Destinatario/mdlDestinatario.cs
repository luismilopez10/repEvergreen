using System;
using System.Collections.Generic;
using System.Text;

namespace pryEvergreenMensajeria.Model.Destinatario
{
    public class mdlDestinatario
    {
        public int intIdDestinatario { get; set; }
        public string strNombre { get; set; }
        public string strEmail { get; set; }
        public string strTelefono { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }

        public mdlDestinatario()
        {
        }
    }
}
