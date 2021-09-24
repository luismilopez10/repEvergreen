CREATE PROCEDURE [dbo].[spaConsultarCanal]

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
	END
