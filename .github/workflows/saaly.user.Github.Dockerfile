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
COPY ["./RestaurantorCore/RestaurantorCore.Merchants/RestaurantorCore.Merchants.csproj", "RestaurantorCore.Merchants/"]
COPY ["./RestaurantorCore/RestaurantorCore.Merchants/connection.example.json", "RestaurantorCore.Merchants/connection.json"]
COPY ["./RestaurantorCore/RestaurantorCore.Merchants/wwwroot", "RestaurantorCore.Merchants/wwwroot/"]
RUN dotnet restore "RestaurantorCore.Merchants/RestaurantorCore.Merchants.csproj"

COPY ./RestaurantorCore ./
RUN echo $(ls -1 /RestaurantorCore/RestaurantorCore.Merchants)
WORKDIR "/src/RestaurantorCore.Merchants"
RUN dotnet build "RestaurantorCore.Merchants.csproj" -c Release -o /app/build

FROM build AS publish
RUN echo $(ls -1 /app/build)
RUN dotnet publish "RestaurantorCore.Merchants.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantorCore.Merchants.dll"]