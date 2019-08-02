FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["FoodStorage_Backend.csproj", ""]
RUN dotnet restore "FoodStorage_Backend.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "FoodStorage_Backend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FoodStorage_Backend.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FoodStorage_Backend.dll"]