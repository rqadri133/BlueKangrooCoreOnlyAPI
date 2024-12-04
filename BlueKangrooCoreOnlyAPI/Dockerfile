# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file(s) and restore dependencies
COPY BlueKangrooCoreOnlyAPI/*.csproj ./BlueKangrooCoreOnlyAPI/
RUN dotnet restore BlueKangrooCoreOnlyAPI/BlueKangrooCoreOnlyAPI.csproj

# Copy the remaining source code and build the project
COPY BlueKangrooCoreOnlyAPI/ ./BlueKangrooCoreOnlyAPI/
WORKDIR /src/BlueKangrooCoreOnlyAPI
RUN dotnet publish -c Release -o /app --no-restore

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy the build artifacts from the first stage
COPY --from=build /app .

# Expose the port (optional, customize as needed)
EXPOSE 5000
EXPOSE 5001

# Specify the entry point for the application
ENTRYPOINT ["dotnet", "BlueKangrooCoreOnlyAPI.dll"]
