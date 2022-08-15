#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Scaffold.API/Scaffold.API.csproj", "Scaffold.API/"]
COPY ["Scaffold.API.Client/Scaffold.API.Client.csproj", "Scaffold.API.Client/"]
RUN dotnet restore "Scaffold.API/Scaffold.API.csproj"
COPY . .
WORKDIR "/src/Scaffold.API"
RUN dotnet build "Scaffold.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Scaffold.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Scaffold.API.dll"]