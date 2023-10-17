https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
https://hub.docker.com/_/postgres
https://www.npgsql.org/efcore/
DB first
https://ithelp.ithome.com.tw/articles/10240045
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
```