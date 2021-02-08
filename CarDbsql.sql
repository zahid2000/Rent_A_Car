 
  CREATE TABLE [dbo].[CarBrands]
(
	[CarBrandId] INT NOT NULL PRIMARY KEY identity, 
    [Brand] NVARCHAR(50) NULL
)
 CREATE TABLE [dbo].[CarColors]
(
	[CarColorId] INT NOT NULL PRIMARY KEY identity, 
    [Color] NVARCHAR(50) NULL
)
 CREATE TABLE [dbo].[Cars] (
    [CarId]       INT          NOT NULL identity,
    [BrandId]     INT          NOT NULL,
    [ColorId]    INT          NOT NULL,
    [ModelYear]   INT          NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] TEXT         NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_ToTable] FOREIGN KEY ([BrandId]) REFERENCES [CarBrands]([CarBrandId]), 
    CONSTRAINT [FK_Cars_ToTable_1] FOREIGN KEY ([ColorId]) REFERENCES [CarColors]([CarColorid])
);
 insert into CarBrands ([Brand]) values ('Hunday')
 insert into CarBrands ([Brand]) values ('BMW')
 insert into CarBrands ([Brand]) values ('Mercedes')
 insert into CarBrands ([Brand]) values ('Lada')
 insert into CarBrands ([Brand]) values ('Porche')
 insert into CarBrands ([Brand]) values ('Nissan')
 insert into CarBrands ([Brand]) values ('Honda')
 insert into CarBrands ([Brand]) values ('Toyota')

  insert into CarColors ([Color]) values ('Yellow')
 insert into CarColors ([Color]) values ('Green')
 insert into CarColors ([Color]) values ('Red')
 insert into CarColors ([Color]) values ('Blue')
 insert into CarColors ([Color]) values ('Orange')
 insert into CarColors ([Color]) values ('White')
 insert into CarColors ([Color]) values ('Black')

insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('1','4','2020','12000','Hunday Sonata')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('2','2','2017','23000','BMW X7')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('1','6','2021','23400','Hunday H2 Sut')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('4','7','2020','11000','Priora')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('3','5','2018','32000','Tourenwagen')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('6','4','2015','17500','Nissan Kisks')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('5','6','2020','83000','Porche Panamera')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('7','3','2015','44000','Honda Odysses')
 insert into Cars ([BrandId],[ColorId],[ModelYear],[DailyPrice],[Description]) values ('8','5','2019','71000','Land Cuiser 2000/V8')
