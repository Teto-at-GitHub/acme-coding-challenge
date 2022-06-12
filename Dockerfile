FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
# WORKDIR /src
COPY ["src/Acme.Api/Acme.Api.csproj", "src/Acme.Api/"]
COPY ["src/Acme.Domain/Acme.Domain.csproj", "src/Acme.Domain/"]
COPY ["src/Acme.Infrastructure/Acme.Infrastructure.csproj", "src/Acme.Infrastructure/"]

RUN dotnet restore "src/Acme.Api/Acme.Api.csproj"
COPY ./src ./src
WORKDIR "/src/Acme.Api"
RUN dotnet publish "Acme.Api.csproj" -c Release --no-restore -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Acme.Api.dll"]
