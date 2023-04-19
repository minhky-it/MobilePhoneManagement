CREATE DATABASE MOBILEMANAGEMENT;
GO
USE MOBILEMANAGEMENT;
GO

CREATE TABLE Staff(
	staffID varchar(50) PRIMARY KEY,
	fullname varchar(255),
	email varchar(255),
	phone varchar(40),
	address varchar(255),
	role varchar(100)
)

CREATE TABLE Account(
	accountID varchar(50) PRIMARY KEY,
	status varchar(50),
	username varchar(50),
	password varchar(50),
	role varchar(50)
)

CREATE TABLE Product(
	ProductID varchar(50) PRIMARY KEY,
	vendorID varchar(50) REFERENCES Vendor(vendorID),
	name varchar(255),
	quantity int,
	type varchar(50),
	price float,
	color varchar(50),
)

CREATE TABLE WarehouseReceipt(
	receiptID varchar(50) PRIMARY KEY,
	nameDeliver varchar(50),
	circular varchar(100),
	inputDate Date,
	inputStock varchar(255),
	location varchar(255),
	productID varchar(50),
	staffID varchar(50),
	total float,
	FOREIGN KEY (productID) REFERENCES Product (ProductID),
	FOREIGN KEY (staffID) REFERENCES Staff (staffID)
)

CREATE TABLE Customer(
	customerID varchar(50) PRIMARY KEY,
	fullname varchar(255),
	email varchar(255),
	phone varchar(255),
	accountID varchar(50),
	paymentInfo varchar(255),
	FOREIGN KEY (accountID) REFERENCES Account (accountID)
)

CREATE TABLE Bill(
	billID varchar(50) PRIMARY KEY,
	customerID varchar(50),
	productID varchar(50),
	total float,
	outDate Date,
	FOREIGN KEY (customerID) REFERENCES Customer (customerID),
	FOREIGN KEY (productID) REFERENCES Product (ProductID)
)

CREATE TABLE DetailReceipt(
	billID varchar(50),
	staffID varchar(50),
	quantity int,
	total float,
	PRIMARY KEY (billID, staffID),
	FOREIGN KEY (billID) REFERENCES Bill (billID),
	FOREIGN KEY (staffID) REFERENCES Staff (staffID)
)

CREATE TABLE OrderForm(
	orderID varchar(50) PRIMARY KEY,
	vendorID varchar(50),
	staffID varchar(50),
	productID varchar(50),
	city varchar(50),
	deliveryDate Date,
	FOREIGN KEY (staffID) REFERENCES Staff (staffID),
	FOREIGN KEY (productID) REFERENCES Product (ProductID)
)

CREATE TABLE Vendor(
	vendorID varchar(50) PRIMARY KEY,
	vendorName varchar(255),
	phone varchar(50),
	email varchar(50),
)
GO
INSERT INTO Vendor VALUES('tgdd', 'The gioi di dong', '0123457', 'thegioididong@tgdd.com.vn')
UPDATE Vendor SET vendorName = 'The gioi di dong' WHERE vendorID = 'tgdd';  
INSERT INTO Product VALUES('P001','tgdd','Iphone 11 64GB',20,'Iphone',6400000,'Black'),
						  ('P002','tgdd','Iphone 11 64GB Pro Max',15,'Iphone',8400000,'Blue'),
						  ('P003','tgdd','Iphone 11 128GB',20,'Iphone',9000000,'Black'),
						  ('P004','tgdd','Iphone 11 128GB Pro Max',15,'Iphone',10000000,'Yellow'),
						  ('P005','tgdd','Iphone 11 256GB',20,'Iphone',11300000,'Blue'),
						  ('P006','tgdd','Iphone 11 256GB Pro Max',15,'Iphone',12400000,'Purple'),
						  ('P007','tgdd','Iphone 12 128GB',20,'Iphone',15000000,'Yellow'),
						  ('P008','tgdd','Iphone 12 128GB Pro Max',15,'Iphone',16400000,'Purple'),
						  ('P009','tgdd','Iphone 12 256GB',20,'Iphone',17000000,'Blue'),
						  ('P010','tgdd','Iphone 12 256GB Pro Max',15,'Iphone',18700000,'Yellow'),
						  ('P011','tgdd','Iphone 13 128GB',20,'Iphone',20000000,'Purple'),
						  ('P012','tgdd','Iphone 13 128GB Pro Max',15,'Iphone',21300000,''),
						  ('P013','tgdd','Iphone 13 256GB',20,'Iphone',22000000,'Yellow'),
						  ('P014','tgdd','Iphone 13 256GB Pro Max',15,'Iphone',23800000,'Blue'),
						  ('P015','tgdd','Iphone 13 512GB',20,'Iphone',25500000,'Black'),
						  ('P016','tgdd','Iphone 13 512GB Pro Max',15,'Iphone',26000000,'Red'),
						  ('P017','tgdd','Iphone 14 128GB',20,'Iphone',24000000,'Purple'),
						  ('P018','tgdd','Iphone 14 128GB Pro Max',15,'Iphone',25600000,'Yellow'),
						  ('P019','tgdd','Iphone 14 256GB',20,'Iphone',26500000,'Purple'),
						  ('P020','tgdd','Iphone 14 256GB Pro Max',15,'Iphone',27600000,'Red'),
						  ('P021','tgdd','Iphone 14 512GB',20,'Iphone',28500000,'Black'),
						  ('P022','tgdd','Iphone 14 512GB Pro Max',15,'Iphone',29100000,'Blue'),
						  ('P023','tgdd','Iphone 14 1TB',15,'Iphone',32000000,'Black')
GO