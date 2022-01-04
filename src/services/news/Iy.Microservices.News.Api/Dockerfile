#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/news/Iy.Microservices.News.Api/Iy.Microservices.News.Api.csproj", "src/services/news/Iy.Microservices.News.Api/"]
COPY ["src/shared/Iy.Microservices.EntityFrameworkCore/Iy.Microservices.EntityFrameworkCore.csproj", "src/shared/Iy.Microservices.EntityFrameworkCore/"]
COPY ["src/shared/Iy.Microservices.Core/Iy.Microservices.Core.csproj", "src/shared/Iy.Microservices.Core/"]
RUN dotnet restore "src/services/news/Iy.Microservices.News.Api/Iy.Microservices.News.Api.csproj"
COPY . .
WORKDIR "/src/src/services/news/Iy.Microservices.News.Api"
RUN dotnet build "Iy.Microservices.News.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iy.Microservices.News.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iy.Microservices.News.Api.dll"]