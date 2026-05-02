# Student & Employment Management System

A OOP project for managing student data, printing grades, and calculating salaries and incentives for employees. 
Built with C# and .NET Framework.

##  Project Structure

One solution containing three projects:

| Project | Type | Content |
|---------|------|---------|
| **People** | Class Library | Classes: `Human`, `Student` |
| **Employment_Office** | Class Library | Class: `Employee` |
| **Management** | Console App | Classes: `Management`, `Administrator`, `Program` |

##  Inheritance Relationship

Human (Partial concrete)
↑
Student (Partial abstract)
↑
Employee (Fully abstract)
↑
Management (Concrete)
↑
Administrator (Normal concrete)


## 🧨 How to Run

1. Open the solution in Visual Studio.
2. Set `Management` as the startup project.
3. Press F5 to run.

The program will:
- Display a welcome message and group members.
- Ask for the number of students.
- For each student, ask for personal info and degree input.
- Print subject grades, sum, average, and final grade.
- Ask for job type and scientific degree to calculate salary and incentive.
- Print all data in **capital letters**.

Eng- Hani Ahmed Adbullah Muhammad
---