FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DroneMagnus/DroneMagnus.csproj", "DroneMagnus/"]
RUN dotnet restore "DroneMagnus/DroneMagnus.csproj"
COPY . .
WORKDIR "/src/DroneMagnus"
RUN dotnet build "DroneMagnus.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DroneMagnus.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DroneMagnus.dll"]
