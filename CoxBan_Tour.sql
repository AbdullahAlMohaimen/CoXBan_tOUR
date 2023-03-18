create database CoxBan_Tour;
use CoxBan_Tour;

create table Category(
	Category_ID int identity(1,1) not null Primary Key,
	Category_Name varchar(20) not null,
	Category_Image image not null,
);


create table Vehicle(
	Vehicle_ID int identity(40001,1) not null Primary Key,
	Category_ID int not null Foreign Key References Category(Category_ID),
	Vehicle_Name varchar(50) not null,
	Vehicle_LicenseNo varchar(50) not null,
	Vehicle_TotalSeat int not null,
	Vehicle_RentPrice float not null,
	Vehicle_Status varchar(20) not null default 'Available',
	Vehicle_Image Image not null,
);

create table Resort(
	Resort_ID int identity(50001,1) not null Primary Key,
	Category_ID int not null Foreign Key References Category(Category_ID),
	Resort_Name varchar(50) not null,
	Resort_Location varchar(100) not null,
	Resort_Quality varchar(10) not null,
	Resort_Description varchar(255) not null,
	Resort_ContactNumber varchar(20) not null,
	Resort_Image Image not null,
);

create table ResortRoom(
	ResortRoom_ID int identity(1,1) not null Primary Key,
	Resort_ID int not null Foreign Key References Resort(Resort_ID),
	ResortRoom_Category varchar(20),
	ResortRoom_Number int not null,
	ResortRoom_Price float not null,
	ResortRoom_FirstImage image,
	ResortRoom_SecondImage image,
	ResortRoom_ThirdImage image,
);

create table TouristPlace(
	TouristPlace_ID int identity(1001,1) not null Primary Key,
	TouristPlace_Name varchar(50) not null,
	TouristPlace_District varchar(15) not null,
	TouristPLace_Location varchar(100) not null,
	TouristPlace_Description varchar(255) not null,
	TouristPlace_FirstImage Image not null,
	TouristPlace_SecondImage Image,
	TouristPlace_ThirdImage Image,
);

create table Customer(
	Customer_ID int identity(5001,1) not null primary key,
	Customer_Name varchar(100) not null,
	Customer_Gender varchar(10) not null,
	Customer_Religion varchar(10) not null,
	Customer_NationalID varchar(25) not null,
	Customer_Address varchar(100) not null,
	Customer_Email varchar(50) not null,
	Customer_PhoneNo varchar(20) not null,
	Customer_Password varchar(50) not null,
	Customer_Image image,
);

insert into Customer(Customer_Name,Customer_Gender,Customer_Religion,Customer_NationalID,Customer_Address,Customer_Email,Customer_PhoneNo,Customer_Password,Customer_Image)
values('Abdullah Al Mohaimen','Male','Islam','0152134','Arichpur, Tongi, Gazipur','mohaimenhasan7@gmail.com','01521209559','mohaimen01521','../add.png');

select * from Customer;

create table Admin(
	Admin_ID int identity(10001,1) not null primary key,
	Admin_Name varchar(100) not null,
	Admin_Gender varchar(10) not null,
	Admin_Religion varchar(10) not null,
	Admin_DOB date not null,
	Admin_NationalID varchar(25) not null,
	Admin_PresentAddress varchar(100) not null,
	Admin_PermanentAddress varchar(100) not null,
	Admin_Email varchar(50) not null,
	Admin_PhoneNo varchar(20) not null,
	Admin_Password varchar(50) not null,
	Admin_Image image,
);

create table CustomerStatus(
	Status_ID int identity(1,1) not null Primary Key,
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	Status_Date date not null,
	Status_Time time not null,
	Status_Image image,
	Status_Description varchar(255) not null,
);


create table AdminNews(
	News_ID int identity(1,1) not null Primary Key,
	Admin_ID int not null Foreign Key References Admin(Admin_ID),
	News_Date date not null,
	News_Time time not null,
	News_Image image not null,
	News_Description varchar(255),
);


create table ContactUs(
	Contact_ID int identity(1,1) not null Primary Key,
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	Contact_Message varchar(255),
);


create table VehicleOrder(
	vOrder_ID int identity(1,1) not null Primary Key,
	Vehicle_ID int not null Foreign Key References Vehicle(Vehicle_ID),
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	vOrder_Date Date not null,
	vOrder_Time time not null,
	vOrder_FromDate date not null,
	vOrder_ToDate date not null,
	vOrder_TotalDays int,
	vOrder_FromLocation varchar(50),
	vOrder_ToLocation varchar(50),
	vOrder_Vat int,
	vOrder_Discount int,
	vOrder_TotalCost float not null,
);


create table ResortOrder(
	rOrder_ID int identity(1,1) not null Primary Key,
	ResortRoom_ID int not null Foreign Key References ResortRoom(ResortRoom_ID),
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	rOrder_Date Date not null,
	rOrder_Time time not null,
	rOrder_FromDate date not null,
	rOrder_ToDate date not null,
	rOrder_TotalDays int,
	rOrder_Vat int,
	rOrder_Discount int,
	rOrder_TotalCost float not null,
);

create table VehiclePayment(
	vPayment_ID int identity(1,1) not null Primary Key,
	vOrder_ID int not null Foreign Key References VehicleOrder(vOrder_ID),
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	vPayment_Date date,
	vPayment_time time,
	vPayment_TotalCost float,
	vPayment_Due float,
	vPayment_Status float,
);

create table ResortPayment(
	rPayment_ID int identity(1,1) not null Primary Key,
	rOrder_ID int not null Foreign Key References ResortOrder(rOrder_ID),
	Customer_ID int not null Foreign Key References Customer(Customer_ID),
	rPayment_Date date,
	rPayment_time time,
	rPayment_TotalCost float,
	rPayment_Due float,
	rPayment_Status float,
);