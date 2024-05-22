-- Problem 1
USE [Random];

CREATE TABLE [Persons] (
	[PersonID] INT,
	[FirstName] VARCHAR(30) NOT NULL,
	[Salary] VARCHAR(100) NOT NULL,
	[PassportID] INT NOT NULL
);


CREATE TABLE [Passports] (
	[PassportID] INT PRIMARY KEY,
	[PassportNumber] VARCHAR(10) NOT NULL
);

INSERT INTO [Passports](PassportID, PassportNumber) VALUES 
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

INSERT INTO [Persons]([PersonID], [FirstName], [Salary], [PassportID]) VALUES
(1, 'Roberto', '56100.00', 102),
(2, 'Tom', '43300.00', 103),
(3, 'Yana', '60200.00', 101)

ALTER TABLE [Persons]
ALTER COLUMN PersonID INT NOT NULL;

ALTER TABLE [Persons]
ADD CONSTRAINT PK_Persons_PersonID PRIMARY KEY(PersonID)

ALTER TABLE [Persons]
ADD CONSTRAINT FK_Persons_Passports
FOREIGN KEY (PassportID) REFERENCES [Passports](PassportID);

-- Problem 2
CREATE TABLE [Manufacturers] (
	[ManufacturerID] INT,
	[Name] VARCHAR(20),
	[EstablishedOn] DATE
);

CREATE TABLE [Models](
	[ModelID] INT,
	[Name] VARCHAR(20),
	[ManufacturerID] INT
);

INSERT INTO [Manufacturers]([ManufacturerID], [Name], [EstablishedOn]) VALUES
(1, 'BMW', '07/03/1916'),
(2, 'Tesla', '01/01/2003'),
(3, 'Lada', '01/05/1966')

INSERT INTO [Models]([ModelID], [Name], [ManufacturerID]) VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)

ALTER TABLE [Models]
ALTER COLUMN [ModelID] INT NOT NULL

ALTER TABLE [Manufacturers]
ALTER COLUMN [ManufacturerID] INT NOT NULL

ALTER TABLE [Models]
ADD CONSTRAINT PK_Models_ModelId PRIMARY KEY(ModelID)

ALTER TABLE [Manufacturers]
ADD CONSTRAINT PK_Manufacturers_ManufacturerID PRIMARY KEY([ManufacturerID])

ALTER TABLE [Models]
ADD CONSTRAINT FK_Models_ManufacturerID
FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)

-- Problem 3
CREATE TABLE [Students] (
    [StudentID] INT PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL
);

CREATE TABLE [Exams] (
    [ExamID] INT PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL
);

CREATE TABLE [StudentsExams] (
    [StudentID] INT,
    [ExamID] INT,
    PRIMARY KEY (StudentID, ExamID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
);

INSERT INTO [Students] ([StudentID],[Name]) VALUES
(1, 'Mila'),
(2, 'Toni'),
(3, 'Ron');

INSERT INTO [Exams] ([ExamID], [Name]) VALUES
(101, 'MVC'),
(102, 'Neo4j'),
(103, 'Oracle');

INSERT INTO [StudentsExams] ([StudentID], [ExamID]) VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103);

-- Problem 4
CREATE TABLE [Teachers](
	[TeacherID] INT PRIMARY KEY,
	[Name] VARCHAR(30) NOT NULL,
	[ManagerID] INT NULL
	CONSTRAINT FK_Teachers_Managers FOREIGN KEY (ManagerID) REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers (TeacherID, Name, ManagerID) VALUES
(101, 'John', NULL),
(106, 'Greta', 101),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101);

-- Problem 5
CREATE TABLE [Cities] (
    [CityID] INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL
);

CREATE TABLE [Customers] (
    [CustomerID] INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL,
    [Birthday] DATE,
    [CityID] INT,
    FOREIGN KEY (CityID) REFERENCES Cities(CityID)
);

CREATE TABLE [Orders] (
    [OrderID] INT PRIMARY KEY,
    [CustomerID] INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE [ItemTypes] (
    [ItemTypeID] INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL
);

CREATE TABLE [Items] (
    [ItemID] INT PRIMARY KEY,
    [Name] VARCHAR(255) NOT NULL,
    [ItemTypeID] INT,
    FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
);

CREATE TABLE [OrderItems] (
    [OrderID] INT,
    [ItemID] INT,
    PRIMARY KEY (OrderID, ItemID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
);

-- Problem 6
CREATE TABLE [Majors] (
	[MajorID] INT PRIMARY KEY,
	[Name] VARCHAR(30)
);

CREATE TABLE [Students] (
	[StudentID] INT PRIMARY KEY,
	[StudentNumber] VARCHAR(30),
	[StudentName] VARCHAR(30),
	[MajorID] INT,
	FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
);

CREATE TABLE [Payments] (
	[PaymentID] INT PRIMARY KEY,
	[PaymentDate] DATE,
	[PaymentAmount] DECIMAL,
	[StudentID] INT,
	FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE [Subjects] (
	[SubjectID] INT PRIMARY KEY,
	[SubjectName] VARCHAR(30)
);

CREATE TABLE [Agenda]( 
	[StudentID] INT,
	[SubjectID] INT,
	PRIMARY KEY (StudentID, SubjectID),
	FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
	FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);

-- Problem 7
USE [Geography]

SELECT 
    m.MountainRange,
    p.PeakName,
    p.Elevation
FROM 
    Mountains m
JOIN 
    Peaks p ON m.Id = p.MountainId
WHERE 
    m.MountainRange = 'Rila'
ORDER BY 
    p.Elevation DESC;
