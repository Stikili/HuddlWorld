#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src

COPY *.sln .
COPY ["Huddl/Huddl.csproj", "Huddl/"]
RUN dotnet restore "Huddl/Huddl.csproj"


#COPY . .
COPY Huddl/. ./Huddl/
WORKDIR "/src/Huddl"
RUN dotnet publish "Huddl.csproj" -c Release -o /app/build --no-restore


#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903
#FROM build AS publish
#RUN dotnet publish "Huddl.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "Huddl.dll"]