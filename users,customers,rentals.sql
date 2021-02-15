CREATE TABLE [dbo].[Users] (
    [UserId]       INT          IDENTITY (1, 1) primary key NOT NULL,
    [FirstName] nvarchar(50) ,
    [LastName] nvarchar(50) ,
    [Email] nvarchar(50) ,
    [Password] nvarchar(50)
    )



    CREATE TABLE [dbo].[Customers] (
    CustomerId int identity(1,1) primary key not null,
    [UserId]       INT foreign key references Users (UserId) ,
    [CompanyName] nvarchar(50) 
    )

    create table Rentals (
    RentalId int identity(1,1) primary key not null,
    CarId int not null foreign key references Cars(CarId),
    CustomerId int not null foreign key references Customers(CustomerId),
    RentDate datetime ,
    ReturnDate datetime null

    )
 
 Insert Into Users(
FirstName,
LastName,
EMail,
Password) Values
('Merve','Can','mervecn172@gmail.com','1234'),
('Melek','Şahin','meleksahin@gmail.com','12345'),
('Süm','Yılmaz','sumyilmaz@gmail.com','123'),
('Gürrü','Kal','gurrukal@gmail.com','123456')


INSERT INTO dbo.Customers
(
    UserId,   
    CompanyName
)
VALUES
(1,'Opel Şirket'),
(2,'Bmw Şirket'),
(3,'Renault Şirket'),
(4,'Opel Şirket')

Insert Into Rentals
(
CarId,
CustomerId,
RentDate,
ReturnDate) values (1,2,'03/21/2020','03/22/2020'),
(2,3,'02/14/2021','02/16/2021')