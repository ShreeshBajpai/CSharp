create database Bank
use Bank

create table CustomerDetails (pid int primary key, cid int not null, pname nvarchar(30), pprice int)
create table Customers_log(logID int primary key identity, custId int, operation nvarchar(20), updateDate Datetime);

insert into CustomerDetails values (1, 11, 'Ahutosh', 2000)
insert into CustomerDetails values (2, 12, 'Vivek', 2500)
insert into CustomerDetails values (3, 13, 'Shyam', 6000)
select * from Customers_log

-- Creating trigger for inserting into CustomerDetails table

create trigger CustomerInsertTrigger
on CustomerDetails
for insert
as
insert into Customers_log(custId, operation, updateDate)
select pid, 'Data Inserted', GETDATE() from inserted

-- Customer update trigger


create trigger CustomerUpdateTrigger
on CustomerDetails
after update
as
insert into Customers_log(custId,operation,updateDate)
select pid,'Data Updated', GETDATE() from deleted

-- Customers delete trigger

create trigger CustomerDeleteTrigger
on CustomerDetails
after delete
as
insert into Customers_log(custId,operation,updateDate)
select pid,'Data Deleted', GETDATE() from deleted