#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Dev.Utilities.Guids/Dev.Utilities.Guids.csproj", "Dev.Utilities.Guids/"]
COPY ["Dev.Utilities/Dev.Utilities.csproj", "Dev.Utilities/"]
RUN dotnet restore "Dev.Utilities.Guids/Dev.Utilities.Guids.csproj"
COPY . .
WORKDIR "/src/Dev.Utilities.Guids"
RUN dotnet build "Dev.Utilities.Guids.csproj" -c Release -o /app/build
RUN dotnet test "Dev.Utilities.Guids.csproj"

FROM build AS publish
RUN dotnet publish "Dev.Utilities.Guids.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dev.Utilities.Guids.dll"]