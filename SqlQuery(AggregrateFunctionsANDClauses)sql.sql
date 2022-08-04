--Aggregrate Functions---

select * from Employee;

select sum(Employee_salary) as Total_Salary from Employee;        --Sum function is used to calulate the sum of all salary of employees present in employee table--

select max(Employee_salary) as Max_Salary from Employee;		  -- max function returns the maximum salary from employee table--

select min(Employee_salary) as Min_Salary from Employee;		    -- min function returns the minimum salary from employee table --     

select avg(Employee_salary) as Average_Salary from Employee;        -- avg function returns the average of all employees salary--

select count(*) from Employee;                                      --count function returns the total number of records present in a table--

-----------------GROUP BY Clause-----------------------------------

alter table Employee add  Employee_city varchar(20);

update Employee set Employee_city ='Mumbai' where Employee_Id=111 or Employee_Id=114;



update Employee set Employee_city ='Pune' where Employee_Id=112 or Employee_Id=113;


update Employee set Employee_city ='Chennai' where Employee_Id=115; 

select Employee_city, max(Employee_salary) as Maximum_salary_according_Cities from Employee Group By Employee_city; 

select * from Employee;

-----------Having clause-------------------

select Employee_city, max(Employee_salary) from Employee               
Group by Employee_city                                       
having max(Employee_salary) > 20000;                           -- aggregrate functions can be used with Having clause---to check specific condition--


select Employee_city,max(Employee_salary) as Max_salary from Employee
where Employee_city in('Mumbai','Pune') 
group by Employee_city  
having max(Employee_salary) > 20000;

--------order by-----------

Select * from Employee
order by Employee_salary;                            --gives salary in ascending format by default--


select * from Employee
order by Employee_name desc;                       --gives name of employees in descending format--
