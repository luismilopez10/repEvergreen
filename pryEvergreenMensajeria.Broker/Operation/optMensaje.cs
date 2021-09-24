using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryEvergreenMensajeria.Model.Mensaje;
using pryEvergreenMensajeria.Broker.Procedure;
using pryEvergreenMensajeria.Broker.Interface;

namespace pryEvergreenMensajeria.Broker.Operation
{
    public class optMensaje : itfMensaje
    {
        // Base de Datos Local
        //string strConnectionString = @"Data Source=DESKTOP-PHVSG8C;User ID=evergreen;Password=evergreen;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Base de Datos Azure
        string strConnectionString = @"Server=tcp:lmlopezl.database.windows.net,1433;Initial Catalog=dbaEvergreen;Persist Security Info=False;User ID=lmlopezl;Password=6PPaBdKBnAgMmb3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaMensaje objSpaMensaje = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlMensaje> lstMensaje = null;

        public optMensaje()
        {
        }



        public string fncIngresarMensaje(mdlMensaje objMdlMensaje)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaMensaje = new spaMensaje();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaMensaje.spaIngresarMensaje, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdCanal", objMdlMensaje.intIdCanal);
                objCom.Parameters.AddWithValue("@strAsunto", objMdlMensaje.strAsunto);
                objCom.Parameters.AddWithValue("@strCuerpo", objMdlMensaje.strCuerpo);
                objCom.Parameters.AddWithValue("@strRemitente", objMdlMensaje.strRemitente);
                objCom.Parameters.AddWithValue("@strDestinatario", objMdlMensaje.strDestinatario);
                intResultado = objCom.ExecuteNonQuery();

                if (intResultado > 0)
                {
                    strResultado = "Ingresar Exitoso";
                }
                else
                {
                    strResultado = "Ingresar Fallido";
                }
            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }

            return strResultado;
        }


        public List<mdlMensaje> fncConsultarMensaje(mdlMensaje objMdlMensaje)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaMensaje = new spaMensaje();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaMensaje.spaConsultarMensaje, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstMensaje = new List<mdlMensaje>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlMensaje = new mdlMensaje();
                    objMdlMensaje.intIdMensaje = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdMensaje"].ToString());
                    objMdlMensaje.intIdCanal = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCanal"].ToString());
                    objMdlMensaje.strTipoCanal = Convert.ToString(objDst.Tables[0].Rows[i]["strTipoCanal"].ToString());
                    objMdlMensaje.strAsunto = Convert.ToString(objDst.Tables[0].Rows[i]["strAsunto"].ToString());
                    objMdlMensaje.strCuerpo = Convert.ToString(objDst.Tables[0].Rows[i]["strCuerpo"].ToString());
                    objMdlMensaje.strRemitente = Convert.ToString(objDst.Tables[0].Rows[i]["strRemitente"].ToString());
                    objMdlMensaje.strDestinatario = Convert.ToString(objDst.Tables[0].Rows[i]["strDestinatario"].ToString());
                    objMdlMensaje.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlMensaje.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstMensaje.Add(objMdlMensaje);
                }

            }
            catch (SqlException ex)
            {
                strResultado = ex.Message.ToString();
            }
            finally
            {
                objCon.Close();
            }
            return lstMensaje;
        }
    }
}
