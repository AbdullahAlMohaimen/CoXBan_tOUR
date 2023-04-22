drop database CoxBan_Tour;
create database CoxBan_Tour;
use CoxBan_Tour;

create table Category(
	CategoryID int identity(1,1) not null Primary Key,
	CategoryNo as ('CA' + right('1234' + cast(CategoryID as varchar(10)),10)) persisted,
	CategoryName varchar(20) not null,
	CategoryImage image null,
);
insert into Category(CategoryName) values('Bus');
select * from Category;

Select CategoryName,VehicleName,CategoryNo,VehicleNo,VDistrict,VehicleTotalSeat,VehicleRentPrice from Category c join Vehicle v on c.CategoryID=v.CategoryID
Select CategoryName from Category

create table Vehicle(
	VehicleID int identity(1,1) not null Primary Key,
	VehicleNo as ('VL' + right('1234' + cast(VehicleID as varchar(10)),10)) persisted,
	CategoryID int not null Foreign Key References Category(CategoryID),
	VehicleName varchar(50) not null,
	VDistrict varchar(20) not null,
	VehicleLicenseNo varchar(50) not null,
	VehicleTotalSeat int not null,
	VehicleRentPrice float not null,
	VehicleStatus varchar(20) not null default 'Available',
	VehicleImage Image null,
);

create table Resort(
	ResortID int identity(1,1) not null Primary Key,
	ResortNo as ('RT' + right('1234' + cast(ResortID as varchar(10)),10)) persisted,
	CategoryID int not null Foreign Key References Category(CategoryID),
	ResortName varchar(50) not null,
	RDistrict varchar(20) not null,
	ResortLocation varchar(100) not null,
	ResortTotalRoom int not null,
	ResortQuality varchar(50) not null,
	ResortDescription varchar(255) not null,
	ResortContactNumber varchar(20) not null,
	ResortImage Image null,
);

select * from Resort;


create table ResortRoom(
	ResortRoomID int identity(1,1) not null Primary Key,
	ResortID int not null Foreign Key References Resort(ResortID),
	ResortRoomNo as ('RM' + right('1234' + cast(ResortID as varchar(10)),10)) persisted,
	ResortRoomCategory varchar(20),
	ResortRoomPrice float not null,
	ResortRoomFirstImage image null,
	ResortRoomSecondImage image null,
	ResortRoomThirdImage image null,
);

create table TouristPlace(
	TouristPlaceID int identity(1,1) not null Primary Key,
	TouristPlaceNo as ('TP' + right('1234' + cast(TouristPlaceID as varchar(10)),10)) persisted,
	TouristPlaceName varchar(50) not null,
	TouristPlaceDistrict varchar(15) not null,
	TouristPLaceLocation varchar(100) not null,
	TouristPlaceDescription varchar(255) not null,
	TouristPlaceFirstImage Image null,
	TouristPlaceSecondImage Image null,
	TouristPlaceThirdImage Image null,
);

create table Customer(
	CustomerID int identity(1,1) not null primary key,
	CustomerNo as ('CU' + right('1234' + cast(CustomerID as varchar(10)),10)) persisted,
	CustomerName varchar(100) not null,
	CustomerGender varchar(10) not null,
	CustomerReligion varchar(10) not null,
	CustomerNationalID varchar(25) not null,
	CustomerAddress varchar(100) not null,
	CustomerEmail varchar(50) not null,
	CustomerPhoneNo varchar(20) not null,
	CustomerPassword varchar(50) not null,
	CustomerImage image null,
);

insert into Customer(CustomerName,CustomerGender,CustomerReligion,CustomerNationalID,CustomerAddress,CustomerEmail,CustomerPhoneNo,CustomerPassword,CustomerImage)
values('Abdullah Al Mohaimen','Male','Islam','0152134','Arichpur, Tongi, Gazipur','mohaimenhasan7@gmail.com','01521209559','mohaimen01521','../add.png');

select * from Customer;

