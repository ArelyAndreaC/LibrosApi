FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Solo el nombre del archivo porque el 'Context' ya está en esa carpeta
COPY ["LibrosApi.csproj", "."]
RUN dotnet restore "LibrosApi.csproj"
COPY . .
RUN dotnet publish "LibrosApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LibrosApi.dll"]