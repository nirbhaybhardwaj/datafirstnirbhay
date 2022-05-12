create database Manish_Saini
use Manish_Saini
create table Frinds_Details(Id int primary key,Name varchar(30),Contect_N bigint, City varchar(50),Salary bigint)
insert into Frinds_Details values(101,'Manish',7906494033,'Noida',25000),
                                 (102,'Rahul',9634042711,'Moradabad',18000),
								 (103,'Sonu',7248464713,'Moradabad',35000),
								 (104,'Puspendra',9012455785,'Gugrat',15000),
								 (105,'Tejpal',7817254623,'Noida',20000)


alter table Frinds_Details add Department varchar(50)
update Frinds_Details set Department='IT' where Id=101
update Frinds_Details set Department='Civil' where Id=102
update Frinds_Details set Department='OPD' where Id=103
update Frinds_Details set Department='Electircal' where Id=104
update Frinds_Details set Department='Electircal' where Id=105

select*from Frinds_Details where Name='Manish'And City='Noida'
select*from Frinds_Details where City='Moradabad' or Contect_N=9634042711
select*from Frinds_Details where Id Between 101 and 103
select*from Frinds_Details where Not City='Moradabad'


drop table My_Details;
create table My_Details(Id int, Name varchar(20),Salary bigint,Dept_Id int) 
insert into My_Details values(201,'Manish',30000,105),
                             ( 202,'Abhishek',40000,107),
							 ( 203,'Anil',25000,104),
                             ( 204,'Aman',30000,106),
							 ( 205,'Rahul',25000,102)

select*from Frinds_Details
select*from My_Details

select f.Name,f.Salary, m.Dept_Id,m.Id
From Frinds_Details f
inner join My_Details m
on f.Id=m.Dept_Id;

select f.Name,f.Salary, m.Dept_Id,m.Id
From Frinds_Details f
Right join My_Details m
on f.Id=m.Dept_Id;

select f.Name,f.Salary, m.Dept_Id,m.Id
From Frinds_Details f
Left join My_Details m
on f.Id=m.Dept_Id;

select f.Name,f.Salary, m.Dept_Id,m.Id
From Frinds_Details f
full join My_Details m
on f.Id=m.Dept_Id;

select f.Name,f.Salary, m.Dept_Id,m.Id
From Frinds_Details f , My_Details m
where f.Id<>m.Id
and f.City=m.Name
order by f.City;





