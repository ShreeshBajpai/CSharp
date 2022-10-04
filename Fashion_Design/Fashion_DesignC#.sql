create database fashionDesign
use fashionDesign

create table category (c_id int primary key, c_name nvarchar(20)); 
create table products (p_id int primary key, c_id int not null, p_name nvarchar(20), p_price int, p_quantity int, CONSTRAINT fk_products_category 
FOREIGN KEY (c_id)  
REFERENCES category (c_id)); 

select * from category;

select * from products;
delete from category where c_id=2;

