# Configure Dapper with ASP.ENT MVC5

# What's Dapper?

Dapper is an object-relational mapping (ORM) for the .NET platform. It provides a framework for mapping an object-oriented domain model to a traditional relational database.

# What are the features of dapper?

•	Speedy and high performance
•	Choice of static/dynamic object binding
•	Easy handling of SQL query
•	Multiple query support
•	Support and easy handling of stored procedures
•	Operating directly on IDbConnection interface
•	Bulk data insert functionality

# How Dapper Works?

It is a three-step process.
•	Create an IDbConnection object.
•	Write a query to perform CRUD operations.
•	Pass query as a parameter in the Execute method.

# How to Install Dapper?

To install Dapper using Visual Studio, you can follow these steps:

Step 1
Create an ASP.NET MVC Web Application project.

Step 2
Install Dapper through NuGet by executing the following command in Package Manager Console.

PM> Install-Package Dapper
