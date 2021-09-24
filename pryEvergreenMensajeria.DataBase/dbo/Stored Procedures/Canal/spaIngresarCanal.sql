CREATE PROCEDURE [dbo].[spaIngresarCanal]
	@strTipoCanal NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblCanal(strTipoCanal)
		VALUES (@strTipoCanal)
	END