# Project Review

## What the Project Demonstrates

The application demonstrates a complete small desktop CRUD workflow. It uses Windows Forms for the user interface, Entity Framework 6 for data access, validation before database writes, and a one-to-many relationship between flights and passengers.

## Repository Repairs

The uploaded project referenced several files that were not included in the upload. The repository was completed with:

- `Program.cs`, which starts the Windows Forms application.
- `Models/Flight.cs` and `Models/Passenger.cs`, based on the properties used by the existing forms.
- `ViewPassengersByFlightForm`, because the main form already linked to this missing screen.
- `Properties/AssemblyInfo.cs`, which supplies the standard assembly metadata.
- A database initializer that creates the LocalDB database when it does not exist.

Broken project references to unavailable migration and generated settings/resource files were removed. Existing form logic and designer files were preserved.

## Current Architecture

```text
Windows Forms UI
       |
ApplicationDbContext (Entity Framework 6)
       |
SQL Server Express LocalDB
```

Each form currently creates its own short-lived `ApplicationDbContext`. This is appropriate for a small classroom project because each operation opens, uses, and disposes its own context.

## Recommended Next Steps

1. Add unit tests for validation rules.
2. Move database queries from forms into service classes.
3. Add unique checks for flight numbers and passport numbers.
4. Store passport numbers as strings if letters or leading zeros must be supported.
5. Add explicit Entity Framework migrations before changing the database schema in future versions.

## Validation Note

The repository structure and project references were checked for completeness. A Windows/.NET Framework environment is still required for the final Visual Studio build and LocalDB runtime test.
