# Gym Management Project

Aplicație desktop pentru gestionarea unei săli de fitness, realizată în C# (Windows Forms) pentru cursul de PAW. Permite înregistrarea membrilor și a abonamentelor și urmărirea intrărilor și ieșirilor din sală.

## Funcționalități

- **Membri:** adăugare membru nou (cu validare de nume, e-mail și telefon) și vizualizarea listei de membri
- **Abonamente:** înregistrare abonament pentru un membru nou sau existent, tipuri Starter, Basic și Premium, cu preț calculat automat; un membru nu poate avea două abonamente active în același timp
- **Check-in / Check-out:** accesul este permis doar dacă membrul are un abonament activ; se verifică și dacă membrul este deja în sală
- **Log sală:** istoricul intrărilor și ieșirilor
- **Persoane în sală:** numărul de persoane aflate în sală în acest moment
- **Ștergere abonament**

## Tehnologii

- C# / .NET Framework 4.7.2
- Windows Forms
- Entity Framework Core 3.1 (Code First, cu migrări)
- SQL Server LocalDB

## Structura proiectului

```
dataModels/   Entitățile (Membru, Abonament, Antrenor, Rezervari, LogSala) și enum-urile
data/         AppDbContext (contextul Entity Framework)
services/     Logica de business (LogSalaService)
forms/        Interfața: MainForm, AdaugaAbonament, CheckInCheckOut
Migrations/   Migrările bazei de date
```

## Rulare

Cerințe: Windows, Visual Studio cu suportul pentru .NET desktop și SQL Server LocalDB.

1. Clonează repository-ul și deschide `Proiect Sala de Fitness.sln` în Visual Studio.
2. Restaurează pachetele NuGet (se face automat la build).
3. Creează baza de date. În **Package Manager Console** rulează:
   ```
   Update-Database
   ```
   Baza de date `DBFitness` se creează pe `(localdb)\MSSQLLocalDB`.
4. Rulează aplicația cu **F5**.

Dacă folosești alt server SQL, modifică șirul de conexiune din `data/AppDBContext.cs`.

## Autor

Cristea Mihai, Facultatea de Cibernetică, Statistică și Informatică Economică, ASE București
