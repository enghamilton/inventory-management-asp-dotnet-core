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

* GitPod.io (web browser such as Chrome, FireFox, Edge, Safari)
* ASP.NET Core 3.0 available CLI Node Package Manager
* PostgreSQL dependecy, already included in .csproj file


## How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio 2019.
* Restore the NuGet packages by rebuilding the solution.
* Change the connection string in the appsettings.json file that points to your SQL Server
* Run the project.

```C#

// appsetting.josn

"ConnectionStrings": {
    "InventoryDatabase": "Host=ec2-107-20-168-237.compute-1.amazonaws.com;Database=d5n07a5mqdt3lh;Username=ivchhoxzrfmfxe;Password=83dd727c514763e78f0874b3008a21ea0da43e93159933c599a89125823ba498;sslmode=Require;Trust Server Certificate=true"
  }

```
Model

```C#

using 

// incompleted yet



```

DBContext

```C#

using 

// incompleted yet



```
ProductController

```C#

using 

// incompleted yet



```
View/Index

```C#

using 

// incompleted yet



```
View/Edit

```C#

using 

// incompleted yet



```
