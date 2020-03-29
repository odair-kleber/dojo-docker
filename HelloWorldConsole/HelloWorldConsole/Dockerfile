FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY . ./
RUN dotnet publish HelloWorldConsole/HelloWorldConsole.csproj -c Release -o dist


FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY --from=build-env app/dist ./

ENTRYPOINT ["dotnet", "HelloWorldConsole.dll"]