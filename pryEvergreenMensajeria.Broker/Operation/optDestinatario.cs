using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryEvergreenMensajeria.Model.Destinatario;
using pryEvergreenMensajeria.Broker.Procedure;
using pryEvergreenMensajeria.Broker.Interface;

namespace pryEvergreenMensajeria.Broker.Operation
{
    public class optDestinatario : itfDestinatario
    {
        // Base de Datos Local
        //string strConnectionString = @"Data Source=DESKTOP-PHVSG8C;Initial Catalog=dbaEvergreen;User ID=evergreen;Password=evergreen;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Base de Datos Azure
        string strConnectionString = @"Server=tcp:lmlopezl.database.windows.net,1433;Initial Catalog=dbaEvergreen;Persist Security Info=False;User ID=lmlopezl;Password=6PPaBdKBnAgMmb3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaDestinatario objSpaDestinatario = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlDestinatario> lstDestinatario = null;

        public optDestinatario()
        {
        }



        public string fncIngresarDestinatario(mdlDestinatario objMdlDestinatario)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaDestinatario = new spaDestinatario();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaDestinatario.spaIngresarDestinatario, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@strNombre", objMdlDestinatario.strNombre);
                objCom.Parameters.AddWithValue("@strEmail", objMdlDestinatario.strEmail);
                objCom.Parameters.AddWithValue("@strTelefono", objMdlDestinatario.strTelefono);
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


        public List<mdlDestinatario> fncConsultarDestinatario(mdlDestinatario objMdlDestinatario)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaDestinatario = new spaDestinatario();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaDestinatario.spaConsultarDestinatario, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstDestinatario = new List<mdlDestinatario>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlDestinatario = new mdlDestinatario();
                    objMdlDestinatario.intIdDestinatario = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdDestinatario"].ToString());
                    objMdlDestinatario.strNombre = Convert.ToString(objDst.Tables[0].Rows[i]["strNombre"].ToString());
                    objMdlDestinatario.strEmail = Convert.ToString(objDst.Tables[0].Rows[i]["strEmail"].ToString());
                    objMdlDestinatario.strTelefono = Convert.ToString(objDst.Tables[0].Rows[i]["strTelefono"].ToString());
                    objMdlDestinatario.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlDestinatario.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstDestinatario.Add(objMdlDestinatario);
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
            return lstDestinatario;
        }


        public List<mdlDestinatario> fncConsultarDestinatarioId(mdlDestinatario objMdlDestinatario)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaDestinatario = new spaDestinatario();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaDestinatario.spaConsultarDestinatarioId, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@intIdDestinatario", objMdlDestinatario.intIdDestinatario);

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstDestinatario = new List<mdlDestinatario>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlDestinatario = new mdlDestinatario();
                    objMdlDestinatario.intIdDestinatario = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdDestinatario"].ToString());
                    objMdlDestinatario.strNombre = Convert.ToString(objDst.Tables[0].Rows[i]["strNombre"].ToString());
                    objMdlDestinatario.strEmail = Convert.ToString(objDst.Tables[0].Rows[i]["strEmail"].ToString());
                    objMdlDestinatario.strTelefono = Convert.ToString(objDst.Tables[0].Rows[i]["strTelefono"].ToString());
                    objMdlDestinatario.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlDestinatario.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstDestinatario.Add(objMdlDestinatario);
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
            return lstDestinatario;
        }
    }
}
