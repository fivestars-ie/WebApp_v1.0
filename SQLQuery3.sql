drop table [dbo].[Rent_int]

create table [dbo].[Rent_int] (
[Rent_id] nvarchar(50),
[Suburb_name] nvarchar(50),
[unit_type] nvarchar(max),
[price] int,
[year] nvarchar(max),
[month] nvarchar(max),
PRIMARY KEY (Rent_id),
foreign key(Suburb_name) references Region(Suburb_name));

insert into [dbo].[Rent_int]
select * from [dbo].[Rent] where year > 2016 and price != 'NA';

update [dbo].[Rent_int] set unit_type = Left(unit_type,1);
update [dbo].[Rent_int] set price = price/unit_type;

Alter table [dbo].[Park] add [count] int;

Alter table [dbo].[Park] drop [count];

Alter table [dbo].[Park] drop column [count];

update [dbo].[Park] set [count] = 0;

update [dbo].[Park] set [count] = (Select COUNT(Suburb_name) from [dbo].[Park]);

update [dbo].[Park] set [count] = 
(Select COUNT(distinct Suburb_name) from [dbo].[Park]);

