FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source


COPY nuget.config /
COPY . .

RUN dotnet restore --disable-parallel

WORKDIR /source/TrainingManager
RUN dotnet publish --no-restore -c Release -o /app
RUN mkdir --parents ~/.postgresql && wget "https://storage.yandexcloud.net/cloud-certs/CA.pem" --output-document ~/.postgresql/postgresql.crt && chmod 0600 ~/.postgresql/postgresql.crt


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "TrainingManager.dll"]