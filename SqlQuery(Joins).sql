use demo;

select * from Employee;
select * from Department;

insert into Employee values(113,'Pooja',30000);






create table Department(Department_Id int unique,Department_name varchar(30) not null,Employee_Id  int not null);


insert into Department values(1,'Finance',111);

insert into Department values(2,'IT',112);

insert into Department values(3,'IT',114);

update Department set Department_name='Management' where Department_Id=3; 

insert into Department values(4,'Accounts',115);


select * from Employee e inner join Department d           --inner join--
on e.Employee_Id=d.Employee_Id;


select * from Employee e left outer join Department d      --left outer join--
on e.Employee_Id=d.Employee_Id;

 
select * from Employee e right outer join Department d      --right outer join--
on e.Employee_Id=d.Employee_Id;

select * from Employee e full outer join Department d       --full outer join--
on e.Employee_Id=d.Employee_Id;

select * from Employee e cross join Department d;            --cross join--


/*create table Employee_Manager(Employee_Id int unique,Employee_name varchar(30),Manager_Id int);
 
insert into Employee_Manager values(1,'Priya',4);
insert into Employee_Manager values(2,'Shweta',4);
insert into Employee_Manager values(3,'Pooja',2);
insert into Employee_Manager values(4,'Priyanka',1);
insert into Employee_Manager values(5,'Twinkle',3);

select * from Employee_Manager;*/











