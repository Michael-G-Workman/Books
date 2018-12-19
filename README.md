BOOKS

Example ASP.NET MVC 5 Web Application with Entity Framework

By Michael G. Workman

This example application is a standard ASP.NET MVC 5 Web Application with database first Entity Framework ORM,
it is a bit different than normal in that it uses a GUID for the primary key in the db tables and EF models instead
of an INT with IDENTITY. GUID is truly a unique value primary key that will never be duplicated.

Before running this solution, use the BOOKS_Create.sql TSQL script in the SQL SERVER repo to create
the AuthorsDB sql server database used by this solution.

This solution works with LocalDB sql server, but changing the BooksContext connection string in Web.Config
file will enable you to use it with any other sql server database.

This solution is freely distributable under the terms of the MIT open source license
