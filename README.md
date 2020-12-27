# Running with GitPod
npm -g install dotnet-sdk-3.0 --force
cd InventoryManagement
dotnet restore
dotnet build
dotnet run

After will open a new tab with the running web demo
by Hamilton Kamiya

# Inventory Management ASP.NET Core
This repository contains the inventory management application, built with ASP.NET Core 3.0 and Entity Framework 3.0 to illustrate performing CRUD actions. 

## Prerequisites

* Visual Studio 2019 16.3.0 Preview 2.0
* ASP.NET Core 3.0 Preview 8
* SQL Server 2017 


## How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio 2019.
* Restore the NuGet packages by rebuilding the solution.
* Change the connection string in the appsettings.json file that points to your SQL Server
* Run the project.
