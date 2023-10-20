FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /razor_pizza

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /razor_pizza
COPY --from=build-env /razor_pizza/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "razor_pizza.dll"]