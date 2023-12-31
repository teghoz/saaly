#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./RestaurantorCore/RestaurantorCore.Enums/RestaurantorCore.Enums.csproj", "RestaurantorCore.Enums/"]
COPY ["./RestaurantorCore/RestaurantorCore.Infrastructure/RestaurantorCore.Infrastructure.csproj", "RestaurantorCore.Infrastructure/"]
COPY ["./RestaurantorCore/RestaurantorCore.Data/RestaurantorCore.Data.csproj", "RestaurantorCore.Data/"]
COPY ["./RestaurantorCore/RestaurantorCore.Shared/RestaurantorCore.Shared.csproj", "RestaurantorCore.Shared/"]
COPY ["./RestaurantorCore/RestaurantorCore.Models/RestaurantorCore.Models.csproj", "RestaurantorCore.Models/"]
COPY ["./RestaurantorCore/RestaurantorCore.API/connection.example.json", "RestaurantorCore.API/connection.json"]
COPY ["./RestaurantorCore/RestaurantorCore.API/RestaurantorCore.API.csproj", "RestaurantorCore.API/"]
RUN dotnet restore "RestaurantorCore.API/RestaurantorCore.API.csproj"
COPY ./RestaurantorCore .
WORKDIR "/src/RestaurantorCore.API"
RUN dotnet build "RestaurantorCore.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantorCore.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantorCore.API.dll"]