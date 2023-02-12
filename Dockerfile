#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Data Streaming Process API With React.csproj", "."]
RUN dotnet restore "./Data Streaming Process API With React.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Data Streaming Process API With React.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Data Streaming Process API With React.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Data Streaming Process API With React.dll"]