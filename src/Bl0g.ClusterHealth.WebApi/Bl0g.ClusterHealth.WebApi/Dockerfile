FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Bl0g.ClusterHealth.WebApi.csproj", "Bl0g.ClusterHealth.WebApi/"]
RUN dotnet restore "Bl0g.ClusterHealth.WebApi/Bl0g.ClusterHealth.WebApi.csproj"
COPY . .
WORKDIR "/src/Bl0g.ClusterHealth.WebApi"
RUN dotnet build "Bl0g.ClusterHealth.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Bl0g.ClusterHealth.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Bl0g.ClusterHealth.WebApi.dll"]