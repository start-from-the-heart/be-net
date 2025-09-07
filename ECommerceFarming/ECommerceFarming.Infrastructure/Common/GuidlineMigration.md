` Set up net core
dotnet tool update --global dotnet-ef


` Add Migration

dotnet ef migrations add <MigrationName> --project ECommerceFarming.Infrastructure --startup-project ECommerceFarming

` Update Migration

dotnet ef database update --project ECommerceFarming.Infrastructure --startup-project ECommerceFarming

` Remove Migration

dotnet ef migrations remove --project ECommerceFarming.Infrastructure --startup-project ECommerceFarming

