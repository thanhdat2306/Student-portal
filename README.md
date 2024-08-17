# Student Portal API

This project is a simple student portal API that can be thought of as a university system. It is developed using Entity Framework Core and the Code First approach with Microsoft SQL Server database, following modern software architecture principles. The API manages students and courses and uses JWT (JSON Web Token) for user authentication. The project has a layered structure in accordance with the principles of Onion Architecture.

## Project Architecture

The project uses a layered architecture based on Onion Architecture principles to manage dependencies and organize code more effectively. Each layer has a specific responsibility and depends only on layers below it.
### 1. Core Layer

This layer contains the business logic and rules of the application. It consists of two structures:



- **Domain**:
  - Defines the core building blocks (Entities) of the application. For example, the Student and Course entities are located here.
  - Contains business rules and validations.
  - It is independent of databases or other infrastructure technologies.

- **Application**:
  - Contains the use cases and business logic implementation.
  - Performs business operations using the entities and interfaces in the Domain layer.
  - Is independent of database or other infrastructure technologies.
  - Uses the CQRS (Command Query Responsibility Segregation) pattern to separate commands and queries.

### 2. Infrastructure Layer

This layer contains the infrastructure components of the application. It consists of two main structures, with SignalR being introduced in this project:

- **Infrastructure**:
  - Contains common infrastructure components used throughout the application.
  - For example, services for tasks like sending emails or logging can be found here.

- **Persistence**:
  - Manages database access.
  - Uses Entity Framework Core to perform database operations.
  - Abstracts database access using the Repository pattern.
  - Maps the entities in the Domain layer to database tables.

- **SignalR**:
  - Contains SignalR Hubs for real-time communication.
  - For example, when a new announcement is made or a course is updated in the student portal, SignalR can be used to instantly notify all connected users.

### 3. Presentation Layer

This layer contains the user interface and API. It consists of a single structure:


- **API (.NET Web API)**:
  - Serves as the gateway to the application for external users.
  - Handles HTTP requests and processes them by calling the use cases in the Application layer.
  - Uses JWT (JSON Web Token) for user authentication and authorization.

## Authentication and Authorization

The project uses JWT (JSON Web Token) for user authentication and authorization. Users log in with their username and password to receive an Access Token and a Refresh Token.

- **Access Token**: Used to access the API and has a limited validity period.
- **Refresh Token**: Used to obtain a new Access Token when the original Access Token expires and has a longer validity period.

## Project Details

- **Student**
- **Course**
- **AppUser**
- **AppRole**

## Setup and Running

1. **Clone the project::**
   ```bash
   git clone https://github.com/thanhdat2306/Student-portal.git
   
2. **Navigate to the StudentPortal.API directory.**

3. **Configure the database connection in the appsettings.json file.**

4. **Install the packages:**
   ```bash
   dotnet restore
   
5. **Create and migrate the database:**
   ```bash
   dotnet ef database update

6. **Run the project:**
   ```bash
   dotnet run


