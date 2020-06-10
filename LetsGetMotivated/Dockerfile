#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["LetsGetMotivated.csproj", "LetsGetMotivated/"]
RUN dotnet restore "LetsGetMotivated/LetsGetMotivated.csproj"
WORKDIR "/src/LetsGetMotivated"
COPY . .
RUN dotnet build "LetsGetMotivated.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LetsGetMotivated.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet LetsGetMotivated.dll

### NuGet restore
##FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
##WORKDIR /src
##COPY *.sln .
##COPY LetsGetMotivated.Test/*.csproj LetsGetMotivated.Test/
##COPY LetsGetMotivated.LetsGetMotivated/*.csproj LetsGetMotivated.LetsGetMotivated/
##RUN dotnet restore
##COPY . .
##
### testing
##FROM build AS testing
##WORKDIR /src/LetsGetMotivated
##RUN dotnet build
##WORKDIR /src/LetsGetMotivated.Test
##RUN dotnet test
##
### publish
##FROM build AS publish
##WORKDIR /src/LetsGetMotivated
##RUN dotnet publish -c Release -o /src/publish
##
##FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
##WORKDIR /app
##COPY --from=publish /src/publish .
### ENTRYPOINT ["dotnet", "Colors.API.dll"]
### heroku uses the following
##CMD ASPNETCORE_URLS=http://*:$PORT dotnet LetsGetMotivated.dll
#
## #See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
 #FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
 #WORKDIR /app
 ##EXPOSE 80
 ##EXPOSE 443
#
 #FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
 #WORKDIR /src
 #COPY ["LetsGetMotivated/LetsGetMotivated.csproj", "LetsGetMotivated/"]
 #RUN dotnet restore "LetsGetMotivated/LetsGetMotivated.csproj"
 #COPY . .
 #WORKDIR "/src/LetsGetMotivated"
 #RUN dotnet build "LetsGetMotivated.csproj" -c Release -o /app/build
#
 #FROM build AS publish
 #RUN dotnet publish "LetsGetMotivated.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet LetsGetMotivated.dll