FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["../../Desktop/Leetcode/Leetcode-Using-CSharp/Arrays/Arrays.csproj", "../../Desktop/Leetcode/Leetcode-Using-CSharp/Arrays/"]
RUN dotnet restore "../../Desktop/Leetcode/Leetcode-Using-CSharp/Arrays/Arrays.csproj"
COPY . .
WORKDIR "/src/../../Desktop/Leetcode/Leetcode-Using-CSharp/Arrays"
RUN dotnet build "./Arrays.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Arrays.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Arrays.dll"]
