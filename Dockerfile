FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY BlueKangrooCoreOnlyAPI.csproj ./
RUN dotnet restore 

# Copy everything else and build
COPY . ./
RUN dotnet publish /app/BlueKangrooCoreOnlyAPI.csproj -c Release -o ./out --nologo

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "BlueKangrooCoreOnlyAPI.dll"]