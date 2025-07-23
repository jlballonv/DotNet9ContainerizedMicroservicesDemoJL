# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/ArticlesService/ArticlesService.csproj", "src/ArticlesService/"]
COPY ["src/ArticlesProtos/ArticlesProtos.csproj", "src/ArticlesProtos/"]
RUN dotnet restore "src/ArticlesService/ArticlesService.csproj"
COPY . .
WORKDIR "/src/src/ArticlesService"
RUN dotnet build "ArticlesService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ArticlesService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ArticlesService.dll"]