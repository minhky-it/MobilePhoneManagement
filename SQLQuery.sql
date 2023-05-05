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

CREATE TABLE Vendor(
	vendorID varchar(50) PRIMARY KEY,
	vendorName varchar(255),
	phone varchar(50),
	email varchar(50),
)

CREATE TABLE Product(
	ProductID varchar(50) PRIMARY KEY,
	vendorID varchar(50),
	name varchar(255),
	quantity int,
	type varchar(50),
	price float,
	color varchar(50),
	FOREIGN KEY (vendorID) REFERENCES Vendor(vendorID)
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
	total float,
	createDate Date,
	address varchar(255),
	email varchar(255),
	phone varchar(32),
	fullname varchar(255),
)

CREATE TABLE DetailReceipt(
	billID varchar(50),
	productID varchar(50),
	quantity int,
	PRIMARY KEY (billID, productID),
	FOREIGN KEY (billID) REFERENCES Bill (billID),
	FOREIGN KEY (productID) REFERENCES Product (productID),
)

CREATE TABLE OrderForm(
	orderID varchar(50) PRIMARY KEY,
	addrress varchar(50),
	statusPayment varchar(20),
	status varchar(20),
	deliveryDate Date
)

CREATE TABLE CART(
	CustomerID varchar(50),
	productID varchar(50),
<<<<<<< HEAD
	quantity int,
=======
	quantity int
>>>>>>> 6b1874a9c13a7093a1fbcd9acbb4bd8484c9dbff
	price int,
	PRIMARY KEY (CustomerID, productID),
	FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	FOREIGN KEY (productID) REFERENCES Product (productID)
)

CREATE TABLE DetailOrderForm (
	orderID varchar(50),
	vendorID varchar(50),
	staffID varchar(50),
	productID varchar(50),
	quantity int,
	PRIMARY KEY (orderID, vendorID, productID),
	FOREIGN KEY (vendorID) REFERENCES Vendor (vendorID),
	FOREIGN KEY (staffID) REFERENCES Staff (staffID),
	FOREIGN KEY (productID) REFERENCES Product (productID)
)
GO

INSERT INTO OrderForm VALUES ('O001','District 7','Completly payment','Completly order','02-23-2023'),
							 ('O002','District 4','Completly payment','Completly order','02-20-2023'),
							 ('O003','District 8','Completly payment','Completly order','02-21-2023');
							
INSERT INTO Vendor VALUES('TGDD', 'TheGioiDiDong', '0126985478', 'thegioididong@tgdd.com.vn'),
						 ('CPS', 'CellphoneS - Mobile Phone', '0424234614', 'cellphones@gmail.com.vn')

INSERT INTO Staff VALUES('S001', 'Tran Gia Thieu', 'giathieu@tdtu.com', '0121134124', 'District 4', 'waiter'),
						('S002', 'Tran Quoc Dung', 'quocdung@tdtu.com', '0234134134', 'District 5', 'waiter'),
						('S003', 'Le Thi Hanh', 'hanhle@tdtu.com', '0834154189', 'District 1', 'waiter')

INSERT INTO Product VALUES('P001','CPS','Iphone 11 64GB',20,'Iphone',6400000,'Black'),
						  ('P002','CPS','Iphone 11 64GB Pro Max',15,'Iphone',8400000,'Blue'),
						  ('P003','CPS','Iphone 11 128GB',20,'Iphone',9000000,'Black'),
						  ('P004','CPS','Iphone 11 128GB Pro Max',15,'Iphone',10000000,'Yellow'),
						  ('P005','CPS','Iphone 11 256GB',20,'Iphone',11300000,'Blue'),
						  ('P006','CPS','Iphone 11 256GB Pro Max',15,'Iphone',12400000,'Purple'),
						  ('P007','TGDD','Iphone 12 128GB',20,'Iphone',15000000,'Yellow'),
						  ('P008','TGDD','Iphone 12 128GB Pro Max',15,'Iphone',16400000,'Purple'),
						  ('P009','TGDD','Iphone 12 256GB',20,'Iphone',17000000,'Blue'),
						  ('P010','TGDD','Iphone 12 256GB Pro Max',15,'Iphone',18700000,'Yellow'),
						  ('P011','CPS','Iphone 13 128GB',20,'Iphone',20000000,'Purple'),
						  ('P012','CPS','Iphone 13 128GB Pro Max',15,'Iphone',21300000,'Black'),
						  ('P013','CPS','Iphone 13 256GB',20,'Iphone',22000000,'Yellow'),
						  ('P014','CPS','Iphone 13 256GB Pro Max',15,'Iphone',23800000,'Blue'),
						  ('P015','CPS','Iphone 13 512GB',20,'Iphone',25500000,'Black'),
						  ('P016','CPS','Iphone 13 512GB Pro Max',15,'Iphone',26000000,'Red'),
						  ('P017','TGDD','Iphone 14 128GB',20,'Iphone',24000000,'Purple'),
						  ('P018','TGDD','Iphone 14 128GB Pro Max',15,'Iphone',25600000,'Yellow'),
						  ('P019','TGDD','Iphone 14 256GB',20,'Iphone',26500000,'Purple'),
						  ('P020','TGDD','Iphone 14 256GB Pro Max',15,'Iphone',27600000,'Red'),
						  ('P021','TGDD','Iphone 14 512GB',20,'Iphone',28500000,'Black'),
						  ('P022','TGDD','Iphone 14 512GB Pro Max',15,'Iphone',29100000,'Blue'),
						  ('P023','TGDD','Iphone 14 1TB',15,'Iphone',32000000,'Black')

INSERT INTO DetailOrderForm VALUES ('O001','CPS','S001','P001',10),
								   ('O001','CPS','S001','P002',20),
								   ('O001','CPS','S001','P003',20),
								   ('O001','CPS','S001','P005',20),
								   ('O001','CPS','S001','P008',10),
								   ('O001','CPS','S001','P012',20),
								   ('O001','CPS','S001','P013',10),
								   ('O001','CPS','S001','P014',20),
								   ('O001','CPS','S001','P015',10),
								   ('O002','CPS','S002','P004',10),
								   ('O002','CPS','S002','P006',10),
								   ('O002','TGDD','S002','P007',15),
								   ('O002','CPS','S002','P016',10),
								   ('O002','TGDD','S002','P017',10),
								   ('O002','TGDD','S002','P018',15),
								   ('O002','TGDD','S002','P019',10),
								   ('O002','TGDD','S002','P020',10),
								   ('O003','TGDD','S003','P009',10),
								   ('O003','TGDD','S003','P010',10),
								   ('O003','TGDD','S003','P011',10),
								   ('O003','TGDD','S003','P021',10),
								   ('O003','TGDD','S003','P022',10),
								   ('O003','TGDD','S003','P023',15)

INSERT INTO Account VALUES ('A001', 'Activated', 'dat2302', '123456', 'admin'),
						   ('A002', 'Activated', 'kyvt03', '123456', 'admin'),
						   ('A003', 'Activated', 'cus001', '123456', 'customer')
						   
INSERT INTO Customer VALUES ('C001', 'Customer01', 'example@gmail.com', '0123456789', 'A003','VNPAY')

GO
--SELECT * FROM OrderForm
--SELECT * FROM DetailOrderForm WHERE orderID = 'O001'
--SELECT P.* FROM Product P INNER JOIN DetailOrderForm D ON P.productID = D.productID WHERE D.orderID = 'O001'