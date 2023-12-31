FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["./Saaly.Models/Saaly.Models.csproj", "Saaly.Models/"]
COPY ["./Saaly.Data/Saaly.Data.csproj", "Saaly.Data/"]
COPY ["./Saaly.Infrastructure/Saaly.Infrastructure.csproj", "Saaly.Infrastructure/"]
COPY ["./Saaly.Infrastructure.Extensions/Saaly.Infrastructure.Extensions.csproj", "Saaly.Infrastructure.Extensions/"]
COPY ["./Saaly.Services/Saaly.Services.csproj", "Saaly.Services/"]
COPY ["./Saaly.Shared/Saaly.Shared.csproj", "Saaly.Shared/"]
COPY ["./Saaly/connection.example.json", "Saaly/connection.json"]
COPY ["./Saaly/wwwroot", "Saaly/wwwroot/"]
COPY ["./Saaly.Tasks/Saaly.Tasks.csproj", "Saaly.Tasks/"]

RUN dotnet restore "Saaly.Tasks/Saaly.Tasks.csproj"
COPY ./ ./
WORKDIR "/src/Saaly.Tasks"
RUN dotnet build "Saaly.Tasks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Saaly.Tasks.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Saaly.Tasks.dll"]