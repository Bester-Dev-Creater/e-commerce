Add new migration:
	dotnet ef migrations add <MigrationName> -s Shopping.Pal.API -p Shopping.Pal.Data -c DataContext
	
Update database:
	dotnet ef database update -s Shopping.Pal.API -p Shopping.Pal.Data -c DataContext
	
Downgrade database:
	dotnet ef database update <PreviousMigrationName> -s Shopping.Pal.API -p Shopping.Pal.Data -c DataContext
	
Remove most recent migration:
	dotnet ef migrations remove -s Shopping.Pal.API -p Shopping.Pal.Data -c DataContext	