create procedure spGetEmpInfo
as
begin

select Employee_city,Employee_name,Employee_Id from Employee       --SP Example--
where Employee_salary>20000;

end;

execute spGetEmpInfo;


create procedure spEmployeeId
@id int								                       --sp with single parameter
as
begin                                                         

select * from Employee where Employee_Id=@id 

end;

execute spEmployeeId 114;                      --executing procedure with Id present in employee table that details are needed --



 create procedure spMyEmployeeDetails
@id int,
@name varchar(30)                              --creating procedure with multile parameters---

as
begin

select * from Employee where Employee_Id=@id and Employee_name=@name

end;


exec spMyEmployeeDetails 112,'Shweta';

sp_helptext spMyEmployeeDetails;


alter Procedure spMyEmployeeDetails
@id int,
@name varchar(30)                                        --altering procedure--
with encryption
as
begin

select Employee_city,Employee_salary,Employee_name from Employee where Employee_Id=@id and Employee_name=@name

end;

exec spMyEmployeeDetails 112,'Shweta';


------------------------------------

sp_helptext spMyEmployeeDetails;

---------------------------------------------

alter Procedure spMyEmployeeDetails
@id int,
@name varchar(30)                                        --altering procedure and making it encrypted--
with encryption
as
begin

select Employee_city,Employee_salary,Employee_name from Employee where Employee_Id=@id and Employee_name=@name

end

sp_helptext spMyEmployeeDetails;                       --to see if it is encrypted---


drop procedure spMyEmployeeDetails;                    -- to delete SP----

sp_helptext spMyEmployeeDetails;







