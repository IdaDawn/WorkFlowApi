FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 53387
EXPOSE 44310

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WorkFlowApi/WorkFlowApi.csproj", "WorkFlowApi/"]
RUN dotnet restore "WorkFlowApi/WorkFlowApi.csproj"
COPY . .
WORKDIR "/src/WorkFlowApi"
RUN dotnet build "WorkFlowApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WorkFlowApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WorkFlowApi.dll"]