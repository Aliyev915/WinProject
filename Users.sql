use UsersDb

create table Users(
Id int identity primary key,
Fullname nvarchar(50) not null,
Email nvarchar(200) unique,
[Password] nvarchar(250) not null,
IsAdmin bit default 0 not null,
IsActivated bit default 0 not null,
IsDeleted bit default 1 not null
)


create table MedicineTypes(
Id int primary key identity,
typeName nvarchar(20) not null,
Deleted bit default 0 not null
)

create table Medicines(
Id int primary key identity,
[Name] nvarchar(50) not null,
Price decimal(10,2) not null,
Quantity int not null,
Deleted bit default 0 not null,
TypeId int references MedicineTypes(Id)
)


