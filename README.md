# QuantumWeb

Ласкаво просимо до нашого прикладу додатка Blazor, який дозволяє створювати, редагувати та видаляти записи в блокноті. Цей додаток розроблено з використанням ASP.NET Core і Blazor.

Технології та інструменти

ASP.NET Core
Blazor
Entity Framework Core
PostgreSQL (як база даних)
MediatR (для обробки запитів та команд)
AutoMapper (для маппінгу між сутностями і DTO)
Встановлення та запуск

Склонуйте цей репозиторій на свій комп'ютер.
Переконайтеся, що ви маєте встановлений .NET Core SDK.
Створіть базу даних PostgreSQL і налаштуйте рядок підключення в файлі appsettings.json.
Відкрийте проект у вашій IDE (наприклад, Visual Studio або Visual Studio Code).
Запустіть додаток.
Основні функції

Створення нових записів із зазначенням заголовка та деталей.
Редагування існуючих записів.
Видалення записів з блокнота.
Відображення списку всіх записів у блокноті.
Структура проекту

Notes.Application: Код додатка, включаючи запити, команди та маппінг даних.
Notes.Domain: Визначення сутності Note.
Notes.Persistence: Код доступу до даних, включаючи контекст бази даних та конфігурацію сутності.
Notes.Web: Код для запуску веб-додатка Blazor та налаштування залежностей.
Важливо!

Перш ніж запустити додаток, переконайтеся, що ви створили базу даних PostgreSQL та налашили рядок підключення в файлі appsettings.json. Ви також можете налаштувати інші параметри додатка, такі як порт, на якому він буде запущено.

Автори

German Gritsenko