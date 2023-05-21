#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ChallengeCoodesh-BACK/ChallengeCoodesh-BACK.csproj", "ChallengeCoodesh-BACK/"]
COPY ["ChallengeCoodesh-BACK.Domain/ChallengeCoodesh-BACK.Domain.csproj", "ChallengeCoodesh-BACK.Domain/"]
COPY ["ChallengeCoodesh-BACK.Application/ChallengeCoodesh-BACK.Application.csproj", "ChallengeCoodesh-BACK.Application/"]
COPY ["ChallengeCoodesh-BACK.Infra/ChallengeCoodesh-BACK.Infra.csproj", "ChallengeCoodesh-BACK.Infra/"]
RUN dotnet restore "ChallengeCoodesh-BACK/ChallengeCoodesh-BACK.csproj"
COPY . .
WORKDIR "/src/ChallengeCoodesh-BACK"
RUN dotnet build "ChallengeCoodesh-BACK.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChallengeCoodesh-BACK.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChallengeCoodesh-BACK.dll"]
