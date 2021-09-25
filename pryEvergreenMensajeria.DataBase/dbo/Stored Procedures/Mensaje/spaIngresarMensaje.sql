CREATE PROCEDURE [dbo].[spaIngresarMensaje]
	@intIdCanal INT = 0,
	@intIdDestinatario INT = 0,
	@strAsunto NVARCHAR(MAX) = '',
	@strCuerpo NVARCHAR(MAX) = '',
	@strRemitente NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblMensaje(intIdCanal, intIdDestinatario, strAsunto, strCuerpo, strRemitente)
		VALUES (@intIdCanal, @intIdDestinatario, @strAsunto, @strCuerpo, @strRemitente)
	END