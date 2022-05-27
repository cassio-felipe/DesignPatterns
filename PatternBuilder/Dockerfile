FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PatternBuilder/PatternBuilder.csproj", "PatternBuilder/"]
RUN dotnet restore "PatternBuilder/PatternBuilder.csproj"
COPY . .
WORKDIR "/src/PatternBuilder"
RUN dotnet build "PatternBuilder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PatternBuilder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PatternBuilder.dll"]
