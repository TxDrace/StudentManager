# StudentManager

## Introduction

StudentManager is a Windows Forms application built with .NET 6. It allows administrators to manage students, view grades and maintain related information through a simple graphical interface.

## Running the application

1. Install the [.NET 6 SDK](https://dotnet.microsoft.com/download).
2. Ensure you have a SQL Server instance available. By default the program uses the following connection string in `LogInForm.cs`:
   
   ```
   Data Source=localhost;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;
   ```
   
   Update it if your database server is different.
3. In this `StudentManager` directory run:

   ```bash
   dotnet build
   dotnet run
   ```

   The application will compile and launch.
4. You can also open `StudentManager.sln` in Visual Studio and press **F5** to run it.
