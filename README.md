# 🎟️ TicketSystem

**TicketSystem** is a backend application for managing support tickets, designed with **Clean Architecture** principles to ensure clarity, maintainability, and scalability.  
The project follows the **CQRS** (Command Query Responsibility Segregation) pattern, separating commands from queries to simplify development and long-term maintenance.

---

## 🚀 Architecture

The solution is organized into four main layers:

- **Core**  
  Contains domain entities, interfaces, and business logic. Independent from frameworks and external dependencies.

- **Application**  
  Implements the **CQRS** pattern with commands and queries. Holds **DTOs** and application-specific logic.

- **Infrastructure**  
  Handles database access using **Entity Framework Core** combined with the **Repository Pattern**. Implements interfaces defined in the Core layer.

- **API**  
  Exposes system functionality through REST controllers, enabling communication with clients.

---

## 🛠️ Technologies
<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg" alt=".NET Logo" width="60"/>
  <img src="https://www.docker.com/wp-content/uploads/2022/03/Moby-logo.png" alt="Docker Logo" width="60"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/f/ff/Windows_Azure_logo.png" alt="Azure DevOps Logo" width="110"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/2/29/Postgresql_elephant.svg" alt="PostgreSQL Logo" width="60"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/3/35/Tux.svg" alt="Linux Logo" width="60"/>
  <img src="https://upload.wikimedia.org/wikipedia/commons/9/9a/Visual_Studio_Code_1.35_icon.svg" alt="VS Code Logo" width="60"/>
</p>




- .NET (C#)  
- **Entity Framework Core** – ORM for database operations  
- **PostgreSQL** – relational database running on Docker  
- **Docker** – containerized database deployment  
- **CQRS** – separation of read and write logic  
- **Repository Pattern** – abstracted data access  
- **DTOs** – structured data transfer between layers  
- **Azure DevOps Pipelines** – CI/CD, monitoring, and automated deployments  
- **Ubuntu** – Linux operating system
- **Visual Studio Code** – Lightweight code editor

---

## 📂 Project Structure

```
TicketSystem/
│
├── src/
│   ├── TicketSystem.Core/           # Domain layer
│   ├── TicketSystem.Application/    # CQRS, DTOs
│   ├── TicketSystem.Infrastructure/ # EF Core, repositories
│   └── TicketSystem.API/            # Controllers, REST API
│
├── tests/
│   └── TicketSystem.Tests/          # Unit and integration tests
│
└── azure-pipelines.yml              # CI/CD pipeline configuration
│
└── Docker-compose.yml              # Docker PostgreSQL contenerization

```

---

## ⚙️ Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/YourAccount/TicketSystem.git
   cd TicketSystem
   ```

2. **Apply database migrations**
   ```bash
   dotnet ef database update --project src/TicketSystem.Infrastructure
   ```

3. **Run the API**
   ```bash
   dotnet run --project src/TicketSystem.API
   ```