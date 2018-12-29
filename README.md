BOOKS

Example ASP.NET MVC 5 Web Application with Entity Framework

By Michael G. Workman

Azure Cloud Platform Temporary URL: https://books20181226012156.azurewebsites.net/

Permanent URL: http://bookz-and-authorz.net

This example application is a standard ASP.NET MVC 5 Web Application with database first Entity Framework ORM,
it is a bit different than normal in that it uses a GUID for the primary key in the db tables and EF models instead
of an INT with IDENTITY. GUID is truly a unique value primary key that will never be duplicated.

Before running this solution, use the BOOKS_Create.sql TSQL script in the SQL SERVER repo to create
the AuthorsDB sql server database used by this solution.

To create the database on Azure Cloud Platform, first create the database in the Azure portal and run the create script
with the create database statement commented out or removed in AUTHORS_Create.sql TSQL script in SQL Server Repo.
Azure Cloud Platform will not let you create a DB using a SQL Script, it can only be done from the Portal.

This solution works with LocalDB sql server, but changing the BooksContext connection string in Web.Config
file will enable you to use it with any other sql server database. In this repo it has been configured to work with
Azure Cloud Platform SQL Server, after the first version was set to use LocalDB.

This MVC 5 Web Application has been published to the Microsoft Azure Cloud Platform at the following
temporary URL: https://books20181225085249.azurewebsites.net/

This MVC 5 Web Application will be configured to use the domain http://www.bookzandauthorz.net in the future.

This solution is freely distributable under the terms of the MIT open source license
