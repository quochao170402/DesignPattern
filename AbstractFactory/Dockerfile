FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AbstractFactory/AbstractFactory.csproj", "AbstractFactory/"]
RUN dotnet restore "AbstractFactory/AbstractFactory.csproj"
COPY . .
WORKDIR "/src/AbstractFactory"
RUN dotnet build "AbstractFactory.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AbstractFactory.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AbstractFactory.dll"]
