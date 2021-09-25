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
			blnActivo,
			dtmActualiza
		FROM dbo.tblMensaje 
		WHERE tblMensaje.blnActivo = 1
	END
