# 🚚 Delivery Management System

### 🏫 American International University–Bangladesh (AIUB)
**Department:** Computer Science  
**Course:** CSC2210 – Object Oriented Programming 2  
**Semester:** Summer 2024–2025  
**Section:** R  
**Group:** 05  


## Supervised by:
- **Mehedi Sayed**  
  Programmer, SDD  
  Email: [sayedmehedi@aiub.edu](mailto:sayedmehedi@aiub.edu)  
  American International University–Bangladesh (AIUB)


## Developed by:
- **Mohammad Ali Masud**  
  Email: [23-51676-2@student.aiub.edu](mailto:23-51676-2@student.aiub.edu)
  
- **Md. Mahabubur Rahaman Siam**  
  Email: [23-51706-2@student.aiub.edu](mailto:23-51706-2@student.aiub.edu)
  
- **Sumaiya Naeem Mohammed**  
  Email: [23-54378-3@student.aiub.edu](mailto:23-54378-3@student.aiub.edu)


---

## 🧩 Project Overview
The **Delivery Management System** is a desktop-based logistics platform built with **C# (WinForms)** and **SQL Server** to manage shipments, payments, and delivery tracking between sellers and customers.  
It automates delivery operations by connecting multiple user roles — **Admin, Employee, Carrier, and Client** — within one integrated database system.

---

## 🎯 Objectives
- Develop a real-life logistics management application using **Object-Oriented Programming concepts**.  
- Integrate a **Graphical User Interface (GUI)** with a **relational database**.  
- Implement **role-based access control** for secure and efficient operations.  
- Automate shipment creation, payment validation, and delivery tracking.

---

## 🧱 System Features

### 👨‍💼 Admin
- Manage employees, carriers, and shipment data.  
- View and edit all records (except client accounts).  
- Oversee payment verification and delivery status updates.  

### 🧑‍🔧 Employee
- Verify payments and assign carriers to shipments.  
- Manage operational logistics (carriers, routes, shipments).  
- Update tracking and payment information.  

### 🚚 Carrier
- View assigned shipments.  
- Update delivery status (Pending → In Transit → Delivered).  

### 🧑‍💻 Client (Seller)
- Create and view shipment orders.  
- Automatically generate routes and estimated delivery times.  
- Edit personal account information.  

### 🧍 Customer (Receiver)
- Track shipments linked to their Client ID.  
- Register and manage account information securely.  

---

## 🗂️ Database Schema

| Table | Key Fields | Description |
|-------|-------------|--------------|
| **SignUp** | ClientID (PK) | Stores seller and customer data |
| **Login** | UserID (PK) | Stores admin, employee, and carrier credentials |
| **Shipment** | ShipmentID (PK), ClientID (FK), CarrierID (FK), RouteID (FK) | Core shipment table |
| **Route** | RouteID (PK) | Stores pickup and destination data |
| **Payment** | PaymentID (PK), ShipmentID (FK) | Tracks payment information |
| **Carrier** | CarrierID (PK), UserID (FK) | Carrier details |
| **Employee** | EmployeeID (PK), UserID (FK) | Employee details |

---

## 🧠 Role Permissions

| Role | Create | View | Update | Delete |
|------|---------|------|---------|---------|
| **Admin** | Employees, Carriers, Routes | All Records | Payment, Tracking, Assignments | Employees, Carriers, Shipments |
| **Employee** | Shipments, Carriers | All Shipments | Payment, Route, Carrier Assignment | Shipments |
| **Carrier** | – | Assigned Shipments | Tracking, Profile | – |
| **Seller (Client)** | Shipments | Own Shipments | Profile | Account |
| **Customer (Client)** | – | Linked Shipments | Profile | Account |

## 🔹 Login Credentials
| Role     | Email                                     | Password |
| -------- | ----------------------------------------- | -------- |
| Admin    | sumaiya@gmail.com                         | 1234     |
| Employee | siam@gmail.com                            | 1234@    |
| Carrier  | david@gmail.com                           | 12345    |
| Client   | mohammadalimasud11@gmail.com              | 12345    |

---
## ER DIAGRAM
<img width="940" height="638" alt="image" src="https://github.com/user-attachments/assets/fb12cc6b-4c40-4cc4-b77b-a5f2207f3d06" />

## 💾 Example SQL Queries

**SELECT QUERY:**
1.	SELECT * FROM Signup WHERE Email = {email};
2.	SELECT Password FROM Signup WHERE Email = '{Email}';
3.	select * from Payments;
4.	SELECT PaymentStatus FROM Shipment WHERE ShipmentId = txtId.Text;
5.	SELECT ClientId FROM SignUp WHERE Email='{staticWelcome.email}';
6.	select distinct Origin from Route;
7.	SELECT Role, Name FROM Signup WHERE Email = '{email}' AND Password = '{password}'";
8.	$"SELECT * FROM Signup WHERE Email = '{email}'";
9.	"SELECT * FROM employee WHERE EmployeeId =" + Id;
10.	$"SELECT * FROM Signup WHERE Email = '{email}'";
    
