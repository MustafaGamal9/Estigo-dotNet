

# Estigo E-Learning Platform - Backend API

  ![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white) ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white) ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)



This repository contains the backend API for the **Estigo E-Learning Platform**, built with **ASP.NET Core 8**. It serves as the robust and secure backbone for the [Estigo Angular Frontend](https://github.com/mustafagamal9/estigo-angular), providing all necessary data, business logic, and services.

  

The API is designed with a clean architecture, featuring role-based authentication, comprehensive data models, and a rich set of endpoints to support a multi-user e-learning ecosystem.

   [Check Swagger](https://estigo.runasp.net/swagger/index.html)

## ✨ Key Features & API Architecture

  



### 🔐 **Authentication & Authorization (`AuthController`)**

*  **Role-Based Registration:** Separate registration endpoints for **Students**, **Teachers**, **Parents**, and **Admins**.

*  **Secure JWT Login:** Implements JSON Web Token (JWT) based authentication for secure and stateless API access.

*  **ASP.NET Core Identity:** Leverages the power and security of ASP.NET Core Identity for user and role management.

*  **Role-Based Authorization:** Endpoints are protected, and access is granted based on user roles (e.g., `[Authorize(Roles = "Admin")]`).

  

### 📚 **Course & Content Management**

#### **Course Controller (`CourseController`):**
- Full CRUD (Create, Read, Update, Delete) operations for courses
- Endpoints to fetch courses by category, for the homepage, and for a powerful keyword search
- Provides detailed course information, including associated lessons and teacher data

#### **Lesson Controller (`LessonController`):**
- Manages lessons, including support for both pre-recorded video links and live stream URLs (`isLive` flag)
- Endpoint to retrieve all lessons and detailed content for a specific course page

#### **Exam & Quiz Management (`ExamController`):**
- Functionality to create exams with a bank of questions and associate them with specific lessons
- Supports marking exams as "Final" to influence student performance tracking
- Securely handles quiz submissions, calculating scores, and storing results

---

### 👤 **Role-Specific Functionality**

#### **Student Endpoints (`StudentController`, `DashboardController`):**
- Secure course enrollment and payment record creation
- Fetches personalized dashboard data, including enrolled courses, quiz history, and payment info
- Retrieves a student's full list of enrolled courses (`/mycourses`)

#### **Teacher Endpoints (`TeacherController`):**
- Lists all students enrolled in a teacher's courses
- Allows teachers to upload new courses (submitted for admin approval), lessons, and quizzes
- Provides access to view a specific student's detailed exam answers and performance data

#### **Parent Endpoints (`ParentController`):**
- A secure endpoint for parents to view their child's quiz history and performance data by providing a unique **Student Code**

#### **Admin Endpoints (`AdminController`):**
- Comprehensive user management: list all users by role (Student, Teacher, Parent) and delete users
- **Course Approval Workflow:** A dedicated endpoint to fetch courses with a `Pending` status, allowing admins to approve or reject them

  

### 🤖 **AI & Prediction Engine (`PredictionController`)**

*  **Data Aggregation:** Collects and processes a student's performance metrics within a specific subject category, including attendance, quiz scores, completion rates, and final exam attempts.

*  **External AI Service Integration:** Securely communicates with an external **Python/FastAPI** service to generate a predicted grade based on the aggregated performance data.

  

## 🚀 Technology Stack

*  **Framework:**  **ASP.NET Core 8**

*  **Language:**  **C#**

*  **Database:**  **SQL Server**

*  **Object-Relational Mapper (ORM):**  **Entity Framework Core 9**

*  **Authentication:**  **ASP.NET Core Identity** with **JWT** for token-based authorization.

*  **API Documentation:**  **Swagger (OpenAPI)** for interactive API testing and documentation.

*  **Dependencies:**  `Newtonsoft.Json` for handling JSON Patch operations.

  

 

  

## ⚙️ Getting Started

  



  

### Installation & Setup

  

1.  **Clone the repository:**

```sh

git clone https://github.com/mustafagamal9/estigo-dotnet.git

cd estigo-dotnet

```

  

2.  **Configure Database Connection:**

* Open the `Estigo/appsettings.json` file.

* Locate the `ConnectionStrings` section.

* Update the `cs` value to point to your local SQL Server instance.

```json

"ConnectionStrings": {

"cs": "Server=YOUR_SERVER_NAME;Database=EstigoDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;"

}

```

  

3.  **Apply Database Migrations:**

* Open a terminal or command prompt in the `Estigo/` directory.

* Run the following command to create the database and apply all migrations and seed data:

```sh

dotnet ef database update

```

  

4.  **Run the Application:**

* You can run the project from Visual Studio by pressing `F5` or by using the .NET CLI:

```sh

dotnet run

```

  


