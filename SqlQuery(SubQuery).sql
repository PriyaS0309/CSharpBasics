select * from Employee;
select * from Department;

select * from Employee
where Employee_name in(select Employee_name from employee where Employee_salary>20000);

update Employee set Employee_salary=Employee_salary+2000
where Employee_Id in (select Employee_Id from Employee where Employee_city ='Mumbai' );  --updating table employee where employee salary increases by 2000 where employee city is mumbai--

delete from Employee 
where Employee_Id in(select Employee_Id from Employee where Employee_name='Aditya');            --deleting table record using subquery--

select * from Employee                                                                             --subquery using 2 tables--
where Employee_Id in (select Employee_Id from Department where Department_name='Management');


select * from Employee																																		
where Employee_Id in (select Employee_Id from Employee where Employee_name in('Priya','Pooja'))order by Employee_Id desc;   --subquery using order by clause--