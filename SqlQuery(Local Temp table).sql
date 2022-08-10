create table #EmpData(Employee_Id int,Employee_name varchar(30),Employee_salary int);    --creates a local temp data

select name from tempdb..sysobjects where name like '%#EmpData%'                      --to see whether table is created

insert into #EmpData values(1,'Shweta',20000);                 -- inserting data into temp table
insert into #EmpData values(2,'Vidya',25000);
insert into #EmpData values(3,'Pranali',30000);
insert into #EmpData values(4,'Santosh',35000);

select * from #EmpData;                         --to see the data of the temp table


create procedure SP_EmpTempData						--creating sp and creating temp table in sp--
as
begin
	create table #EmpDetails(Employee_Id int,Employee_name varchar(30),Employee_salary int);    --creates a local temp data

select name from tempdb..sysobjects where name like '%#EmpDetails%'                      --to see whether table is created

insert into #EmpDetails values(1,'Shweta',20000);                 -- inserting data into temp table
insert into #EmpDetails values(2,'Vidya',25000);
insert into #EmpDetails values(3,'Pranali',30000);
insert into #EmpDetails values(4,'Santosh',35000);

select * from #EmpDetails;                         --to see the data of the temp table

end

exec SP_EmpTempData              --executing sp-- after executing sp the table gets droped automatically that was created inside the sp--


select * from #EmpDetails;           --after executing sp and if we want the data of that table created in sp it will not show that table-           

