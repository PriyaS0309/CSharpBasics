use demo;

create function ShowMessage()   
returns varchar(30)
as
begin
      return 'Welcome to functions'                             --scalar with no parameters--
end

select dbo.ShowMessage();


create function TakeNumbe(@num as int) 
returns int
as
begin
	return (@num * @num)                        --scalar function taking single parameter--
end


select dbo.TakeNumbe(2);


create function Addition(@num1 as int,@num2 as int)
returns int
as
begin
	return(@num1+@num2)                                --scalar functions using multiple parameters--
end


select dbo.Addition(10,20);


create function MyMessage(@age int)
returns varchar(30)
as 
begin
	declare @str varchar(20)
	if(@age>=18)
	begin
		set @str='Elegible to vote'
	end
	else
	begin
		set @str='not eligible to vote'
    end
	return @str
end

select dbo.MyMessage(20);




create function MyDate()
returns datetime
as
begin
	return getdate()                      
end


select dbo.MyDate();

-----------------------------------------------------inline table value function---------------------------------------------------

use demo;

select * from Employee

create function MyFunction()
returns table                                        --without parameter--
as
return(select * from Employee)



select * from MyFunction();            --executing Inline table function--


create function GetSalary(@salary int)
returns table
as
return(select * from Employee where Employee_salary>=@salary)                --With single parameter--


select * from GetSalary(10000);

--------------------------Multi statement table value function----------------------

create function myTableFunction(@salary int)
returns @myTable table(Emp_Id int,Emp_name varchar(30),Emp_salary int)
as
begin
  insert into @myTable
  select Employee_Id,Employee_name,Employee_salary from Employee where Employee_salary=@salary

  return
end


select * from [dbo].[myTableFunction](20000                   --executing multi statement table valued function--
