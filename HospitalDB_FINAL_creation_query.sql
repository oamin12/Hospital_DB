-------------Database creation-------------

create database DB_Project_Hospital_DataBase
Go

use DB_Project_Hospital_DataBase
------------Table Creation-----------------

create table Person
(
ID int IDENTITY(1,1),
primary key (ID),
FName varchar(50) not null,
LName varchar(50) not null,
BoD date,
gender char(1) 
)

create table Usertype
(
Tname varchar(50) not null,
ID int,
primary key (ID)
)


create table Users
(
ID int IDENTITY(1,1),
primary key (ID),
passwords char(60) not null,
PersonID int not null,
Username varchar(50) not null,
UserTypeID int not null,
foreign key (PersonID) references Person
on delete cascade
on update cascade,
foreign key (UserTypeID) references Usertype
on update cascade
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
DepID int not null default -1,
SuperID int,
PersonID int not null,
Foreign key  (DepID) references Department
on delete set default
on update cascade,
Foreign key  (SuperID) references Doctors
on delete no action
on update no action,
Foreign key  (PersonID) references Person
on delete cascade
on update cascade,
)

create table Nurse
(
ID int IDENTITY(1,1),
primary key (ID),
salary int not null,
PersonID int not null,
SuperID int ,
Foreign key  (PersonID) references Person
on delete cascade
on update cascade,
Foreign key  (SuperID) references Nurse
on delete no action
on update no action,
)

--is the nurse supervisor nurse as well ??

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
foreign key (PersonID) references Person
on delete cascade
on update cascade,
foreign key (ResDrID) references Doctors
on delete no action
on update no action
)

create table Room
(
ID int IDENTITY(1,1),
primary key (ID),
ResposibleNurseID int,
PatientID int,
--size varchar dah tmam ?
--ah
Notes varchar(500),
Foreign key  (ResposibleNurseID) references Nurse
on delete set null
on update cascade,
Foreign key  (PatientID) references Patient
on delete no action
on update no action
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
DepartmentID int not null default -1,
foreign key (PersonID) references Person
on delete cascade
on update cascade,
foreign key (EmployeeTypeID) references EmployeeType
on update cascade,
foreign key (DepartmentID) references Department
on delete set default
on update cascade--added 15/12
)

create table OperationType
(
Oname varchar(60) not null,
ID int,
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
OLocation int not null default -1,
startTime datetime not null,
endTime datetime not null,
PatientID int not null,
OTypeID int not null,
DoctorID int not null,
---Nurse lazem relation lewa7daha ma3 operation lw 3ayzeen
--- kaza nurse fel operation
foreign key (PatientID) references Patient
on delete cascade
on update cascade,
foreign key (OTypeID) references OperationType
on update cascade,
foreign key (DoctorID) references Doctors
on delete no action
on update no action,
foreign key (Olocation) references OperationRoom
on delete set default
on update cascade
)


--------------------------------------------------------------
--------------------------------------------------------------
create table Nurses_Operations
(
NurseID int default -1,
OperationID int default -1,
primary key (NurseID,OperationID),
foreign key (NurseID) references Nurse(ID)
on delete set default
on update set default,
foreign key (OperationID) references Operations
on delete no action
on update no action
)

create table Patient_allergies
(
patientID int,
allergies varchar(50),
primary key (patientID,allergies),
foreign key (patientID) references Patient
on delete no action
on update cascade
)

create table Patient_Diseases
(
patientID int,
Diseases varchar(50),
primary key (patientID,Diseases),
foreign key (patientID) references Patient
on delete no action
on update cascade
)

create table requests
(
ID int IDENTITY(1,1),
primary key (ID),
Accepted bit default 0,
DoctorID int,
foreign key (DoctorID) references Doctors
on delete no action
on update no action,
RoomID int,
foreign key (RoomID) references Room
on delete no action
on update no action,
PatientID int,
foreign key (PatientID) references Patient
on delete no action
on update no action,
ScanID int,
foreign key (ScanID) references ScanLab
on delete no action
on update no action,
ScanDate DateTime

)

create table transactions
(
Ttype varchar(50) not null,
Payment int,
--Istallments int, 3ayzeen nebos 3aleeha tany
ID int IDENTITY(1,1),
requestID int,
primary key (ID),
foreign key (requestID) references Requests
on delete no action
)


create table GetsPaid
(
PersonID int,
TransactionID int,
foreign key (PersonID) references Person
on delete cascade
on update cascade,
foreign key (TransactionID) references Transactions
on delete cascade
on update cascade
)

create table Has_a_scan

(
PatientID int,
Date_time datetime,
ScanID int,
foreign key (PatientID) references Patient
on delete cascade
on update cascade,
foreign key (ScanID) references ScanLab,
)

create table Appointment
(
PatientID int,
DrID int default -1,
Date_time datetime,
Atype varchar(50),
primary key (PatientID,DrID,Date_time),
foreign key (PatientID) references Patient
on delete cascade
on update cascade,
foreign key (DrID) references Doctors
on delete no action 
on update no action
)
-----------------adding foreign key for department--------
alter table Department add foreign key (DepHead) references Doctors
ALTER TABLE Appointment ADD Report varchar(500);


----tables to be added-------
-----Nurses and Operation table
-----Patient and allergies and diseases NB. 2 tables
-----requests
-----Gets paid(PersonID,Transaction ID )
----Has a Scan (PatientID, DateTime,IDscan)
----Appointment ("PatienID","DrID","DateTime",Type)




-----notes----
--each patient has only one dr