#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Development

EXPOSE 80
EXPOSE 443



FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /app

COPY ["Ecommerce.csproj", "Ecommerce/"]
COPY ["../EcommerceData.csproj", "EcommerceData/"]

RUN dotnet nuget locals all --clear

RUN dotnet restore "./EcommerceData/EcommerceData.csproj"
RUN dotnet restore "./Ecommerce/Ecommerce.csproj"


COPY . .
WORKDIR "/app/Ecommerce"
RUN dotnet build Ecommerce.csproj -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
WORKDIR "/app/Ecommerce"
RUN dotnet publish Ecommerce.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ecommerce.dll"]