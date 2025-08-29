# 🏪 SportsStore

SportsStore is a sample e-commerce web application built with ASP.NET Core Razor Pages (.NET 6). It demonstrates modern web development practices, including user authentication, product management, and order processing—making it an excellent foundation for learning or extending to real-world scenarios.

## ✨ Features

- 🛒 **Product Catalog**: Browse and search products with detailed information.
- 🛍️ **Shopping Cart**: Add, update, and remove items from your cart.
- 📦 **Order Management**: Place orders and view order history.
- 🔒 **Admin Panel**: Manage products and orders with secure access.
- 👤 **User Authentication**: Register, login, and manage user accounts using ASP.NET Core Identity.
- 🛡️ **Role-Based Access**: Admin features protected by role-based authorization.
- 📱 **Responsive UI**: Clean, user-friendly interface with Razor Pages and partial views.

## 🛠️ Technologies Used

- ASP.NET Core Razor Pages (.NET 6)
- Entity Framework Core
- ASP.NET Core Identity
- SQL Server (default, configurable)
- Bootstrap (for UI styling)

## 🚀 Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- SQL Server (localdb or full version)

### Setup Instructions

1. **Clone the repository:**
   - https://github.com/CompilationErrror/Sport-store.git
2. **Configure the database:**
   - Update the connection string in `appsettings.json` if needed.

3. **Apply migrations and seed admin user:**
   - The application automatically applies migrations and seeds an admin user (`Admin` / `Secret123$`) on startup.

4. **Run the application:**
   - dotnet run

### 🧑‍💼 Default Admin Credentials

- **Username:** Admin
- **Password:** Secret123$

> ⚠️ Change these credentials in production for security.

## 📁 Project Structure

- `Models/` – Domain models, Identity setup, and data seeding.
- `Controllers/` – Handles requests for admin, account, and orders.
- `Views/` – Razor Pages and partial views for UI.
- `Infrastructure/` – Custom helpers and tag helpers.
- `Data/` – Entity Framework Core context and repositories.

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## 📄 License

This project is licensed under the MIT License.

---

**Note:** This project is intended for educational purposes and as a starting point for further development.

   