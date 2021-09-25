CREATE PROCEDURE [dbo].[spaConsultarCanalId]
	@intIdCanal INT = 0
AS
	BEGIN
		SELECT 
			intIdCanal, 
			strTipoCanal, 
			dtmFecha,
			blnActivo,
			dtmActualiza
		FROM dbo.tblCanal
		WHERE tblCanal.blnActivo = 1
		AND tblCanal.intIdCanal = @intIdCanal
	END
