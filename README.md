# 🎓 Student Management System (ASP.NET Core MVC + SQLite)

The **Student Management System** is a lightweight yet powerful web application built using **ASP.NET Core MVC** and **Entity Framework Core** with **SQLite** as the database.  
It allows users to seamlessly **add, edit, search, and manage student records** through a clean, responsive, and user-friendly interface.  
Designed with simplicity and performance in mind, this project demonstrates core CRUD functionality, MVC architecture, and database integration.


---

## 🧩 Project Overview

The **Student Management System** is designed to simplify and automate basic academic operations like:
- Adding and managing student records
- Viewing and editing student details
- Searching students by name or roll number

It follows the **Model-View-Controller (MVC)** design pattern and uses **Entity Framework Core ORM** for database operations.

---

## 🧱 Tech Stack

| Component | Technology Used |
|------------|------------------|
| **Framework** | ASP.NET Core MVC (.NET 8.0) |
| **Language** | C# |
| **Database** | SQLite |
| **ORM** | Entity Framework Core |
| **Frontend** | Bootstrap 5, Razor Views |
| **IDE** | Visual Studio Code / Visual Studio |
| **Version Control** | Git & GitHub |

---


---

## ⚙️ Installation & Setup Guide

Follow these steps to run the project locally:

### **1. Clone the Repository**
```bash
git clone https://github.com/ViranshThakore/StudentManagementSystem-.NET-Project-415.git
cd StudentManagementSystem-.NET-Project-415
```

**2. Restore Dependencies**
```bash
dotnet restore
```
**3. Apply Database Migrations***
```bash
dotnet ef database update
```

💡 Make sure you have Microsoft.EntityFrameworkCore.Tools installed.
The project uses SQLite, so no external DB setup is required.

**4. Run the Application**
```bash
dotnet run
```
**5. View in Browser**

Once the server starts, open your browser and go to:

https://localhost:5001


or

http://localhost:5000

## 🧑‍💻 Core Features

| Feature | Description |
|----------|-------------|
| 🎓 **Student Management** | Add, edit, delete, and view student details easily. |
| 🔍 **Search Functionality** | Quickly find students by name or roll number using the search bar. |
| 💾 **Database Integration (SQLite)** | All data is stored locally in `student.db` using Entity Framework Core. |
| ⚙️ **Entity Framework Core Support** | Provides smooth ORM mapping and easy CRUD database operations. |
| 🧱 **Clean MVC Architecture** | Follows Model-View-Controller pattern for maintainable and scalable design. |
| 🌐 **Responsive User Interface** | Built with Bootstrap 5 to ensure mobile-friendly and elegant layouts. |
| 🚀 **Lightweight & Local Setup** | Runs locally with minimal configuration, no external dependencies required. |


##  Database Design

***Tables:***

Students


##
---

 **💾 Database Information**

**All your data is stored locally in student.db (SQLite).**

---

## 👨‍💻 Author

**Viransh Thakore**  
 
💼Asha M. Tarsadia Institue of Computer Science and Technology

📧Enrollment no.: 202303103510415

🔗 **GitHub:** [@ViranshThakore](https://github.com/ViranshThakore)
