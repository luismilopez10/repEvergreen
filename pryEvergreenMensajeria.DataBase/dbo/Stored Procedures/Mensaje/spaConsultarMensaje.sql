CREATE PROCEDURE [dbo].[spaConsultarMensaje]

AS
	BEGIN
		SELECT 
			intIdMensaje, 
			intIdCanal,  
			intIdDestinatario,
			strAsunto, 
			strCuerpo,
			strRemitente,
			dbo.tblMensaje.blnActivo,
			dbo.tblMensaje.dtmActualiza
		FROM dbo.tblMensaje 
		WHERE tblMensaje.blnActivo = 1
	END
