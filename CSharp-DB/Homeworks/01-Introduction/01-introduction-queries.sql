INSERT INTO [Towns]([Id], [Name])
	VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO [Minions]([Id], [Name], [Age], [TownId])
	VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

ALTER TABLE [Minions] 
ALTER COLUMN [Age] INT

SELECT * FROM [Minions]
SELECT * FROM [Towns]

GO

CREATE TABLE [People] (
	[Id] INT PRIMARY KEY IDENTITY
	,[Name] NVARCHAR(200) NOT NULL
	,[Picture] VARBINARY(2048)
	,[Height] DECIMAL(3, 2)
	,[Weight] DECIMAL(5, 2)
	,[Gender] CHAR(1) NOT NULL
	,[Birthdate] DATETIME2 NOT NULL
	,[Biography] NVARCHAR(MAX)
)

INSERT INTO [People]([Name], [Picture], [Height], [Weight], [Gender], [Birthdate], [Biography])
	Values
('Malboko', NULL, 175, 75, 'm', '01.01.1001', '@~123123123123123@@@"£@"£@"£@"@£"@£@"£@"£')

CREATE TABLE [Users] (
	[Id] BIGINT PRIMARY KEY IDENTITY
	,[Username] VARCHAR(30) NOT NULL
	,[Password] VARCHAR(26) NOT NULL
	,[ProfilePicture] VARBINARY
	,CHECK (ProfilePicture <= 900000)
	,[LastLoginTime] DATETIME2
	,[IsDeleted] VARCHAR(5)
	,CHECK (IsDeleted='true' OR IsDeleted='false')
)

INSERT INTO [Users]([Username], [Password], [ProfilePicture], [LastLoginTime], [IsDeleted])
	VALUES
('Gogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Bogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Dogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Drogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Frogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false')

CREATE TABLE [Users] (
	[Id] BIGINT PRIMARY KEY IDENTITY
	,[Username] VARCHAR(30) NOT NULL
	,[Password] VARCHAR(26) NOT NULL
	,[ProfilePicture] VARBINARY
	,CHECK (ProfilePicture <= 900000)
	,[LastLoginTime] DATETIME2
	,[IsDeleted] VARCHAR(5)
	,CHECK (IsDeleted='true' OR IsDeleted='false')
)

INSERT INTO [Users]([Username], [Password], [ProfilePicture], [LastLoginTime], [IsDeleted])
	VALUES
('Gogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Bogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Dogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Drogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false'),
('Frogi', 'hiausdgfiuh', NULL, '01/01/2002', 'false')

GO

-- Create Movies database
CREATE DATABASE Movies;

GO

USE Movies;

CREATE TABLE Directors (
    Id INT PRIMARY KEY,
    DirectorName VARCHAR(100) NOT NULL,
    Notes TEXT
);

CREATE TABLE Genres (
    Id INT PRIMARY KEY,
    GenreName VARCHAR(50) NOT NULL,
    Notes TEXT
);

CREATE TABLE Categories (
    Id INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL,
    Notes TEXT
);

