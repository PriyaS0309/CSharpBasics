use demo;

create table FullTimeEmployee(EmployeeId int,EmployeeName varchar(30),EmployeeGender varchar(30),EmployeeSalary int);

alter table FullTimeEmployee alter column EmployeeGender varchar(30);

insert into FullTimeEmployee values (5,'Priya','Female',20000);

insert into FullTimeEmployee values (3,'Pooja','Female',30000);

insert into FullTimeEmployee values (4,'Shubham','Male',40000);
insert into FullTimeEmployee values (1,'Shweta','Female',25000);
insert into FullTimeEmployee values (2,'Aditya','Male',10000);

select * from FullTimeEmployee;                                             --data displayed in sorted order because of primary key also known as clustered index--

drop index FullTimeEmployee.[PK__FullTime__7AD04F1124020975];                 --we cannot drop this index because it is used as primary key but it can be deleted manually--
 
drop table FullTimeEmployee;

--to create clustered index using indexes------

create clustered index IX_FullTimeEmployeeIndex                        --creating clustered index --
on FullTimeEmployee(EmployeeId asc)

drop index FullTimeEmployee .[IX_FullTimeEmployeeIndex]              --if we want to create an another clustered index we have to delete the previous clustered index because we can have only one clustered index on one table--  

create clustered index IX_FullTimeEmployee_Salary_Gender
on FullTimeEmployee(EmployeeGender asc,EmployeeSalary asc)               --creating cluster index on a table on more than one column--


select * from FullTimeEmployee;                 --to see the result--


---non clustered index---

create nonclustered index IX_FullTimeEmployee_Name    --non clustered result cannot be reflected in the same table it is stored in the separate memory location--            
on FullTimeEmployee(EmployeeName asc)

create nonclustered index IX_FullTimeEmployee_Salary   -- we can have more than one non clustered indexes in a table--
on FullTimeEmployee(EmployeeSalary asc)

create nonclustered index IX_FullTimeEmployee_Id_Gender         -- at a time we can also make more than one column as non clustered--
on FullTimeEmployee(EmployeeId asc,EmployeeGender asc)

--------------------------------Unique and non-unique indexes--------------------------

create table Books(BookId int,BookName varchar(30),BookPrice int);

insert into Books values (1,'Introduction to MVC',200);
insert into Books values (2,'Introduction to SQL',300);
insert into Books values (3,'JAVA BASICS',250);
insert into Books values (4,'.NET BASICS',350);
insert into Books values (5,'Advanced SQL',500);

select * from Books;

create unique clustered index CIX_Books_Id
on Books(BookId asc);

insert into Books values (5,'Advanced Java',500); --it will not inseret this value the Id is a duplicate value--

create nonclustered index NCIX_Books_Name              --by default it is non unique and non clustered if u do not mention it--
on Books(BookName asc)

insert into Books values(6,'.NET BASICS',700);         --it will accept the duplicate BookName as it is non unique index--

