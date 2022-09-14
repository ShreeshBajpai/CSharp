
/* There are number of departments where employees are working and all registered employees. 
According to daily hours in the last of month total hours will be get calculated and employees got the salaries. 
And for overtime employees will get addition 2 times money for every hour. Stock should be maintained . 
Salary should be maintained and admin want to Salary should be maintained and admin want to see purchase cost 
and car manufacturing price including manpower cost meaning complete balance sheet of month total purchase 
total salary distribution and profit loss. */

create database CarManufacturing
use CarManufacturing

create table employeeWorkingHrs (empid int primary key, totalworkinghours int)

create table Department (departmentId int primary key, Department_name nvarchar(20), sal_perhour int)

select * from Department
insert into Department values (1, 'Finance', 1800)
insert into Department values (2, 'Sales and Marketing.', 1900)
insert into Department values (3, 'HR',  2000)
insert into Department values (4, 'Administration', 2200)
insert into Department values (5, 'Testing', 1600) 
insert into Department values (6, 'Industrial Relations', 1800)
insert into Department values (7, 'Production', 1700)
insert into Department values (8, 'Logistics', 1800)
insert into Department values (9, 'IT', 2000)
insert into Department values (10, 'Maintenance', 1900)
insert into Department values (11, 'Packaging', 1800)
insert into Department values (12, 'Dispatch', 1800)


create table Employee (empid int primary key, Dept_id int CONSTRAINT fk_Emp_DeptID 
FOREIGN KEY (Dept_id)  
REFERENCES Department (departmentId), Employee_Name nvarchar (20), total_working_hours int, Employee_Contact nvarchar(10))

insert into Employee values (101, 1, 'Akshat Rawat', 189, '7045645923')
insert into Employee values (701, 7, 'Bhanu Pundir', 190, '9172546237')
insert into Employee values (401, 4, 'Shreyash Naithani', 192, '7189567430')
insert into Employee values (601, 6, 'Pawan Tiwari', 190, '6397456719')
insert into Employee values (901, 9, 'Sajal Gupta', 200, '7189567430')
insert into Employee values (1101, 11, 'Sumit Thapliyal', 180, '6397455629')


select * from Employee



create table parts (partId int primary key, partname nvarchar(20), Part_qty int, PerQtyPrice int)
create table stocks (part_Id int CONSTRAINT fk_stock_prod 
FOREIGN KEY (part_Id)  
REFERENCES parts (partId), quantity int)

insert into parts values (1, 'Door', 90, 3000)
insert into parts values (2, 'Sensors', 100, 5000)
insert into parts values (3, 'Seats', 70, 32000)
insert into parts values (4, 'Window', 50, 6000)
insert into parts values (5, 'Glass', 30, 2000)


select * from parts

insert into stocks values (1, 30)
insert into stocks values (2, 40)
insert into stocks values (3, 23)
insert into stocks values (4, 17)
insert into stocks values (5, 10)

select * from stocks