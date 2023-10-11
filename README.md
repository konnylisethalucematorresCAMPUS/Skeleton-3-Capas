# Skeleton-3-Capas


# Pasos
 - Entidades
 - Configuraciones 
 - Interfaces 
 - IUnitOfWork
 - Repositorio
 - UnitOfWork
 - Dtos 
 - Controllers Base
 - MetodosInterfaces 
 - MetodosRepositorios
 - MetodoControllers
 


## Migraciones
dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations/

dotnet ef database update --project ./Infrastructure/ --startup-project ./API/  



#