CREATE TABLE Movies (
    Id INT PRIMARY KEY,
    Title VARCHAR(200) NOT NULL,
    DirectorId INT NOT NULL,
    CopyrightYear INT NOT NULL,
    Length INT NOT NULL,
    GenreId INT NOT NULL,
    CategoryId INT NOT NULL,
    Rating DECIMAL(3,1),
    Notes TEXT,
    FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
    FOREIGN KEY (GenreId) REFERENCES Genres(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

INSERT INTO Directors (Id, DirectorName, Notes) VALUES
(1, 'Christopher Nolan', 'Notable for his work in the thriller and science fiction genres'),
(2, 'Steven Spielberg', 'Renowned for his contributions to the adventure and drama genres'),
(3, 'Quentin Tarantino', 'Known for his distinctive style in the crime and black comedy genres'),
(4, 'Hayao Miyazaki', 'Famous for his animated films with themes of environmentalism and pacifism'),
(5, 'Martin Scorsese', 'Acclaimed for his gritty depictions of crime and urban life');

INSERT INTO Genres (Id, GenreName, Notes) VALUES
(1, 'Action', 'Films characterized by extensive action sequences and high energy'),
(2, 'Drama', 'Films focused on realistic characters and emotional themes'),
(3, 'Science Fiction', 'Films exploring speculative or futuristic concepts'),
(4, 'Animation', 'Films created through animation techniques, often for family audiences'),
(5, 'Crime', 'Films centered around criminal activities and their consequences');

INSERT INTO Categories (Id, CategoryName, Notes) VALUES
(1, 'Thriller', 'Films designed to evoke excitement and tension in the audience'),
(2, 'Adventure', 'Films featuring exciting and often dangerous journeys or quests'),
(3, 'Comedy', 'Films intended to amuse and entertain through humor'),
(4, 'Fantasy', 'Films set in imaginary worlds with magical or supernatural elements'),
(5, 'Biography', 'Films depicting the life of a real person or people');

INSERT INTO Movies (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes) VALUES
(1, 'Inception', 1, 2010, 148, 1, 1, 8.8, 'A mind-bending heist thriller'),
(2, 'Schindler''s List', 2, 1993, 195, 2, 5, 8.9, 'A powerful drama based on true events during World War II'),
(3, 'Pulp Fiction', 3, 1994, 154, 5, 1, 8.9, 'A non-linear crime film with multiple intersecting storylines'),
(4, 'Spirited Away', 4, 2001, 125, 4, 2, 8.6, 'An animated fantasy adventure about a young girl trapped in a mysterious world'),
(5, 'Goodfellas', 5, 1990, 146, 5, 1, 8.7, 'A gritty crime drama based on the true story of a mobster');

CREATE DATABASE CarRental;

USE CarRental;

CREATE TABLE Categories(
	[Id] INT PRIMARY KEY,
	[CategoryName] VARCHAR(50) NOT NULL,
	[DailyRate] DECIMAL(5, 2) NOT NULL,
	[WeeklyRate] DECIMAL(6, 2) NOT NULL,
	[MonthlyRate] DECIMAL(7, 2) NOT NULL,
	[WeekendRate] DECIMAL(5, 2) NOT NULL
);

CREATE TABLE Cars(
	[Id] INT PRIMARY KEY,
	[PlateNumber] VARCHAR(10) NOT NULL,
	[Manufacturer] VARCHAR(30) NOT NULL,
	[Model] VARCHAR(30) NOT NULL,
	[CarYear] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[Doors] TINYINT NOT NULL,
	[Picture] IMAGE,
	[Condition] VARCHAR(20) NOT NULL,
	[Available] VARCHAR(5) NOT NULL,
	FOREIGN KEY ([CategoryId]) REFERENCES Categories(Id)
);

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY,
	[FirstName] VARCHAR(20) NOT NULL,
	[LastName] VARCHAR(20) NOT NULL,
	[Title] VARCHAR(5) NOT NULL,
	[Notes] VARCHAR(MAX)
);

CREATE TABLE [Customers](
	[Id] INT PRIMARY KEY,
	[DriverLicenceNumber] VARCHAR(10) NOT NULL,
	[FullName] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(200) NOT NULL,
	[City] VARCHAR(30) NOT NULL,
	[ZIPCode] VARCHAR(10) NOT NULL,
	[Notes] VARCHAR(500)
);

CREATE TABLE [RentalOrders](
	[Id] INT PRIMARY KEY,
	[EmployeeId] INT,
	[CustomerId] INT,
	[CarId] INT,
	[TankLevel] INT,
	[KilometrageStart] INT,
	[KilometrageEnd] INT,
	[TotalKilometrage] INT,
	[StartDate] DATE,
	[EndDate] DATE,
	[TotalDays] INT,
	[RateApplied] DECIMAL,
	[TaxRate] DECIMAL,
	[OrderStatus] VARCHAR(50),
	[Notes] VARCHAR(500),
	FOREIGN KEY ([EmployeeId]) REFERENCES Employees([Id]),
	FOREIGN KEY ([CustomerId]) REFERENCES Customers([Id]),
	FOREIGN KEY ([CarId]) REFERENCES Cars([Id])
);

INSERT INTO Categories (Id, CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
(1, 'Economy', 30.00, 180.00, 600.00, 40.00),
(2, 'Compact', 35.00, 210.00, 700.00, 45.00),
(3, 'SUV', 50.00, 300.00, 1000.00, 70.00);

INSERT INTO Cars (Id, PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
(1, 'ABC123', 'Toyota', 'Corolla', '2018-05-05', 1, 4, '/images/corolla.jpg', 'Excellent', 1),
(2, 'XYZ456', 'Honda', 'Civic', '2018-05-05', 2, 4, '/images/civic.jpg', 'Good', 1),
(3, 'DEF789', 'Ford', 'Explorer', '2018-05-05', 3, 4, '/images/explorer.jpg', 'Excellent', 1);

INSERT INTO Employees (Id, FirstName, LastName, Title, Notes) VALUES
(1, 'John', 'Doe', 'DR', 'Experienced employee with excellent customer service skills'),
(2, 'Jane', 'Smith', 'MS', 'Highly motivated individual with a passion for cars'),
(3, 'David', 'Johnson', 'MR', 'Detail-oriented professional with strong communication skills');

INSERT INTO Customers (Id, DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes) VALUES
(1, '123456789', 'Alice Johnson', '123 Main St', 'Anytown', '12345', 'Frequent renter, loyal customer'),
(2, '987654321', 'Bob Smith', '456 Elm St', 'Othertown', '54321', 'First-time renter, referral from friend'),
(3, '456789123', 'Carol Williams', '789 Oak St', 'Anycity', '67890', 'Corporate account, regular business traveler');

INSERT INTO RentalOrders (Id, EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 1, 1, 1, 75, 10000, 10250, 250, '2024-05-01', '2024-05-05', 4, 180.00, 0.08, 'Completed', 'Customer returned the car in good condition'),
(2, 2, 2, 2, 85, 20000, 20300, 300, '2024-05-02', '2024-05-06', 4, 210.00, 0.08, 'Completed', 'Customer extended the rental for an additional day'),
(3, 3, 3, 3, 90, 15000, 15400, 400, '2024-05-03', '2024-05-07', 4, 300.00, 0.08, 'Completed', 'Customer upgraded to a larger vehicle during the rental period');

GO

CREATE DATABASE SoftUni;

GO

USE SoftUni;

CREATE TABLE Towns (
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE Addresses (
    Id INT PRIMARY KEY IDENTITY,
    AddressText VARCHAR(255) NOT NULL,
    TownId INT,
    FOREIGN KEY (TownId) REFERENCES Towns(Id)
);

CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50),
    LastName VARCHAR(50) NOT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    DepartmentId INT,
    HireDate DATE NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    AddressId INT,
    FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
    FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
);

INSERT INTO Towns (Name) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas');

INSERT INTO Departments (Name) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance');

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 2),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 3),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 4),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 5);

INSERT INTO Addresses (AddressText, TownId) VALUES
('Address 1, Sofia', 1),
('Address 2, Plovdiv', 2),
('Address 3, Varna', 3),
('Address 4, Burgas', 4),
('Address 5, Unknown Town', NULL); 

INSERT INTO Addresses (AddressText, TownId) VALUES
('Address 1, Sofia', 1),
('Address 2, Plovdiv', 2),
('Address 3, Varna', 3),
('Address 4, Burgas', 4),
('Address 5, Unknown Town', NULL);

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary, AddressId) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 2),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 3),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 4),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 5);