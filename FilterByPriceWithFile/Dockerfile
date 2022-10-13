FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FilterByPriceWithFile/FilterByPriceWithFile.csproj", "FilterByPriceWithFile/"]
RUN dotnet restore "FilterByPriceWithFile/FilterByPriceWithFile.csproj"
COPY . .
WORKDIR "/src/FilterByPriceWithFile"
RUN dotnet build "FilterByPriceWithFile.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FilterByPriceWithFile.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FilterByPriceWithFile.dll"]
