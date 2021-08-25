#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base

# ENV ASPNETCORE_URLS=http://*:5000
# ENV ASPNETCORE_ENVIRONMENT="development"

WORKDIR /app
# EXPOSE 80
# EXPOSE 443
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["/Petek.BUmatik.API/Petek.BUmatik.API.csproj", "Petek.BUmatik.API/"]
COPY ["/Petek.BUmatik.Business/Petek.BUmatik.Business.csproj", "Petek.BUmatik.Business/"]
COPY ["/Petek.BUmatik.Core/Petek.BUmatik.Core.csproj", "Petek.BUmatik.Core/"]
COPY ["/Petek.BUmatik.DataAccess/Petek.BUmatik.DataAccess.csproj", "Petek.BUmatik.DataAccess/"]
COPY ["/Petek.BUmatik.Entities/Petek.BUmatik.Entities.csproj", "Petek.BUmatik.Entities/"]
COPY ["/Petek.BUmatik.Shared/Petek.BUmatik.Shared.csproj", "Petek.BUmatik.Shared/"]
RUN dotnet restore "Petek.BUmatik.API/Petek.BUmatik.API.csproj"
COPY . .
WORKDIR "/src/Petek.BUmatik.API"
RUN dotnet build "Petek.BUmatik.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Petek.BUmatik.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Petek.BUmatik.API.dll