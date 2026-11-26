<h1 align="center">CarAdminApp</h1>
<p align="center">
  <b>Car dealership administration desktop app</b><br/>
  WPF application to manage cars, customers and payments, with a service layer between the UI and the data.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-WPF-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/EF%20Core-data-555?style=flat-square" />
</p>

---

## Features

- **Cars** — add cars (make, model, price) and browse the list.
- **Customers** — manage customer details (name, email, phone).
- **Payments** — register and review payments (amount, date).

## Architecture

```
Windows (XAML) ──▶ Services (AutoService, KlantService, BetalingService) ──▶ ApplicationDbContext
```

## Tech stack

| Layer | Technology |
|---|---|
| UI | WPF |
| Runtime | .NET Framework 4.7.2 |
| Data | Entity Framework |

## Getting started

Open `CarAdminApp.sln` in Visual Studio on Windows and run the project.

---

<p align="center">Built by <a href="https://github.com/oiseaubleuc">Hoho</a> · Belgium</p>
