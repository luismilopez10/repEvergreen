CREATE TABLE [dbo].[tblDestinatario] (
    [intIdDestinatario] INT            IDENTITY (1, 1) NOT NULL,
    [strNombre]         NVARCHAR (MAX) NULL,
    [strEmail]          NVARCHAR (MAX) NULL,
    [strTelefono]       NVARCHAR (MAX) NULL,
    [blnActivo]         BIT            DEFAULT ((1)) NULL,
    [dtmActualiza]      DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblDestinatario] PRIMARY KEY CLUSTERED ([intIdDestinatario] ASC)
);




GO


