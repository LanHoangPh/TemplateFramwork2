FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TemplateFramework.API/TemplateFramework.API.csproj", "TemplateFramework.API/"]
COPY ["TemplateFramework.Infastructure/TemplateFramework.Infastructure.csproj", "TemplateFramework.Infastructure/"]
COPY ["TemplateFramework.Application/TemplateFramework.Application.csproj", "TemplateFramework.Application/"]
COPY ["TemplateFramework.Domain/TemplateFramework.Domain.csproj", "TemplateFramework.Domain/"]
RUN dotnet restore "./TemplateFramework.API/TemplateFramework.API.csproj"
COPY . .
WORKDIR "/src/TemplateFramework.API"
RUN dotnet build "./TemplateFramework.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TemplateFramework.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TemplateFramework.API.dll"]