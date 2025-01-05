<<<<<<< Updated upstream
# Use the official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
=======
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

>>>>>>> Stashed changes
WORKDIR /app

<<<<<<< Updated upstream
# Copy the project files
COPY *.csproj ./
RUN dotnet restore
=======

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS b

WORKDIR /src
COPY . .
RUN dotnet restore "./BlueKangrooCoreOnlyAPI.csproj"
COPY . .
WORKDIR "/src/BlueKangrooCoreOnlyAPI"
RUN dotnet build "BlueKangrooCoreOnlyAPI.csproj" -c Release -o /app/build
>>>>>>> Stashed changes

# Copy the remaining files and publish
COPY . ./
RUN dotnet publish -c Release -o out

# Use the runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port 80
EXPOSE 8080

# Define the entry point for the container
ENTRYPOINT ["dotnet", "BlueKangrooCoreOnlyAPI.dll"]
