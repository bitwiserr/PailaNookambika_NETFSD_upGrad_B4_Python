CREATE DATABASE Eventdb;

use Eventdb;

create table UserInfo(EmailId varchar(100) PRIMARY KEY, 
UserName varchar(50) NOT NULL CHECK(LEN(UserName) BETWEEN 1 and 50),
Role varchar(50) NOT NULL CHECK(role IN ('Admin' , 'Participant')),
Password varchar(20) NOT NULL CHECK(LEN(Password) BETWEEN 6 and 20));

CREATE TABLE EventDetails(EventId int PRIMARY KEY,
EventName varchar(50) NOT NULL CHECK(LEN(EventName) BETWEEN 1 and 50),
EventCategory varchar(50) NOT NULL CHECK(LEN(EventCategory) BETWEEN 1 and 50),
EventDate DATETIME NOT NULL,
Description varchar(250) NULL,
Status varchar(20) CHECK(Status IN ('Active' , 'InActive'))
);

CREATE TABLE SpeakersDetails(
SpeakerId int PRIMARY KEY,
SpeakerName varchar(50) NOT NULL CHECK(LEN(SpeakerName) BETWEEN 1 and 50)
);

CREATE TABLE SessionInfo(
SessionId int PRIMARY KEY,
EventId int NOT NULL,
SessionTitle varchar(50) NOT NULL CHECK(LEN(SessionTitle) BETWEEN 1 and 50),
SpeakerId INT NOT NULL,
Description varchar NULL,
SessionStart datetime NOT NULL,
SessionEnd datetime NOT NULL,
SessionUrl varchar(255)
CONSTRAINT FK_SessionEvent FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
CONSTRAINT FK_SessionSpeaker FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);

CREATE TABLE ParticipantEventDetails(
Id int PRIMARY KEY,
ParticipantEmailId varchar(100) NOT NULL,
EventId int NOT NULL,
SessionId int NOT NULL,
IsAttended BIT NOT NULL CHECK (IsAttended IN (0,1)) ,
CONSTRAINT FK_ParticipantUser FOREIGN KEY (ParticipantEmailId) REFERENCES UserInfo(EmailId),
CONSTRAINT FK_ParticipantEvent FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
CONSTRAINT FK_ParticipantSession FOREIGN KEY (SessionId) REFERENCES SessionInfo(SessionId)
);


