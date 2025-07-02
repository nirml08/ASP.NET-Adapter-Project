# ASP.NET Adapter Project

This is a modular ASP.NET Core Web API project designed to act as an adapter between your backend services and frontend applications. It implements clean architectural principles using Controllers, Repositories, Services, and Models to manage data and logic flow efficiently.

---

## 🚀 Features

- ✅ Clean separation of concerns using `IRepo`, `IServices`, and concrete implementations
- ✅ Environment-based configuration via `appsettings.json`
- ✅ Organized folder structure for maintainability
- ✅ Scalable and testable design
- ✅ Supports MySQL (or SQL Server) via `ConnectionStrings`

---

## 📁 Project Structure

adapter/
├── Controllers/ # API Controllers <br>
├── Services/ # Business logic <br>
│ └── ApicalServices/ # (Optional) Internal service logic <br>
├── Repo/ # Data access layer <br>
├── IRepo/ # Interfaces for Repositories <br>
├── IServices/ # Interfaces for Services <br>
├── Model/ # Data models / DTOs <br>
├── Dbpool/ # Database pooling/config (if used) <br>
├── appsettings.json # Config file (excluded in repo) <br>
├── Program.cs # Entry point <br>
├── adapter.csproj # Project definition <br>
└── README.md # You're reading it <br>
