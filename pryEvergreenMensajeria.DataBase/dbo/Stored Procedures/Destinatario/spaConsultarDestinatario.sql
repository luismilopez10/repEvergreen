CREATE PROCEDURE [dbo].[spaConsultarDestinatario]

AS
	BEGIN
		SELECT 
			intIdDestinatario,
			strNombre, 
			strEmail,
			strTelefono,
			blnActivo,
			dtmActualiza
		FROM dbo.tblDestinatario
		WHERE tblDestinatario.blnActivo = 1
	END
