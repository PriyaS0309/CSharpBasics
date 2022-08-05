use demo;

select * from Employee where Employee_salary between 20000 and 30000;

select top 3 * from Employee;

select top 50 percent * from Employee;                            --this query gives the top 50% records of Employee table--

select distinct * from Employee;                ---gives only the unique values--

select * from Employee where Employee_salary in (20000,30000,27000);

select * into EmployeeNew from Employee;

Select * from EmployeeNew;

sp_renamedb 'demo1','demo';

