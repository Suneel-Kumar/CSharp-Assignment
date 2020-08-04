CREATE PROCEDURE [dbo].[Procedure]

	@NAME nvarchar(max),
	@DESC nvarchar(max),
	@TYPE nvarchar(max)
AS
	INSERT INTO Info VALUES(@NAME, @DESC, 1, @TYPE)
	RETURN 
