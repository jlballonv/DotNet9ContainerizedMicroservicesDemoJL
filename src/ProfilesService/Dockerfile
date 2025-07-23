# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/ProfilesService/ProfilesService.csproj", "src/ProfilesService/"]
RUN dotnet restore "src/ProfilesService/ProfilesService.csproj"
COPY . .
WORKDIR "/src/src/ProfilesService"
RUN dotnet build "ProfilesService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProfilesService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProfilesService.dll"]