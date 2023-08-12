#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./services/NSE.Pedido.API/NSE.Pedidos.API.csproj", "services/NSE.Pedido.API/"]
COPY ["./building blocks/NSE.Core/NSE.Core.csproj", "building blocks/NSE.WebAPI.Core/"]
COPY ["./building blocks/NSE.WebApi.Core/NSE.WebApi.Core.csproj", "building blocks/NSE.WebApi.Core/"]
COPY ["./building blocks/NSE.MessageBus/NSE.MessageBus.csproj", "building blocks/NSE.MessageBus/"]

RUN dotnet restore "services/NSE.Pedido.API/NSE.Pedidos.API.csproj"
COPY . .
WORKDIR "services/NSE.Pedido.API"
RUN dotnet build "NSE.Pedidos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NSE.Pedidos.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NSE.Pedido.API.dll"]