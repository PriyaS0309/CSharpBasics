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













              