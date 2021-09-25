CREATE PROCEDURE [dbo].[spaConsultarDestinatarioId]
	@intIdDestinatario INT = 0
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
		AND tblDestinatario.intIdDestinatario = @intIdDestinatario
	END
