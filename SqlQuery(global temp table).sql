create table ##StudentInfo(StudentId int,StudentName varchar(30),StudentAge int);   --creating global temp table--

insert into ##StudentInfo values(111,'Harshika',18);		--inserting data inside global table
insert into ##StudentInfo values(112,'Pavit',20);
insert into ##StudentInfo values(113,'Sona',21);
insert into ##StudentInfo values(114,'Priyanka',25);
insert into ##StudentInfo values(115,'Swapnil',23);


select * from ##StudentInfo;                  --to see the data of global table--

--global table gets deleted automatically when the connection is closed--