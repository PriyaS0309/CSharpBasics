create database demo;            /*creating database*/

use demo;


create table StudentInfo(Student_Id int,Student_name varchar(20),Student_Rollno int,Student_age int);         /*creating table*/

select * from StudentInfo;                 /* To display table data*/

insert into StudentInfo values(111,'Priya',1,21);     /* inserting values in table */

insert into StudentInfo values(112,'shweta',2,20);
insert into StudentInfo values(113,'Pooja',3,23);
insert into StudentInfo values(114,'Aditya',4,18);
insert into StudentInfo values(115,'Shubham',5,26);

update StudentInfo set Student_name='Haresh' where Student_Id=114;     /*updating recorde*/

delete from StudentInfo where Student_name='Pooja';                    /*deleting records from table*/

truncate table StudentInfo;                  /*deletes all records from table */


create table Employee(Employee_Id int Primary key,Employee_name varchar(20) Not null,Employee_salary int not null);  /*use of not null and primary key constraint*/

insert into Employee values(1,'Priya',20000);
insert into Employee values(4,'Shweta',30000);
insert into Employee values(2,'Pooja',40000);
insert into Employee values(3,'twinkle',20000);

select * from Employee;

drop table Employee;         /*to drop table*/

create table Employee(Employee_Id int Primary key,Employee_name varchar(20) Not null,Employee_salary int,check(Employee_salary>10000),Employee_age int default(18));    /* using different constraints*/

insert into Employee values(1,'Priya',20000,22);
insert into Employee(Employee_Id,Employee_name,Employee_salary) values(4,'Shweta',30000);   /* sets default value 18 for age*/
insert into Employee values(2,'Pooja',40000,24);
insert into Employee values(3,'twinkle',20000,20);
insert into Employee values(5,'Priyanka',15000,19);

update Employee set Employee_name='Priyanka' where Employee_Id=5;

select * from Employee where Employee_age=24 or Employee_age=18;    /*select statement to execute a specific conditions */
