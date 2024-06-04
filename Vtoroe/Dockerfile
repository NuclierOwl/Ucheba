# Используйте базовый образ SDK для сборки и публикации приложения
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Копируем csproj и восстанавливаем зависимости
COPY *.csproj ./
RUN dotnet restore

# Копируем остальные файлы и собираем приложение
COPY . ./
RUN dotnet publish -c Release -o out

# Используйте базовый образ runtime для запуска приложения
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY --from=build-env /app/out .

# Запускаем приложение
ENTRYPOINT ["dotnet", "Plilozuha.dll"]