create table Admin(
	AdminID int identity(1,1) not null primary key,
	AdminNo as ('AM' + right('1234' + cast(AdminID as varchar(10)),10)) persisted,
	AdminName varchar(100) not null,
	AdminGender varchar(10) not null,
	AdminReligion varchar(10) not null,
	AdminDOB date not null,
	AdminNationalID varchar(25) not null,
	AdminPresentAddress varchar(100) not null,
	AdminPermanentAddress varchar(100) not null,
	AdminEmail varchar(50) not null,
	AdminPhoneNo varchar(20) not null,
	AdminPassword varchar(50) not null,
	AdminImage image null,
);

insert into Admin(AdminName,AdminGender,AdminReligion,AdminDOB,AdminNationalID,AdminPresentAddress,AdminPermanentAddress,AdminEMail,AdminPhoneNo,AdminPassword,AdminImage)
values('Abdullah Al Mohaimen','Male','Islam','1997-08-02','0152134','Arichpur, Tongi, Gazipur','Porjana, Shahzadpur, Shirajganj','mohaimenhasan7@gmail.com','01521209559','mohaimen01521','../add.png');

select * from Admin;

create table CustomerStatus(
	StatusID int identity(1,1) not null Primary Key,
	CustomerID int not null Foreign Key References Customer(CustomerID),
	StatusDate date not null,
	StatusTime time not null,
	StatusImage image,
	StatusDescription varchar(255) not null,
);


create table AdminNews(
	NewsID int identity(1,1) not null Primary Key,
	NewsNo as ('NW' + right('1234' + cast(NewsID as varchar(10)),10)) persisted,
	AdminID int not null Foreign Key References Admin(AdminID),
	NewsDate date not null,
	NewsTime time not null,
	NewsImage image null,
	NewsDescription varchar(255),
);


create table ContactUs(
	ContactID int identity(1,1) not null Primary Key,
	ContactNo as ('CU' + right('1234' + cast(ContactID as varchar(10)),10)) persisted,
	CustomerID int not null Foreign Key References Customer(CustomerID),
	ContactMessage varchar(255),
);


create table VehicleOrder(
	vOrderID int identity(1,1) not null Primary Key,
	vOrderNo as ('VO' + right('1234' + cast(vOrderID as varchar(10)),10)) persisted,
	VehicleID int not null Foreign Key References Vehicle(VehicleID),
	CustomerID int not null Foreign Key References Customer(CustomerID),
	vOrderDate Date not null,
	vOrderTime time not null,
	vOrderFromDate date not null,
	vOrderToDate date not null,
	vOrderTotalDays int,
	vOrderFromLocation varchar(50),
	vOrderToLocation varchar(50),
	vOrderVat int,
	vOrderDiscount int,
	vOrderTotalCost float not null,
);


create table ResortOrder(
	rOrderID int identity(1,1) not null Primary Key,
	rOrderNo as ('RO' + right('1234' + cast(rOrderID as varchar(10)),10)) persisted,
	ResortRoomID int not null Foreign Key References ResortRoom(ResortRoomID),
	CustomerID int not null Foreign Key References Customer(CustomerID),
	rOrderDate Date not null,
	rOrderTime time not null,
	rOrderFromDate date not null,
	rOrderToDate date not null,
	rOrderTotalDays int,
	rOrderVat int,
	rOrderDiscount int,
	rOrderTotalCost float not null,
);

create table VehiclePayment(
	vPaymentID int identity(1,1) not null Primary Key,
	vPaymentNo as ('RO' + right('1234' + cast(vPaymentID as varchar(10)),10)) persisted,
	vOrderID int not null Foreign Key References VehicleOrder(vOrderID),
	CustomerID int not null Foreign Key References Customer(CustomerID),
	vPaymentDate date,
	vPaymenttime time,
	vPaymentTotalCost float,
	vPaymentDue float,
	vPaymentStatus float,
);

create table ResortPayment(
	rPaymentID int identity(1,1) not null Primary Key,
	rPaymentNo as ('RO' + right('1234' + cast(rPaymentID as varchar(10)),10)) persisted,
	rOrderID int not null Foreign Key References ResortOrder(rOrderID),
	CustomerID int not null Foreign Key References Customer(CustomerID),
	rPaymentDate date,
	rPaymenttime time,
	rPaymentTotalCost float,
	rPaymentDue float,
	rPaymentStatus float,
);

Select CategoryName from Category where CategoryName not like '%Resort%' and CategoryName not like '%Hotel%' and CategoryName not like '%Cottage%';