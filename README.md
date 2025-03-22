# ASP.NET Core MVC Application - Item Tracker

This is a simple ASP.NET Core MVC application built using .NET 9. The project demonstrates CRUD operations on a model named `Item` using Razor Pages and Entity Framework Core with SQL Server as the database.

## 🛠 Tech Stack

- **.NET SDK:** .NET 9
- **Framework:** ASP.NET Core Web App (Model-View-Controller)
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **View Engine:** Razor Pages

---

## 📁 Project Structure
````
/ItemTracker
│
├── Controllers
│   └── ItemsController.cs         # Handles routing and logic for item operations
│
├── Models
│   └── Item.cs                    # Item model definition
│   
├── Data
│   └── Migrations                  # EF Core Migrations
│   └── MyAppContext.cs             # Database context
├── Views
│   └── Items
│       ├── Index.cshtml           # List of items
│       ├── Create.cshtml          # Add new item
│       ├── Edit.cshtml            # Edit existing item
│       └── Delete.cshtml         # Delete existing item
│
├── appsettings.json               # DB configuration and app settings
├── Program.cs                     # Entry point of the application


````

## ⚙️ Installation and Setup

### 1. Install .NET 9 SDK

Make sure you have the latest .NET 9 SDK installed.

Download from: [https://dotnet.microsoft.com/en-us/download/dotnet/9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

To verify installation:

```bash
dotnet --version
```
### 2. Add Entity Framework Core and SQL Server packages
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
### 3. Set Up SQL Server Using Docker
```bash
docker pull mcr.microsoft.com/azure-sql-edge
```
 Run SQL Server Container and adjust password
```bash
docker run -e "ACCEPT_EULA=1" -e "MSSQL_SA_PASSWORD=reallyStrongPwd123" -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=sql mcr.microsoft.com/azure-sql-edge
```

### 4. Update the Database Connection String
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=ItemDb;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;"
}
```

### 5. Run Entity Framework Migrations
-windows
```bash
Add-Migration "InitialMigration"
Update-Database
```
- On macOS/Linux:
```bash
dotnet ef migrations add InitialMigration
dotnet ef database update
```
