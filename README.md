
# Multi-Tenancy Project

🏢 **Multi-Tenancy Project** 🚀

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

## Overview

The Multi-Tenancy Project is a .NET application that demonstrates the implementation of multi-tenancy using the ASP.NET Core framework. The project allows you to create a multi-tenant application where each tenant has its own isolated data and configuration settings.

## Multi-Tenancy

In a multi-tenant architecture, the application serves multiple tenants, isolating their data and providing separate functionality for each tenant. This project showcases the following aspects of multi-tenancy:

✨ **Separate Data:** Each tenant has its own data storage, ensuring data isolation and security.

🔌 **Shared Application:** The application code and logic are shared among tenants, reducing redundancy.

💼 **Tenant Identification:** Tenants are identified based on their unique identifier (ID) or subdomain.

🚀 **Scalability:** The architecture allows for easy scaling to accommodate growing tenant base.

## API Endpoints

The project includes the following API endpoints for managing employees:

### Get All Employees

- Endpoint: `GET /api/Employees`
- Description: Retrieve all employees for the specified tenant.
- Headers:
  - `tenant` (string) - The name of the tenant.
- Response: Returns a list of employees for the specified tenant.

### Get Employee by ID

- Endpoint: `GET /api/Employees/{id}`
- Description: Retrieve an employee by their ID for the specified tenant.
- Parameters:
  - `id` (integer) - The ID of the employee.
- Headers:
  - `tenant` (string) - The name of the tenant.
- Response: Returns the employee with the specified ID for the given tenant if found, or a 404 status if not found.

### Create Employee

- Endpoint: `POST /api/Employees`
- Description: Create a new employee for the specified tenant.
- Headers:
  - `tenant` (string) - The name of the tenant.
  - `Content-Type` (string) - Set to `application/json`.
- Request Body: Expects an `EmployeeDto` object with employee details (e.g., name, description).
- Response: Returns the created employee with a generated ID for the specified tenant.


## Usage

To use this project, follow these steps:

1. Clone the repository.
2. Build and run the project using a compatible .NET development environment.
3. Access the API endpoints mentioned above to interact with the employee data.

## Author

👨‍💻 Amine Nafkha - DotNet Developer!
- GitHub:  https://github.com/Aminenafkha1
- LinkedIn: https://www.linkedin.com/in/amine-nafkha/