**UPDATE QUERY:**
1.	UPDATE SignUp SET + "Password = '" + password + "', " + "DateOfBirth = '" + dob + "', " + "Gender = '" + gender + "', " + "ClientContact = '" + contact + "', " + "Address = '" + address + "' " + "WHERE ClientId = " + ClientId;
2.	UPDATE Shipment SET TrackingStatus='" + cmbTrackingStatus.SelectedItem + "',TypeOfGoods='" + txtGoods.Text  + "',EstimatedDeliveryTime='" + dateTimePicker1.Value + "',Carrier='" + cmbCarrier.SelectedValue + "' WHERE ShipmentId=" + txtId.Text;
3.	$"UPDATE Carrier SET Name='{name}', Password='{password}', DateOfBirth='{dob:yyyy-MM-dd}', Gender='{gender}', Contact='{contact}', Address='{address}' WHERE LoginId = {Id}";

**INSERT QUERY:**
1.	INSERT INTO SignUp (Name, Email, Password,DateOfBirth,Gender,ClientContact,Address, Role) " + $"VALUES ('{name}', '{email}', '{password}', '{dob:yyyy-MM-dd}', '{gender}' , '{contact}', '{address}','Client')";
2.	INSERT INTO SignUp (Name, Email, Role) "+ $"VALUES ('{RName}', '{REmail}', 'Client')";
3.	INSERT INTO Route (Origin,Destination) " VALUES ('{Origin}','{Destination}')";
4.	INSERT INTO Employee(LoginId,Name,Email,Password,DateOfBirth,Gender,Contact,Address)" +$"Values('{Id}','{Name}', '{email}', '{Password}', '{dob}','{gender}','{Contact}','{Address}')";

**DELETE QUERY:**
1.	delete from Shipment where ShipmentId=" + txtId.Text;
2.	$"DELETE FROM Payments WHERE PaymentID={txtPaymentId.Text}";
3.	delete from LOGIN where UserId= + Id;
4.	$"DELETE FROM Signup WHERE Email = '{email}'";


### 🖼️ UI Screenshots

## Login Page
<img width="940" height="504" alt="image" src="https://github.com/user-attachments/assets/90780cf6-9310-45be-8dd7-cd2f306b3eec" />


## Sign Up Page
<img width="940" height="720" alt="image" src="https://github.com/user-attachments/assets/5f633439-a871-46bd-93b2-3785bb099a5e" />


## Client Dashboard (Seller & Customer Views)
<img width="940" height="501" alt="image" src="https://github.com/user-attachments/assets/bcb63eba-a4a3-48e3-9bcb-90c0fbe4b4c7" />

<img width="940" height="501" alt="image" src="https://github.com/user-attachments/assets/991f52ad-8092-4d94-b8ef-c6f1e72fba9a" />

<img width="940" height="499" alt="image" src="https://github.com/user-attachments/assets/8a64b593-2ffb-4036-ae65-5683a0b76cac" />




## Employee Dashboard
<img width="940" height="502" alt="image" src="https://github.com/user-attachments/assets/02759bf6-4772-461d-9d72-dc3b51e515a9" />

<img width="940" height="725" alt="image" src="https://github.com/user-attachments/assets/5432cc32-15c3-4dae-947b-bb70eaf97033" />


## Payment Management
<img width="940" height="501" alt="image" src="https://github.com/user-attachments/assets/48a4bf5f-5e5a-4d94-aae7-ea1fb6307573" />


## Carrier Panel
<img width="940" height="598" alt="image" src="https://github.com/user-attachments/assets/2b0d9fef-6ffa-406e-b983-ddb30cdab321" />


<img width="940" height="497" alt="image" src="https://github.com/user-attachments/assets/f288dfe1-5c5d-4020-80e5-9108fa10f316" />


## Route Management
<img width="940" height="567" alt="image" src="https://github.com/user-attachments/assets/ec6e2d54-14b2-4742-ab18-198c1d00b6b0" />


## Admin Panel
<img width="940" height="503" alt="image" src="https://github.com/user-attachments/assets/a23d8ea1-e803-4048-8c27-fb72d700c985" />


#### ⚙️ Technologies Used

Language: C# (.NET Framework, WinForms)

Database: Microsoft SQL Server 2014/2022

IDE: Visual Studio

Design Pattern: Layered architecture (UI, Logic, Database)

## 🏁 How to Run

Clone this repository:

git clone https://github.com/siam1234-Brand/Delivery-Management-System_cSharp-Project


Open the project in Visual Studio.

Restore the SQL Server database using the provided smsSystem.bak.
Tutorial For Restore: https://www.youtube.com/watch?v=btePFK-5gpM

Configure the connection string in DbHelper.cs.

Run the project — the login form will appear as the starting window.

## 📚 Learning Outcome

This project demonstrates how object-oriented design, GUI-based data operations, and database integration can be combined to build a complete real-world system.
It strengthened our understanding of modular programming, data validation, and system verification in a C# environment.

## 📄 License

This project is developed for educational purposes under AIUB. Feel free to fork and modify for your own learning and experimentation.
All rights reserved © 2025 Group 05, AIUB.
