Clean Architecture .NET 8 Microservice

Projects
- Api: ASP.NET Core Web API, CQRS endpoint using MediatR
- Application: CQRS handlers, validation, MediatR setup
- Domain: Entities and base domain abstractions
- Infrastructure: EF Core DbContext and SQL Server wiring

How to run
1) Open CleanArchMicroserviceFull.sln in Visual Studio 2022 or run:
   dotnet restore
   dotnet ef database update (if you add migrations)
   dotnet run --project src/Api/Api.csproj

2) Set ConnectionStrings:DefaultConnection in src/Api/appsettings.json or Azure App Settings.

API endpoints
- POST /api/v1/todo
- GET  /api/v1/todo/{id}
