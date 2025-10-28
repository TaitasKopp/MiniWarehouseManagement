# Mini Inventory Management System – SQL-Driven

This project is a small inventory management solution that focuses on data modelling and business logic directly in SQL.  
The goal is to represent core warehouse operations using a clean relational database structure and transparent data flow.

---

## 📦 Project Overview

The system is based on three main tables:

| Table    | Purpose                         |
|----------|----------------------------------|
| Article  | Stores product master data       |
| Stock    | Holds the current stock level    |
| Booking  | Logs every stock movement        |

This structure reflects typical inventory processes:
- creating new articles
- increasing or reducing stock
- keeping a full history of movements (inbound and outbound)

Every stock change is linked to a booking entry, which ensures **traceability**, **transparency** and **auditability**, just like in real retail/logistics systems.

---

## 🎯 Motivation

Inventory management is a core business process in retail and supply chain environments.  
Before building a user interface or an application layer, it is important to understand how the **data itself** represents the process.

The goal of this project is to design the solution from a **data-first perspective**, implementing business rules inside the database model rather than in application code.

---

## 💼 Business Value

This project demonstrates:

✅ how relational data structures can represent real business processes  
✅ how booking history creates transparency and accountability  
✅ how SQL queries can produce meaningful insights for decision making  
   (e.g. top moving items, low stock alerts, reordering thresholds)

It is a minimal but realistic example of how IT supports core business operations — starting at the data layer.

---

## 🔧 Extendability

Because the logic is implemented directly in SQL, the project can easily be extended with:
- a console application,
- a web frontend,
- a REST API,
- or reporting dashboards.

The database layer already contains the business logic, so every additional interface can build upon it without restructuring the core.

---

*(more sections like Setup, Schema, Queries, etc. can be added below as the project grows)*
