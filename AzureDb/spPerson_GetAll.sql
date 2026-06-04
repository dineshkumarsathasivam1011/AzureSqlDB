CREATE PROCEDURE [dbo].[spPerson_GetAll]
	As
	BEGIN
	SELECT [Id], [FirstName], [LastName] FROM [dbo].[Person]
	END

