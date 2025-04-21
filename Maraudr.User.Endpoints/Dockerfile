FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Maraudr.User.Endpoints/Maraudr.User.Endpoints.csproj", "Maraudr.User.Endpoints/"]
RUN dotnet restore "Maraudr.User.Endpoints/Maraudr.User.Endpoints.csproj"
COPY . .
WORKDIR "/src/Maraudr.User.Endpoints"
RUN dotnet build "Maraudr.User.Endpoints.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Maraudr.User.Endpoints.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Maraudr.User.Endpoints.dll"]
