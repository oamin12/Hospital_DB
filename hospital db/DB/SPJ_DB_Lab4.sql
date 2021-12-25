
-- This is the script that creates the datbase objects and fills them
create database SPJ_DB_Lab4
GO
use SPJ_DB_Lab4

create table S
(s# char(5) PRIMARY KEY,
name char(20),
status int,
city char(20));

create table P
(p# char(5) PRIMARY KEY,
name char(20),
color char(5),
weight float,
city char(20));

create table J
(j# char(5) PRIMARY KEY,
name char(20),
city char(20));

create table SPJ
(s# char(5),
p# char(5),
j# char(5),
shipDate datetime,
qty int,
PRIMARY KEY(s#,p#,j#),
Foreign Key (s#) references S,
Foreign Key (p#) references p,
Foreign Key (j#) references j,

);


INSERT INTO S
VALUES ('S1','Smith',20,'London');
INSERT INTO S
VALUES ('S2','Jones',10,'Paris');
insert into S
values ('S3','Blake',30,'Paris');
insert into S
values ('S4','Clark',20,'London');
insert into S
values ('S5','Adams',30,'Athens');

insert into P
values ('P1','Nut','Red',12,'London');
insert into P
values ('P2','Bolt','Green',17,'Paris');
insert into P
values ('P3','Screw','Blue',17,'Rome');
insert into P
values ('P4','Screw','Red',14,'London');
insert into P
values ('P5','Cam','Blue',12,'Paris');
insert into P
values ('P6','Cog','Red',19,'London');

insert into J
values ('J1','Sorter','Paris');
insert into J
values ('J2','Punch','Rome');
insert into J
values ('J3','Reader','Athens');
insert into J
values ('J4','Console','Athens');
insert into J
values ('J5','Collator','London');
insert into J
values ('J6','Terminal','Oslo');
insert into J
values ('J7','Tape','London');

insert into SPJ
values ('S1','P1','J1','3/3/99',200);
insert into SPJ
values ('S1','P1','J4','4/4/88',700);
insert into SPJ
values ('S2','P3','J1','6/6/88',400);
insert into SPJ
values ('S2','P3','J2','8/8/99',200);
insert into SPJ
values ('S2','P3','J3','7/7/77',200);
insert into SPJ
values ('S2','P3','J4','8/9/99',500);
insert into SPJ
values ('S2','P3','J5','8/7/99',600);
insert into SPJ
values ('S2','P3','J6','8/7/89',400);
insert into SPJ
values ('S2','P3','J7','8/7/89',800);
insert into SPJ
values ('S2','P5','J2','8/8/88',100);
insert into SPJ
values ('S3','P3','J1','9/9/99',200);
insert into SPJ
values ('S3','P4','J2','9/8/99',500);
insert into SPJ
values ('S4','P6','J3','9/8/99',300);
insert into SPJ
values ('S4','P6','J7','9/9/99',300);
insert into SPJ
values ('S5','P2','J2','9/8/99',200);
insert into SPJ
values ('S5','P2','J4','9/8/99',100);
insert into SPJ
values ('S5','P5','J5','7/8/99',500);
insert into SPJ
values ('S5','P5','J7','6/6/00',100);
insert into SPJ
values ('S5','P6','J2','9/7/00',200);
insert into SPJ
values ('S5','P1','J4','9/8/88',100);
insert into SPJ
values ('S5','P3','J4','7/8/99',200);
insert into SPJ
values ('S5','P4','J4','8/8/99',800);
insert into SPJ
values ('S5','P5','J4','7/8/99',400);
insert into SPJ
values ('S5','P6','J4','7/8/00',500);