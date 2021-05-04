create database VP_Lect24
go

Use VP_Lect24
go

Create Table Employees
(
	EmployeeId int primary key identity(1,1),
	EmployeeName nvarchar(100)
)
go

Insert into Employees Values('Osama Ahmad')
Insert into Employees Values('Khaled Mohammad')
Insert into Employees Values('Adi Maaita')
Insert into Employees Values('Ziad Khaled')

select * from Employees
