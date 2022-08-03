
alter database Newdemo modify name=Demo;                      /* to rename database name*/

drop table Products;

select * from Category;


create table Products(Product_Id int primary key,Product_name varchar(30),Category_Id int foreign key references Category (Category_Id));

truncate table Products;

insert into Products values(1,'Kikat',1);
insert into Products values(2,'DairyMilk',1);
insert into Products values(3,'Cococola',3);
insert into Products values(4,'Chakli',4);

alter table Products add Product_type varchar(10);     /* to add column in the existing table*/

update Products set Product_type='A' where Product_Id='1';
update Products set Product_type='B' where Product_Id='2';
update Products set Product_type='C' where Product_Id='3';
update Products set Product_type='D' where Product_Id='4';


alter table products drop column Product_type;      /*to delete column from table*/

execute sp_rename 'Products','Product';            /* to rename table name*/

alter table product alter column Product_name nvarchar(20);   /* to change the datatype of existing column*/


select * from Product;

alter table Product alter column Product_name nvarchar(20) not null;     /* changing the type of constraint of a particular column*/

create table Employee(Employee_Id int Primary key,Employee_name varchar(30) ,Employee_salary int not null);

insert into Employee values(111,'Priya',20000);


alter table Employee add unique(Employee_name);   /* add constraint to the existing table*/

insert into Employee values(112,'Shweta',20000);

select * from Employee;

alter table Employee drop constraint UQ__Employee__155817A7AD65AFB2;   /*Remove constraoint from existing table*/



 


