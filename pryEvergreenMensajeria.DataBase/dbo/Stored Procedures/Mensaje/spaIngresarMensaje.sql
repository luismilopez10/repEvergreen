CREATE PROCEDURE [dbo].[spaIngresarMensaje]
	@intIdCanal INT = 0,
	@strAsunto NVARCHAR(MAX) = '',
	@strCuerpo NVARCHAR(MAX) = '',
	@strRemitente NVARCHAR(MAX) = '',
	@strDestinatario NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblMensaje(intIdCanal, strAsunto, strCuerpo, strRemitente, strDestinatario)
		VALUES (@intIdCanal, @strAsunto, @strCuerpo, @strRemitente, @strDestinatario)
	END