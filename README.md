# be-net
project be .net

# 📦 Data Migration Guide for [VehicleManagementSystem]

This document explains how to apply, create, and manage database migrations using **Entity Framework Core** in a C# (.NET) project.

---

## 🛠️ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (version 8.0 or higher)

- EF Core CLI (optional, but recommended)

Install EF Core tools (if needed):

```bash
dotnet tool install --global dotnet-ef
```

```add command
dotnet ef migrations add [version] --context[context in use] --project[link project]
```

```remove command
dotnet ef migrations remove --context[context in use] --project[link project]
```

``` update command
dotnet ef database update --context[context in use] --project[link project]
```