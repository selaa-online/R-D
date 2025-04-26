# Project Title: Test MCP Repository

## Overview
This repository contains a .NET 8 Clean Architecture Web API project structured into multiple layers: WebApi, Application, Domain, Infrastructure, and SharedKernel. Each layer has its own responsibilities, promoting separation of concerns and maintainability.

## Project Structure
- **src**
  - **WebApi**: Contains the API controllers and entry point for the application.
  - **Application**: Contains business logic and service interfaces.
  - **Domain**: Contains domain entities and value objects.
  - **Infrastructure**: Contains data access implementations and database context.
  - **SharedKernel**: Contains common interfaces and base classes used across the application.

- **tests**
  - **WebApi.Tests**: Unit tests for the WebApi project.
  - **Application.Tests**: Unit tests for the Application project.
  - **Domain.Tests**: Unit tests for the Domain project.
  - **Infrastructure.Tests**: Unit tests for the Infrastructure project.
  - **SharedKernel.Tests**: Unit tests for the SharedKernel project.

## Getting Started

### Prerequisites
- .NET 8 SDK
- A code editor (e.g., Visual Studio Code)

### Setup
1. Clone the repository:
   ```
   git clone https://github.com/selaa-online/test-mcp-repo.git
   ```
2. Navigate to the project directory:
   ```
   cd test-mcp-repo
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```
4. Run the application:
   ```
   dotnet run --project src/WebApi/WebApi.csproj
   ```

### Running Tests
To run the tests for all projects, use the following command:
```
dotnet test
```

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.