-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE dbo.CreateTodo
	-- Add the parameters for the stored procedure here
	@TITLE		NVARCHAR(100),
	@ISDONE		BIT
AS
BEGIN
	INSERT INTO dbo.Todos (TITLE, ISDONE)
	VALUES (@TITLE, @ISDONE);
END
GO
