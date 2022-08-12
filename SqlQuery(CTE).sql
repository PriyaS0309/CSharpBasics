use demo;

select * from FullTimeEmployee;

with New_CTE                         --creating CTE--
as
(
	select * from FullTimeEmployee where EmployeeGender='Female'
)
select * from New_CTE where EmployeeSalary>=20000;                  --using CTE immeditely--



with New_CTE(id,Ename,salary)           --creating CTE with columns
as
(
	select EmployeeId,EmployeeName,EmployeeSalary from FullTimeEmployee
)
select Ename,salary from New_CTE


with New_CTE
as
(
	select * from FullTimeEmployee
)
insert New_CTE values(6,'Priyanka','Female',28000)             --inserting a record in CTE--          --into will not be used in CTE along with insert statement--



with New_CTE
as
(
	select * from FullTimeEmployee
)
update New_CTE set EmployeeName='Sakshi' where EmployeeId=6;          --updating record in CTE--



with New_CTE
as
(
	select * from FullTimeEmployee
)
delete New_CTE where EmployeeId=6;                          --deleting records from CTE--           --from record will not be used in CTE while deleting records--



create view MyView                                          --creating view in CTE--
as
with New_CTE
as
(
	select * from FullTimeEmployee where EmployeeSalary>20000
)
select * from New_CTE     --executing CTE--


select * from MyView;                 --executing View--                 