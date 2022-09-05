create database PizzaInfo
use PizzaInfo 
create table alogin(aid nvarchar(20), apass nvarchar(20));
insert into alogin values ('12345', 'admin')
select * from alogin
create table flogin(fid nvarchar(20), fname nvarchar(20), fpass nvarchar(20));
insert into flogin values (102, 'Pizza Hut', 'Malsi')
insert into flogin values ('101', 'Dominos','admin' )
select * from flogin

create table f_details(f_id int primary key, f_name nvarchar(20), f_loc nvarchar(20));
insert into f_details values (102, 'Pizza Hut', 'Malsi')
select * from f_details
create table emp(e_id int primary key, f_id int not null, e_name nvarchar(20), e_sal int , CONSTRAINT fk_emp_fdetails 
FOREIGN KEY (f_id)  
REFERENCES f_details (f_id) );
insert into emp values (1, 101, 'Sajal', 35000)
select * from emp
create table sales(s_id int primary key, f_id int not null, s_amount int, s_date date, s_mode nvarchar(10), CONSTRAINT fk_sales_emp 
FOREIGN KEY (f_id)  
REFERENCES f_details (f_id));
select * from sales
insert into sales values (84321, 101, 350, '2022-08-29', 'Offline')
select * from emp
select *from f_details