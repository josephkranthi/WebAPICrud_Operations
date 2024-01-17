Teacher Project:-
To Perform CRUD (Create, Read, Update, Delete) operation by using WEB API UI/postman to manage teacher details in Sql Server Database. 

Tech Stacks: C#, .NET WEB API, .NET MVC, Entity Framework, SQL Server, Html, bootstrap, Javascript, jquery, ajax

Database Setup:- The project uses a SQL Server database to store contact information. 
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

API Endpoints:-
The following API endpoints are available:

GET /api/values: Returns a list of all Teachers.
GET /api/values/{TeacherId}: Returns a single Teacher by ID.
POST /api/values/{Firstname}&{Lastname}: Creates a new Teacher.
PUT /api/values/{TeacherId}&{Firstname}&{Lastname}: Updates an existing Teacher.
DELETE /api/values/{TeacherId}: Deletes a Teacher by ID.

How to Run the Project:-
To run the project, follow these steps:

Clone the project to your local machine.
Open the project in Visual Studio 2019 or later.
Ensure that you have SQl Server installed and running on your machine.
Open the web.config file and update the connection string to point to your Sql Server instance.
Run the project. The API will be hosted on http://localhost:44315.
