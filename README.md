# Database

```sh
# directly change tables to local database and then run this:
# check dotnet ef --version should be 8.x
dotnet ef dbcontext scaffold "Host=localhost;Port=5433;Database=hoton-dev;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL --force -o Entities/generated --context DomainDbContext
# generate migrations
dotnet ef migrations add <MigrationName>
```
