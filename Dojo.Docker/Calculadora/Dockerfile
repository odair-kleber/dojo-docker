FROM dojo-docker-soma as soma-env
FROM dojo-docker-subtracao as subtracao-env

FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY --from=soma-env /app ./
COPY --from=subtracao-env /app ./