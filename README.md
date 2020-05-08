# BlueKangrooCoreOnlyAPI
BlueKAngrooAPI

This code requires redis server to be up and running for caching needs.

FROM mcr.microsoft.com/dotnet/core/sdk:3.0
ARG BUILD_CONFIGURATION=Debug
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=http://+:4500
ENV DOTNET_USE_POLLING_FILE_WATCHER=true
EXPOSE 4500

WORKDIR /src
COPY ["BlueKangrooCoreOnlyAPI/BlueKangrooCoreOnlyAPI.csproj", "BlueKangrooCoreOnlyAPI/"]

RUN dotnet restore "BlueKangrooCoreOnlyAPI/BlueKangrooCoreOnlyAPI.csproj"
COPY . .
WORKDIR "/src/BlueKangrooCoreOnlyAPI"
RUN dotnet build --no-restore "BlueKangrooCoreOnlyAPI.csproj" -c $BUILD_CONFIGURATION

RUN echo "exec dotnet run --no-build --no-launch-profile -c $BUILD_CONFIGURATION --" > /entrypoint.sh

ENTRYPOINT ["/bin/bash", "/entrypoint.sh"]
