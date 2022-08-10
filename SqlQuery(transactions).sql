select * from Employee


update Employee set Employee_city='Chennai' where Employee_Id=112;        --implicit transaction--    


begin transaction
update Employee set Employee_city='Chennai' where Employee_Id=112;          --explicit transaction

commit transaction;                                                         --saving the changes permanently--

begin transaction

update Employee set Employee_name='Priyaaaaa' where Employee_Id=111;
delete from Employee where Employee_Id=115;

rollback transaction                    --undo the changes--

commit transaction

