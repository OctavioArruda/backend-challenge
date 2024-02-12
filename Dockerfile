# Use the official Microsoft .NET Core SDK image to restore and build the project
FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /src
# Copy the solution file and all the csproj files individually to restore dependencies
COPY ["BackendChallenge.sln", "./"]
COPY ["API/API.csproj", "./API/"]
COPY ["Domain/Domain.csproj", "./Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "./Infrastructure/"]
COPY ["Application/Application.csproj", "./Application/"]
# Restore the dependencies for the entire solution
RUN dotnet restore "BackendChallenge.sln"
# Copy the rest of the source code
COPY . .
# Build the entire solution
RUN dotnet build "BackendChallenge.sln" -c Release -o /app/build

# Publish the API project
FROM build AS publish
RUN dotnet publish "API/API.csproj" -c Release -o /app/publish

# Use the official Microsoft .NET Core runtime as a parent image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:latest AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "API.dll"]
