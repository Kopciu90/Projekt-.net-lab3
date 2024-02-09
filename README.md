# eTickets

## O projekcie

eTickets to kompleksowa platforma e-commerce dla kin, umożliwiająca użytkownikom rezerwację biletów online. Aplikacja wspiera zarządzanie treścią przez administratorów, w tym dodawanie, usuwanie i edytowanie informacji o filmach, aktorach i kinach. Użytkownicy mogą przeglądać dostępne filmy, dodawać bilety do koszyka i dokonywać zakupów, korzystając z intuicyjnego interfejsu użytkownika.

## Technologie i Biblioteki

Projekt został zbudowany z wykorzystaniem następujących technologii i pakietów NuGet:

- ASP.NET Core MVC na platformie .NET 6.0
- Entity Framework Core 6.0.26
- Microsoft.AspNetCore.Identity.EntityFrameworkCore 6.0.26
- Microsoft.EntityFrameworkCore.SqlServer 6.0.26
- Microsoft.EntityFrameworkCore.Tools 6.0.26

## Funkcje Aplikacji

- Dodawanie, usuwanie i edytowanie aktorów, kin i filmów
- Prosta obsługa koszyka dla użytkowników

## Dane Przykładowych Użytkowników

Przy uruchomieniu, aplikacja inicjalizuje przykładowe dane użytkowników:

- Administrator: `admin@example.com` (Hasło: `SecurePassword123!`)
- Zwykły użytkownik: `user@example.com` (Hasło: `SecurePassword123!`)

## Uruchomienie Projektu

Aby uruchomić aplikację eTickets, wykonaj następujące kroki:

1. Skonfiguruj połączenie z bazą danych w pliku `appsettings.json`.
2. Użyj Entity Framework Core do zastosowania migracji i utworzenia schematu bazy danych.
3. Uruchom aplikację za pomocą Visual Studio lub polecenia `dotnet run`.

## Inicjalizacja Danych

Klasa `AppDbInitializer` zawiera metody `Seed` i `SeedUsersAndRolesAsync`, które inicjalizują bazę danych przykładowymi danymi dla kin, aktorów, producentów filmów, użytkowników i ról.
