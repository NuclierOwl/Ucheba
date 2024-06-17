# Используйте базовый образ SDK для сборки и публикации приложения
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /Vtoroe

# Копируем csproj и восстанавливаем зависимости
COPY *.csproj ./
RUN dotnet restore

# Копируем остальные файлы и собираем приложение
COPY . ./
RUN dotnet publish -c Release -o out

# Используйте базовый образ runtime для запуска приложения
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /Vtoroe
COPY --from=build-env /Vtoroe/out .

# Запускаем приложение
ENTRYPOINT ["dotnet", "Plilozuha.cs"]
