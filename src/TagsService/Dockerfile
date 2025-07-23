# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["src/TagsService/TagsService.csproj", "src/TagsService/"]
COPY ["src/TagsProtos/TagsProtos.csproj", "src/TagsProtos/"]
RUN dotnet restore "src/TagsService/TagsService.csproj"
COPY . .
WORKDIR "/src/src/TagsService"
RUN dotnet build "TagsService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TagsService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TagsService.dll"]