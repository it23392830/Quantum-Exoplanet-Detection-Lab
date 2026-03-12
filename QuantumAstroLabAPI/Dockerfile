# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file
COPY QuantumAstroLabAPI/QuantumAstroLabAPI.csproj QuantumAstroLabAPI/

# Restore dependencies
RUN dotnet restore QuantumAstroLabAPI/QuantumAstroLabAPI.csproj

# Copy the rest of the code
COPY . .

# Publish project
WORKDIR /src/QuantumAstroLabAPI
RUN dotnet publish -c Release -o /app/publish

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080

EXPOSE 8080

ENTRYPOINT ["dotnet", "QuantumAstroLabAPI.dll"]