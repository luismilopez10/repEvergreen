CREATE TABLE [dbo].[tblCanal] (
    [intIdCanal]   INT            IDENTITY (1, 1) NOT NULL,
    [strTipoCanal] NVARCHAR (MAX) NULL,
    [dtmFecha]     DATETIME       DEFAULT (getdate()) NULL,
    [blnActivo]    BIT            DEFAULT ((1)) NULL,
    [dtmActualiza] DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblCanal] PRIMARY KEY CLUSTERED ([intIdCanal] ASC)
);







