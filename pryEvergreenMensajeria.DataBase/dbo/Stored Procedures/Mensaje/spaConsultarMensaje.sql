CREATE PROCEDURE [dbo].[spaConsultarMensaje]

AS
	BEGIN
		SELECT 
			intIdMensaje, 
			dbo.tblCanal.intIdCanal, 
			dbo.tblCanal.strTipoCanal, 
			dbo.tblDestinatario.intIdDestinatario,
			strAsunto, 
			strCuerpo,
			strRemitente,
			dbo.tblMensaje.blnActivo,
			dbo.tblMensaje.dtmActualiza
		FROM dbo.tblMensaje 
			INNER JOIN dbo.tblCanal ON dbo.tblMensaje.intIdCanal=dbo.tblCanal.intIdCanal
			INNER JOIN dbo.tblDestinatario ON dbo.tblMensaje.intIdDestinatario=dbo.tblDestinatario.intIdDestinatario
		WHERE tblMensaje.blnActivo = 1
	END
