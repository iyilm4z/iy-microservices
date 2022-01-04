#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/apps/Iy.Microservices.Web.Admin/Iy.Microservices.Web.Admin.csproj", "src/apps/Iy.Microservices.Web.Admin/"]
COPY ["src/services/auth/Iy.Microservices.Auth.Shared/Iy.Microservices.Auth.Shared.csproj", "src/services/auth/Iy.Microservices.Auth.Shared/"]
COPY ["src/shared/Iy.Microservices.Core/Iy.Microservices.Core.csproj", "src/shared/Iy.Microservices.Core/"]
COPY ["src/services/forums/Iy.Microservices.Forums.Shared/Iy.Microservices.Forums.Shared.csproj", "src/services/forums/Iy.Microservices.Forums.Shared/"]
COPY ["src/services/news/Iy.Microservices.News.Shared/Iy.Microservices.News.Shared.csproj", "src/services/news/Iy.Microservices.News.Shared/"]
COPY ["src/services/polls/Iy.Microservices.Polls.Shared/Iy.Microservices.Polls.Shared.csproj", "src/services/polls/Iy.Microservices.Polls.Shared/"]
RUN dotnet restore "src/apps/Iy.Microservices.Web.Admin/Iy.Microservices.Web.Admin.csproj"
COPY . .
WORKDIR "/src/src/apps/Iy.Microservices.Web.Admin"
RUN dotnet build "Iy.Microservices.Web.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Iy.Microservices.Web.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Iy.Microservices.Web.Admin.dll"]