## Pre-Requistes
1. Please install SSMS.
2. Please install SQL server express (https://www.microsoft.com/en-in/sql-server/sql-server-downloads)

##Create DB
- To Create a DB, please run the script in the DB Scripts folder.

## Update DB
- Open the StudentManagementSolution
- Open "Package Manager Console" (Tools -> Nuget Package Manager -> Package Manager Console)
- Run "Add-Migration <Some Message>" (Default Project - "StudentManagement.Api")
- Run "update-database" (Default Project - "StudentManagement.Api")

## Run the Solution
- Open the StudentManagementSolution
- Right Click the solution -> Properties -> Multiple StartupProjects.
- Change "Action" of StudentManagement.Api and StudentManagement.Web to "Start".
- Restore nuget packages.
- Clean and Rebuild the solution


## Note
- Please make sure Blazor UI base address and Program.cs in StudentManagement.Api line 28 shoule be same. If not pleae change. 
- Please make sure Swagger Url base address and Program.cs in StudentManagement.Web line 11 shoule be same. If not pleae change. 