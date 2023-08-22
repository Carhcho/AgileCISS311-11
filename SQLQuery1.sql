USE master;

 

IF DB_ID(N'AdvisingDB') IS NOT NULL DROP DATABASE AdvisingDB;

CREATE DATABASE AdvisingDB;

GO

 

USE AdvisingDB;

GO

CREATE TABLE advisor

(

           advisorId         INT NOT NULL IDENTITY,

           advisorName NVARCHAR(100) NOT NULL,

           officeNumber NCHAR(5),

           CONSTRAINT pk_advisor PRIMARY KEY (advisorId)

);

CREATE TABLE advisee

(

           adviseeId INT NOT NULL IDENTITY,

           adviseeName NVARCHAR(100) NOT NULL,

           advisorId INT NOT NULL,

           CONSTRAINT pk_advisee PRIMARY KEY (adviseeId),

           CONSTRAINT fk_advisee_advisor FOREIGN KEY (advisorId)

                  REFERENCES advisor(advisorId)

);

 

INSERT INTO advisor (advisorName, officeNumber) VALUES ('Andrea Boyer', 'LS101');

INSERT INTO advisor (advisorName, officeNumber) VALUES ('Caley Cooper', 'LS102');

INSERT INTO advisor (advisorName, officeNumber) VALUES ('Kayla Crowley', 'LS103');

 

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Ashley Corcoran', 1);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Shelby Goin', 1);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Melinda Freeman', 1);

 

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Jennifer Harper', 2);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Alexander Hagan', 2);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Soon Jang', 2);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Caitlin Lee', 2);

 

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Chang-Kyu Jenkins', 3);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Josh Miller', 3);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Annika Merchant', 3);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Kayla Ross', 3);

INSERT INTO advisee (adviseeName, advisorId) VALUES ('Nicholas Prewitt', 3);

