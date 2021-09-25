CREATE PROCEDURE [dbo].[spaIngresarDestinatario]
	@strNombre NVARCHAR(MAX) = '',
	@strEmail NVARCHAR(MAX) = '',
	@strTelefono NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblDestinatario(strNombre, strEmail, strTelefono)
		VALUES (@strNombre, @strEmail, @strTelefono)
	END