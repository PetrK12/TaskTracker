#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/TaskService/TaskService.API/TaskService.API.csproj", "Services/TaskService/TaskService.API/"]
COPY ["Services/TaskService/TaskService.Application/TaskService.Application.csproj", "Services/TaskService/TaskService.Application/"]
COPY ["Services/TaskService/TaskService.Domain/TaskService.Domain.csproj", "Services/TaskService/TaskService.Domain/"]
COPY ["Services/TaskService/TaskService.Infrastructure/TaskService.Infrastructure.csproj", "Services/TaskService/TaskService.Infrastructure/"]
RUN dotnet restore "Services/TaskService/TaskService.API/TaskService.API.csproj"
COPY . .
WORKDIR "/src/Services/TaskService/TaskService.API"
RUN dotnet build "TaskService.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TaskService.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TaskService.API.dll"]
