FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API/eShop.API/eShop.API.csproj", "API/eShop.API/"]
RUN dotnet restore "API/eShop.API/eShop.API.csproj"
COPY . .
WORKDIR "/src/API/eShop.API"
RUN dotnet build "eShop.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShop.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.API.dll"]
