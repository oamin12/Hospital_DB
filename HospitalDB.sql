-------------Database creation-------------

create database DB_Project_Hospital
Go

use DB_Project_Hospital
------------Table Creation-----------------

create table PersonData
(
FName varchar(50) not null,
LName varchar(50) not null,
ID int IDENTITY(1,1),
primary key (ID),
BoD date,
gender char(1) 
)

create table Usertype
(
Tname varchar(50) not null,
ID int IDENTITY(1,1),
primary key (ID)
)


create table Users
(
ID int IDENTITY(1,1),
primary key (ID),
passwords char(60),
PersonID int not null,
Username varchar(50) not null,
UserTypeID int not null,
foreign key (PersonID) references PersonData,
foreign key (UserTypeID) references Usertype
)

create table Department
(
DepID int IDENTITY(1,1),
primary key (DepID),
DepName varchar(50) not null,
DepHead int,
--foreign key (DepHead) references Doctors
)
create table Doctors
(
ID int IDENTITY(1,1),
primary key (ID),
Salary int not null,
DepID int not null,
SuperID int,
PersonID int not null,
Foreign key  (DepID) references Department,
Foreign key  (SuperID) references Doctors,
Foreign key  (PersonID) references PersonData,
)

create table Nurse
(
ID int IDENTITY(1,1),
primary key (ID),
salary int not null,
PersonID int not null,
SuperID int ,
Foreign key  (PersonID) references PersonData,
Foreign key  (SuperID) references Nurse,
)

--is the nurse supervisor nurse as well ??
-- fen el name ya shbab
---trans needs logic
create table Patient
(
ID int IDENTITY(1,1),
primary key (ID),
PersonID int not null,
BloodType char(4),
--Allergies varchar(50),
--Diseases varchar(100),
ResDrID int,--responsible Doctor
foreign key (PersonID) references PersonData,
foreign key (ResDrID) references Doctors
)

create table Room
(
ID int IDENTITY(1,1),
primary key (ID),
ResposibleNurseID int,
PatientID int,
--size varchar dah tmam ?
Notes varchar(500),
Foreign key  (ResposibleNurseID) references Nurse,
Foreign key  (PatientID) references Patient
)


create table EmployeeType
(
ID int IDENTITY(1,1),
primary key (ID),
Tname varchar(20)
)

create table Employee
(
ID int IDENTITY(1,1),
primary key (ID),
PersonID int,
EmployeeTypeID int,
Salary int not null,
DepartmentID int,
foreign key (PersonID) references PersonData,
foreign key (EmployeeTypeID) references EmployeeType,
foreign key (DepartmentID) references Department --added 15/12
)

create table OperationType
(
Oname varchar(60) not null,
ID int IDENTITY(1,1),
primary key (ID)
)

create table ScanLab
(
ID int IDENTITY(1,1),
primary key (ID),
----Stype varchar
SType varchar(50) not null,
Price int not null,
--- DIDN'T ADD PATIENT ID AS in ER 3ashan mesh moqtane3 beeha hena
--- should be fy relation has a scan i guess wala eh ?
)

create table OperationRoom
(
ID int IDENTITY(1,1),
primary key (ID),
RoomNumber int,
)


create table operations
(
ID int IDENTITY(1,1),
primary key (ID),
---operation rooom mesh ma3moola entity aslan, ha3melha ta7t!!!
OLocation int not null,
startTime datetime not null,
endTime datetime not null,
PatientID int,
OTypeID int,
DoctorID int,
---Nurse lazem relation lewa7daha ma3 operation lw 3ayzeen
--- kaza nurse fel operation
foreign key (PatientID) references Patient,
foreign key (OTypeID) references OperationType,
foreign key (DoctorID) references Doctors,
foreign key (Olocation) references OperationRoom
)


--------------------------------------------------------------
--------------------------------------------------------------
create table Nurses_Operations
(
NurseID int,
OperationID int,
primary key (NurseID,OperationID),
foreign key (NurseID) references Nurse,
foreign key (OperationID) references Operations
)

create table Patient_allergies
(
patientID int,
allergies varchar(50),
foreign key (patientID) references Patient
)

create table Patient_Diseases
(
patientID int,
Diseases varchar(50),
foreign key (patientID) references Patient
)

create table requests
(
ID int IDENTITY(1,1),
primary key (ID),
Accepted bit default 0,
DoctorID int,
foreign key (DoctorID) references Doctors,
RoomID int,
foreign key (RoomID) references Room,
PatientID int,
foreign key (PatientID) references Patient,
ScanID int,
foreign key (ScanID) references ScanLab,
)

create table transactions
(
Ttype varchar(50) not null,
Payment int,
--Istallments int, 3ayzeen nebos 3aleeha tany
ID int,
requestID int,
primary key (ID),
foreign key (requestID) references Requests
)


create table GetsPaid
(
PersonID int,
TransactionID int,
foreign key (PersonID) references PersonData,
foreign key (TransactionID) references Transactions
)

create table Has_a_scan

(
PatientID int,
Date_time datetime,
ScanID int,
foreign key (PatientID) references Patient,
foreign key (ScanID) references ScanLab,
)

create table Appointment
(
PatientID int,
DrID int,
Date_time datetime,
Atype varchar(50),
primary key (PatientID,DrID,Date_time),
foreign key (PatientID) references Patient,
foreign key (DrID) references Doctors
)
-----------------adding foreign key for department--------
alter table Department add foreign key (DepHead) references Doctors



----tables to be added-------
-----Nurses and Operation table
-----Patient and allergies and diseases NB. 2 tables
-----requests
-----Gets paid(PersonID,Transaction ID )
----Has a Scan (PatientID, DateTime,IDscan)
----Appointment ("PatienID","DrID","DateTime",Type)




-----notes----
--each patient has only one dr