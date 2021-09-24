CREATE PROCEDURE [dbo].[spaConsultarMensaje]

AS
	BEGIN
		SELECT 
			intIdMensaje, 
			dbo.tblCanal.intIdCanal, 
			dbo.tblCanal.strTipoCanal, 
			strAsunto, 
			strCuerpo,
			strRemitente,
			strDestinatario,
			dbo.tblMensaje.blnActivo,
			dbo.tblMensaje.dtmActualiza
		FROM dbo.tblMensaje INNER JOIN dbo.tblCanal ON dbo.tblMensaje.intIdCanal=dbo.tblCanal.intIdCanal
		WHERE tblMensaje.blnActivo = 1
	END
