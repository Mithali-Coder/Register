# Registration Form

A full-stack registration form built with Angular, a .NET Web API and SQL Server.

## Features
- Registration form that saves entries to SQL Server through a REST API
- Fields: full name, address, gender, country, hobbies (cricket, cooking, swimming), email and a photo
- Entity Framework Core with migrations for the database schema

## Tech stack
- Frontend: Angular
- Backend: ASP.NET Core Web API (.NET 8)
- Database: SQL Server (managed with SSMS)

## Project structure
- `register-form/` - Angular frontend
- `RegistrationAPI/` - .NET Web API

## Getting started

### 1. Database and API
1. Copy `RegistrationAPI/appsettings.example.json` to `RegistrationAPI/appsettings.json`.
2. Replace the placeholders in the connection string with your own SQL Server details.
3. From the `RegistrationAPI` folder, create the database and start the API:


