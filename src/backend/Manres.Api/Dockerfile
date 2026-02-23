FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY src/backend/Manres.Api ./src/backend/Manres.Api
COPY sql ./sql
RUN dotnet publish ./src/backend/Manres.Api/Manres.Api.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
COPY sql /sql
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "Manres.Api.dll"]
