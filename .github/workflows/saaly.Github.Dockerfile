#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./Saaly/Saaly.Infrastructure/Saaly.Infrastructure.csproj", "Saaly.Infrastructure/"]
COPY ["./Saaly/Saaly.Infrastructure.Extensions/Saaly.Infrastructure.Extensions.csproj", "Saaly.Infrastructure.Extensions/"]
COPY ["./Saaly/Saaly.Services/Saaly.Services.csproj", "Saaly.Services/"]
COPY ["./Saaly/Saaly.Data/Saaly.Data.csproj", "Saaly.Data/"]
COPY ["./Saaly/Saaly.Shared/Saaly.Shared.csproj", "Saaly.Shared/"]
COPY ["./Saaly/Saaly.Models/Saaly.Models.csproj", "Saaly.Models/"]
COPY ["./Saaly/Saaly/connection.example.json", "Saaly/connection.json"]
COPY ["./Saaly/Saaly/Saaly.csproj", "Saaly/"]

RUN dotnet restore "Saaly/Saaly.csproj"
COPY ./Saaly .
WORKDIR "/src/Saaly"
RUN dotnet build "Saaly.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Saaly.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Saaly.dll"]