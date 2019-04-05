create table [dbo].[Region] (
[Suburb_name] nvarchar(50),
[Region_name] nvarchar(50),
[Area_type] nvarchar(max),
PRIMARY KEY (Suburb_name) );

bulk insert [dbo].[Region]
from 'C:\Users\User\Desktop\Data\Regional.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[User_Current_Location] (
[Time] datetime not null,
[Latitude] nvarchar(max),
[Longitude] nvarchar(max),
[Filter_1] nvarchar(max) ,
[Filter_2] nvarchar(max) ,
[Filter_3] nvarchar(max) ,
[Filter_4] nvarchar(max) ,
[Filter_5] nvarchar(max) ,
[Filter_6] nvarchar(max) ,
constraint chk_filter1 check ( Filter_1 = 'Rent' or Filter_1 = 'None'),
constraint chk_filter2 check ( Filter_2 = 'Jobs' or Filter_2 = 'None'),
constraint chk_filter3 check ( Filter_3 = 'Hospitals' or Filter_3 = 'None'),
constraint chk_filter4 check ( Filter_4 = 'Parks' or Filter_4 = 'None'),
constraint chk_filter5 check ( Filter_5 = 'Crime' or Filter_5 = 'None'),
constraint chk_filter6 check ( Filter_6 = 'Colleges' or Filter_6 = 'None'),
primary key (Time)
);

create table [dbo].[Jobs] (
[Job_id] int,
[Area_type] nvarchar(max),
[Region_name] nvarchar(50),
[Suburb_name] nvarchar(50),
[Total] nvarchar(max),
PRIMARY KEY (Job_id),
foreign key(Suburb_name) references Region(Suburb_name));

bulk insert [dbo].[Jobs]
from 'C:\Users\User\Desktop\Data\Employment.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[Rent] (
[Rent_id] nvarchar(50),
[Suburb_name] nvarchar(50),
[unit_type] nvarchar(max),
[price] nvarchar(max),
[year] nvarchar(max),
[month] nvarchar(max),
PRIMARY KEY (Rent_id),
foreign key(Suburb_name) references Region(Suburb_name));

drop table dbo.Rent;

bulk insert [dbo].[Rent]
from 'C:\Users\User\Desktop\Data\Rent_New.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[Crimes] (
[Crime_id] int,
[Year] int,
[Police_region] nvarchar(max),
[Police_area] nvarchar(max), 
[Suburb_name] nvarchar(50),
[CSA_Offence_Division] nvarchar(max),
[CSA_Offence_Subdivision] nvarchar(max),
[CSA_Offence_Group] nvarchar(max),
[Offence_Count] nvarchar(max),
[LGA_ERP] nvarchar(max),
[Victorian_ERP] nvarchar(max),
[Region_name] nvarchar(max),
[Area_type] nvarchar(max),
PRIMARY KEY (Crime_id),
foreign key(Suburb_name) references Region(Suburb_name));

drop table dbo.Crimes;

bulk insert [dbo].[Crimes]
from 'C:\Users\User\Desktop\Data\Crime.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[Hospital] (
[Hospital_id] int,
[Hospital_name] nvarchar(max),
[Type] nvarchar(max),
[Suburb_name] nvarchar(50),
[Postcode] nvarchar(max),
[Region_name] nvarchar(max),
primary key (Hospital_id),
foreign key(Suburb_name) references Region(Suburb_name));

drop table dbo.Hospital;

bulk insert [dbo].[Hospital]
from 'C:\Users\User\Desktop\Data\HOSPITALS.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[Training_Institutions] (
[College_id] int,
[Region_name] nvarchar(max),
[Suburb_name] nvarchar(50),
[Institution_name] nvarchar(max),
[Address] nvarchar(max),
[City] nvarchar(max),
[Latitude] nvarchar(max),
[Longitude] nvarchar(max),
[Area_type] nvarchar(max),
primary key (college_id),
foreign key(Suburb_name) references Region(Suburb_name));

drop table dbo.Training_Institutions;

bulk insert [dbo].[Training_Institutions]
from 'C:\Users\User\Desktop\Data\College.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

create table [dbo].[Park] (
[Park_id] int,
[name] nvarchar(200),
[Suburb_name] nvarchar(50),
[Latitude] nvarchar(max),
[Longitude] nvarchar(max),
primary key (Park_id),
foreign key(Suburb_name) references Region(Suburb_name));


bulk insert [dbo].[Park]
from 'C:\Users\User\Desktop\Data\Park.csv'
with (fieldterminator = ',', rowterminator = '\n')
go

