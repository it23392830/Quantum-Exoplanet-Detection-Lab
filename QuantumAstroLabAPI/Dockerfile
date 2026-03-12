FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY QuantumAstroLabAPI/QuantumAstroLabAPI.csproj QuantumAstroLabAPI/
RUN dotnet restore QuantumAstroLabAPI/QuantumAstroLabAPI.csproj

COPY . .
WORKDIR /src/QuantumAstroLabAPI
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080

ENTRYPOINT ["dotnet", "QuantumAstroLabAPI.dll"]