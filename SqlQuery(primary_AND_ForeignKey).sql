use demo;



truncate table Products;

create table Category(Category_Id int Primary key,Category_name varchar(30));

insert into Category values(1,'Chhocolate');
insert into Category values(2,'Chhocolateee');
insert into Category values(3,'ColdDrinks');
insert into Category values(4,'Snacksss');
insert into Category values(5,'Drinksss');

create table Products(Product_Id int Primary key,Product_name varchar(20),Category_Id int foreign key references Category(Category_Id)); /*Creating foreign key references to category table to link 2 tables*/

insert into Products values(1,'Kitkat',1);
insert into Products values(2,'DairyMilk',1);
insert into Products values(3,'Cocola',2);
insert into Products values(4,'Snacks',3);
insert into Products values(5,'Drinks',4);

alter table Products drop constraint [FK__Products__Catego__5EBF139D];       /* to drop foreign key constraint*/

alter table Products add foreign key (Category_Id) references Category(Category_Id);   /* adding foreign key in the existin table*/

select * from Products;

select * from Category;
