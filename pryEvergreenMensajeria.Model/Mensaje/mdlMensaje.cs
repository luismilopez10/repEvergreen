using System;
using System.Collections.Generic;
using System.Text;

namespace pryEvergreenMensajeria.Model.Mensaje
{
    public class mdlMensaje
    {
        public int intIdMensaje { get; set; }
        public int intIdCanal { get; set; }
        public string strTipoCanal { get; set; }
        public string strAsunto { get; set; }
        public string strCuerpo { get; set; }
        public string strRemitente { get; set; }
        public string strDestinatario { get; set; }
        public bool blnActivo { get; set; }
        public DateTime dtmActualiza { get; set; }
    }
}
