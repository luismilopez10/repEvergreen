using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using pryEvergreenMensajeria.Model.Canal;
using pryEvergreenMensajeria.Broker.Procedure;
using pryEvergreenMensajeria.Broker.Interface;

namespace pryEvergreenMensajeria.Broker.Operation
{
    public class optCanal : itfCanal
    {
        // Base de Datos Local
        //string strConnectionString = @"Data Source=DESKTOP-PHVSG8C;Initial Catalog=dbaEvergreen;User ID=evergreen;Password=evergreen;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Base de Datos Azure
        string strConnectionString = @"Server=tcp:lmlopezl.database.windows.net,1433;Initial Catalog=dbaEvergreen;Persist Security Info=False;User ID=lmlopezl;Password=6PPaBdKBnAgMmb3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        SqlConnection objCon = null;
        SqlCommand objCom = null;
        spaCanal objSpaCanal = null;
        SqlDataAdapter objDap = null;
        DataSet objDst = null;
        List<mdlCanal> lstCanal = null;

        public optCanal()
        {
        }



        public string fncIngresarCanal(mdlCanal objMdlCanal)
        {
            int intResultado;
            string strResultado = "";
            objCon = new SqlConnection(strConnectionString);
            objSpaCanal = new spaCanal();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaCanal.spaIngresarCanal, objCon);
                objCom.CommandType = CommandType.StoredProcedure;
                objCom.Parameters.AddWithValue("@strTipoCanal", objMdlCanal.strTipoCanal);
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


        public List<mdlCanal> fncConsultarCanal(mdlCanal objMdlCanal)
        {
            string strResultado;

            objCon = new SqlConnection(strConnectionString);
            objSpaCanal = new spaCanal();

            try
            {
                objCon.Open();
                objCom = new SqlCommand(objSpaCanal.spaConsultarCanal, objCon);
                objCom.CommandType = CommandType.StoredProcedure;

                objDap = new SqlDataAdapter();
                objDap.SelectCommand = objCom;

                objDst = new DataSet();
                objDap.Fill(objDst);

                lstCanal = new List<mdlCanal>();

                for (int i = 0; i < objDst.Tables[0].Rows.Count; i++)
                {
                    objMdlCanal = new mdlCanal();
                    objMdlCanal.intIdCanal = Convert.ToInt32(objDst.Tables[0].Rows[i]["intIdCanal"].ToString());
                    objMdlCanal.strTipoCanal = Convert.ToString(objDst.Tables[0].Rows[i]["strTipoCanal"].ToString());
                    objMdlCanal.dtmFecha = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmFecha"].ToString());
                    objMdlCanal.blnActivo = Convert.ToBoolean(objDst.Tables[0].Rows[i]["blnActivo"].ToString());
                    objMdlCanal.dtmActualiza = Convert.ToDateTime(objDst.Tables[0].Rows[i]["dtmActualiza"].ToString());
                    lstCanal.Add(objMdlCanal);
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
            return lstCanal;
        }
    }
}
