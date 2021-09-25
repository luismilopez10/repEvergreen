CREATE TABLE [dbo].[tblMensaje] (
    [intIdMensaje]      INT            IDENTITY (1, 1) NOT NULL,
    [intIdCanal]        INT            NULL,
    [intIdDestinatario] INT            NULL,
    [strAsunto]         NVARCHAR (MAX) NULL,
    [strCuerpo]         NVARCHAR (MAX) NULL,
    [strRemitente]      NVARCHAR (MAX) NULL,
    [blnActivo]         BIT            DEFAULT ((1)) NULL,
    [dtmActualiza]      DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblMensaje] PRIMARY KEY CLUSTERED ([intIdMensaje] ASC),
    CONSTRAINT [FK_tblMensaje_tblCanal] FOREIGN KEY ([intIdCanal]) REFERENCES [dbo].[tblCanal] ([intIdCanal]),
    CONSTRAINT [FK_tblMensaje_tblDestinatario] FOREIGN KEY ([intIdDestinatario]) REFERENCES [dbo].[tblDestinatario] ([intIdDestinatario])
);






GO
CREATE NONCLUSTERED INDEX [IXFK_tblMensaje_tblCanal]
    ON [dbo].[tblMensaje]([intIdCanal] ASC);


GO
CREATE NONCLUSTERED INDEX [IXFK_tblMensaje_tblDestinatario]
    ON [dbo].[tblMensaje]([intIdDestinatario] ASC);

