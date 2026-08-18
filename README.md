# 🚗 Car Rental Desktop Management System

![.NET Framework](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Microsoft SQL Server](https://img.shields.io/badge/SQL%20Server-CC292B?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-68217A?style=for-the-badge&logo=.net&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)

A robust, data-driven desktop enterprise application built using **C#**, **Windows Forms**, and **Entity Framework (ORM)** with **Microsoft SQL Server**. Designed to streamline car rental operations, user access control, inventory tracking, and transaction records.

---

## 📌 Features

### 🔐 Authentication & Access Control
* **Secure User Login:** Encrypted credential handling and user validation.
* **Role-Based Access Control (RBAC):** Differentiated views and privileges for Admin vs. Standard Operators.
* **User Management System:** Capability for administrators to create, update, or deactivate employee accounts.

### 🚘 Vehicle & Inventory Management
* **Complete CRUD Operations:** Full capability to add, view, update, and soft-delete fleet inventory.
* **Dynamic Search & Filtering:** Quick lookup by vehicle model, make, license plate, or availability status using LINQ queries.
* **Real-time Status Tracking:** Automatically track rented vs. available vehicles in real-time.

### 📝 Rental Operations & Bookings
* **Rental Processing:** Seamless UI to assign available cars to registered customers.
* **Input Validation & Exception Handling:** Strict client-side data validation to maintain database integrity and prevent runtime crashes.
* **Automated Calculations:** Auto-compute rental duration and pricing based on daily rates.

---

## 🏗️ Architecture & Tech Stack

* **Language:** C#
* **GUI Framework:** Windows Forms (WinForms)
* **Data Access Layer:** Entity Framework (Database First / Code First ORM)
* **Database Management System:** Microsoft SQL Server (T-SQL)
* **Querying:** LINQ (Language Integrated Query)
* **Architecture Pattern:** N-Tier / Layered Desktop Architecture

---


## 🚀 Getting Started

Follow these instructions to get a local copy up and running on your machine.

### Prerequisites

Make sure you have the following installed:
* [Visual Studio 2022](https://visualstudio.microsoft.com/) (with `.NET Desktop Development` workload enabled)
* [Microsoft SQL Server Express / Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
* [.NET Framework / .NET SDK](https://dotnet.microsoft.com/download)

### Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone [https://github.com/YOUR-USERNAME/car-rental-app.git](https://github.com/YOUR-USERNAME/car-rental-app.git)
   cd car-rental-app
