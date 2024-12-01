#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:8.0- AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:8.0 AS build
WORKDIR /src
COPY ["BlueKangrooCoreOnlyAPI.csproj", "BlueKangrooCoreOnlyAPI/"]
RUN dotnet restore "BlueKangrooCoreOnlyAPI/BlueKangrooCoreOnlyAPI.csproj"
COPY . .
WORKDIR "/src/BlueKangrooCoreOnlyAPI"
RUN dotnet build "BlueKangrooCoreOnlyAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlueKangrooCoreOnlyAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlueKangrooCoreOnlyAPI.dll"]