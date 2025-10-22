
## 📂 Project Structure

```

dotnetLearn/
│
├── src/
│   ├── Api/                 # Presentation layer (Controllers, Startup, Swagger)
│   ├── Application/         # Business logic layer (Use Cases, DTOs, Interfaces)
│   ├── Domain/              # Core domain entities and abstractions
│   └── Infrastructure/      # Data access, EF Core, external services
│
├── dotnetLearn.sln          # Solution file
└── README.md

````

---

## 🚀 Getting Started

### 🧭 Prerequisites
Make sure you have:
- [.NET SDK 8+](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- Git

Verify installations:
```bash
dotnet --version
psql --version
````

---

### ⚙️ 1. Clone the Repository

```bash
git clone https://github.com/<yourusername>/dotnetLearn.git
cd dotnetLearn
```

---

### 📦 2. Restore Dependencies

```bash
dotnet restore
```

---

### 🛠️ 3. Configure Database Connection

Edit `src/Api/appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=dotnet_learn;Username=postgres;Password=postgres"
}
```

Create the database (if needed):

```bash
psql -U postgres -c "CREATE DATABASE dotnet_learn;"
```

---

### 🧩 4. Run Migrations

If you haven’t created migrations yet:

```bash
dotnet ef migrations add InitialCreate --project src/Infrastructure --startup-project src/Api
```

Then apply them:

```bash
dotnet ef database update --project src/Infrastructure --startup-project src/Api
```

> 📝 Make sure `Microsoft.EntityFrameworkCore.Design` is installed in `src/Api`.

---

### 🚀 5. Run the API

Start the API:

```bash
dotnet run --project src/Api
```

Output:

```
Now listening on: http://localhost:5233
Application started. Press Ctrl+C to shut down.
```

Access Swagger UI:
👉 [http://localhost:5233/swagger](http://localhost:5233/swagger)

---

## 🧱 Architecture Overview

| Layer              | Description                                                                   |
| ------------------ | ----------------------------------------------------------------------------- |
| **Domain**         | Core business entities and rules. No external dependencies.                   |
| **Application**    | Use cases and interfaces. Orchestrates business logic.                        |
| **Infrastructure** | Data persistence (EF Core), repositories, external APIs.                      |
| **Api**            | Entry point for HTTP requests. Uses Dependency Injection to resolve services. |

---

## 🧰 Common Commands

| Action           | Command                                                                                  |
| ---------------- | ---------------------------------------------------------------------------------------- |
| Add a migration  | `dotnet ef migrations add <Name> --project src/Infrastructure --startup-project src/Api` |
| Update database  | `dotnet ef database update --project src/Infrastructure --startup-project src/Api`       |
| Run API          | `dotnet run --project src/Api`                                                           |
| Restore packages | `dotnet restore`                                                                         |
| Clean build      | `dotnet clean && dotnet build`                                                           |

---

## 🧾 Setup Script (Optional)

You can automate setup with a script:

**setup.sh**

```bash
#!/bin/bash
echo "🔄 Restoring dependencies..."
dotnet restore

echo "⚙️  Running database migrations..."
dotnet ef database update --project src/Infrastructure --startup-project src/Api

echo "🚀 Starting API..."
dotnet run --project src/Api
```

Make it executable:

```bash
chmod +x setup.sh
./setup.sh
```

---

## 🧩 Contributing

1. Fork this repository
2. Create a new branch (`git checkout -b feature/my-feature`)
3. Commit changes (`git commit -m "Add my feature"`)
4. Push and open a PR

---

## 🧠 Notes

* Default port: **5233**
* Swagger UI enabled in **Development** mode
* Database: **PostgreSQL**
* ORM: **Entity Framework Core**
* Architecture: **Clean Architecture + Dependency Injection**

---

## 🧑‍💻 Author

**Your Name**
📧 [[muhammadasmann@gmail.com](mailto:uhammadasmann@gmail.com)]
🌐 [MuhAsmann.github.io]

---

```