#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["0.1 - Presentation/GlobalWeb.API/GlobalWeb.API.csproj", "GlobalWeb.API/"]
COPY ["0.2 - Application/GlobalWeb.Application/GlobalWeb.Application.csproj", "GlobalWeb.Application/"]
COPY ["0.3 - Domain/GlobalWeb.Domain/GlobalWeb.Domain.csproj", "GlobalWeb.Domain/"]
COPY ["0.4 - Infra/4.1 - Data/GlobalWeb.Infra.Data/GlobalWeb.Infra.Data.csproj", "GlobalWeb.Data/"]
COPY ["0.4 - Infra/4.2 - Repository/GlobalWeb.Infra.Repository/GlobalWeb.Infra.Repository.csproj", "GlobalWeb.Repository/"]
COPY ["0.4 - Infra/4.3 - CrossCutting/GlobalWeb.Infra.CrossCutting.IoC/GlobalWeb.Infra.CrossCutting.IoC.csproj", "GlobalWeb.CrossCutting/"]
COPY ["0.4 - Infra/4.4 - Middleware/GlobalWeb.Infra.Middleware/GlobalWeb.Infra.Middleware.csproj", "GlobalWeb.Middleware/"]
RUN dotnet restore "GlobalWeb.API/GlobalWeb.API.csproj"
COPY . .
WORKDIR "/src/0.1 - Presentation/GlobalWeb.API"
RUN dotnet build "GlobalWeb.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GlobalWeb.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GlobalWeb.API.dll"]