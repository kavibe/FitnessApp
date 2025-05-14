#!/bin/bash

echo "▶️  Сборка проекта..."

dotnet build -f net8.0-ios -p:BuildForSimulator=True
BUILD_STATUS=$?

if [ $BUILD_STATUS -ne 0 ]; then
    echo "Сборка завершилась с ошибкой. Остановка скрипта."
    exit 1
fi

echo "Сборка успешна. Установка на эмулятор..."

xcrun simctl install booted bin/Debug/net8.0-ios/iossimulator-arm64/FitnessApp.app

echo "Запуск приложения..."

xcrun simctl launch booted com.companyname.fitnessapp

echo "Всё готово!"
