use demo;

create table Teacher(Teacher_Id int primary key identity,Teacher_name varchar(30) not null,Salary int not null);   --identity constraint is used to automatically increment the value--

select * from Teacher;

insert into Teacher values('Manisha',30000);						--here while inserting values we are not giving value for id because we have used identity for ID column--
insert into Teacher values('Rashmi',35000);
insert into Teacher values('Shital',40000);
insert into Teacher values('Prajisha',20000);
insert into Teacher values('Divya',25000);
insert into Teacher values('Geetanjali',45000);


-----------------Union and union all-----------------

create table MathStudentIno(Student_Id int primary key identity,Student_name varchar(30),Student_Address varchar(30));

select * from MathStudentIno;

insert into MathStudentIno values('Priya','abc');
insert into MathStudentIno values('Shweta','ajhc');
insert into MathStudentIno values('Pooja','abcjjhj');
insert into MathStudentIno values('Shubham','abfdfdc');
insert into MathStudentIno values('Aditya','hghgh');


create table ChemistryStudentInfo(Student_Id int primary key identity,Student_name varchar(30),Student_Address varchar(30));

select * from ChemistryStudentInfo;

insert into ChemistryStudentInfo values('Priya','abc');
insert into ChemistryStudentInfo values('Twinkle','bbbb');
insert into ChemistryStudentInfo values('Priyanka','cccc');
insert into ChemistryStudentInfo values('Shubham','abfdfdc');
insert into ChemistryStudentInfo values('Vijay','dddd');


select * from MathStudentIno
Union																	--using union between 2 tables which have same num of columns,same datatype,same names of columns is mandatory--
select * from ChemistryStudentInfo;										-- union does not give duplicate values between tables and gives output in sorted order--


select * from MathStudentIno
Union All														    --union all gives duplicate values also and the values are not in sorted order--
select * from ChemistryStudentInfo;

------intersect-------

select * from MathStudentIno                                  -- gives only the common data from 2 tables--
Intersect
select * from ChemistryStudentInfo;

-----except----------

select * from MathStudentIno                      --only gives the extra data of left table i.e MathStudentInfo and does not provide data that is common between both tables and data of Right table--
Except
select * from ChemistryStudentInfo;