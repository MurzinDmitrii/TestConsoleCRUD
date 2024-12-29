create database EmployeeDB
go
use EmployeeDB
go

create table Employees(
	EmployeeID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Email nvarchar(100) unique,
	DateOfBirth date,
	Salary decimal)