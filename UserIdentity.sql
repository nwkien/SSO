/* CREATE DATABASE */
CREATE DATABASE UserIdentity
GO

USE [UserIdentity]
GO

/* CREATE Users Table */
CREATE TABLE [dbo].[Users](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[SubjectId] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* INSERT User records */
INSERT INTO Users
(Username, Password, SubjectId)
VALUES
('Test@yahoo.com', 'Test1234', NEWID()),
('User@yahoo.com', 'User1234', NEWID())
GO
