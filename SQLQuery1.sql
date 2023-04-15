CREATE DATABASE MOBILEMANAGEMENT;
USE MOBILEMANAGEMENT;

CREATE TABLE Product(
	ProductID varchar(50),
	name varchar(255),
	quantity int,
	type varchar(50),
	price float,
	color varchar(50),
)

CREATE TABLE WarehouseReceipt(
	receiptID varchar(50),
	nameDeliver varchar(50),
	inputDate Date,
	location varchar(255),
	inputStock varchar(255),
	productID varchar(50),
	staffID varchar(50),
	total float
)

CREATE TABLE Staff(
	staffID varchar(50),
	fullname varchar(255),
	email varchar(255),
	phone varchar(40),
	address varchar(255),
	role varchar(100)
)

CREATE TABLE Account(
	accountID varchar(50),
	status varchar(50),
	username varchar(50),
	password varchar(50),
	role varchar(50)
)

CREATE TABLE Customer(
	customerID varchar(50),
	fullname varchar(255),
	email varchar(255),
	phone varchar(255),
	accountID varchar(50),
	paymentInfo varchar(255)
)

CREATE TABLE OrderForm(
	orderID varchar(50),
	vendorID varchar(50),
	staffID varchar(50),
	productID varchar(50),
	city varchar(50),
	deliveryDate Date
)

CREATE TABLE Bill(
	billID varchar(50),
	customerID varchar(50),
	productID varchar(50),
	total float,
	outDate Date
)

CREATE TABLE DetailReceipt(
	billID varchar(50),
	staffID varchar(50),
	quantity int,
	total float,
)

