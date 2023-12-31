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
COPY ["./RestaurantorCore/RestaurantorCore.Cron/RestaurantorCore.Cron.csproj", "RestaurantorCore.Cron/"]
COPY ["./RestaurantorCore/RestaurantorCore.Cron/connection.example.json", "RestaurantorCore.Cron/connection.json"]
COPY ["./RestaurantorCore/RestaurantorCore.Cron/wwwroot", "RestaurantorCore.Cron/wwwroot/"]
RUN dotnet restore "RestaurantorCore.Cron/RestaurantorCore.Cron.csproj"

COPY ./RestaurantorCore ./
RUN echo $(ls -1 /RestaurantorCore/RestaurantorCore.Cron)
WORKDIR "/src/RestaurantorCore.Cron"
RUN dotnet build "RestaurantorCore.Cron.csproj" -c Release -o /app/build

FROM build AS publish
RUN echo $(ls -1 /app/build)
RUN dotnet publish "RestaurantorCore.Cron.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantorCore.Cron.dll"]