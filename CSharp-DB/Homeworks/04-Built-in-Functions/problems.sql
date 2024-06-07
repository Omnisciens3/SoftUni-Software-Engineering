USE SoftUni
-- Problem 1
SELECT FirstName, LastName
FROM Employees
WHERE LEFT(FirstName, 2) = 'Sa'

-- Problem 2
SELECT FirstName, LastName
FROM Employees
WHERE CHARINDEX('ei', LastName) > 0;

-- Problem 3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3, 10)
  AND YEAR(HireDate) BETWEEN 1995 AND 2005;

-- Problem 4
SELECT FirstName, LastName
FROM Employees
WHERE CHARINDEX('engineer', LOWER(JobTitle)) = 0;

-- Problem 5
SELECT "Name"
FROM Towns
WHERE LEN("Name") IN (5,6)
ORDER BY "Name"

-- Problem 6
SELECT "TownID", "Name"
FROM Towns
WHERE LEFT("Name", 1) IN ('M', 'K', 'B', 'E')
ORDER BY "Name"

-- Problem 7
SELECT "TownID", "Name"
FROM Towns
WHERE LEFT("Name", 1) NOT IN ('R', 'B', 'D')
ORDER BY "Name"

-- Problem 8
GO

CREATE VIEW "V_EmployeesHiredAfter2000" AS
SELECT FirstName, LastName
FROM Employees
WHERE YEAR(HireDate) > 2000

GO
-- Problem 9
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

-- Problem 10
SELECT EmployeeID, FirstName, LastName, Salary,
       DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS Rank
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC;

-- Problem 11
WITH RankedEmployees AS (
    SELECT EmployeeID, FirstName, LastName, Salary,
           DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS Rank
    FROM Employees
    WHERE Salary BETWEEN 10000 AND 50000
)
SELECT EmployeeID, FirstName, LastName, Salary, Rank
FROM RankedEmployees
WHERE Rank = 2
ORDER BY Salary DESC;

-- Problem 12
USE [Geography]

SELECT [CountryName] AS "Country Name", [IsoCode] AS "ISO Code"
FROM [Countries]
WHERE (LEN([CountryName]) - LEN(REPLACE([CountryName], 'a', ''))) >= 3
ORDER BY [IsoCode]

-- Problem 13
SELECT [p].[PeakName], [r].[RiverName],
	LOWER(CONCAT(LEFT([p].[PeakName], LEN([p].[PeakName]) - 1), [r].[RiverName])) AS [Mix]
FROM [Rivers] AS [r],
	 [Peaks] AS [p]
WHERE RIGHT([p].[PeakName], 1) = LEFT([r].[RiverName], 1)
ORDER BY [Mix]

-- Problem 14
USE [Diablo]

SELECT TOP (50) [Name]
	  ,FORMAT([Start], 'yyyy-MM-dd') AS "Start"
FROM [Games]
WHERE YEAR([Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]

-- Problem 15
SELECT [Username]
	  ,SUBSTRING([Email], CHARINDEX('@', [Email]) + 1, LEN([Email])) AS "Email Provider"
FROM [Users]
WHERE CHARINDEX('@', [Email]) > 0
ORDER BY [Email Provider], [Username]

-- Problem 16
SELECT [Username]
	  ,[IpAddress] AS "IP Address"
FROM [Users]
WHERE [IpAddress] LIKE '___.1_%._%.___'
ORDER BY [Username]

-- Problem 17
SELECT [Name] AS "Game",
	  CASE
			WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12  THEN 'Morning'
			WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18  THEN 'Afternoon'
			WHEN DATEPART(HOUR, [Start]) >= 18 AND DATEPART(HOUR, [Start]) < 24  THEN 'Evening'
	  END AS "Part of the Day",
	  CASE
			WHEN Duration IS NULL THEN 'Extra Long'
			WHEN Duration <= 3 THEN 'Extra Short'
			WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
			WHEN Duration > 6 THEN 'Long'
	  END AS "Duration"
FROM [Games]
ORDER BY [Game], [Duration], [Part of the Day]

-- Problem 18
SELECT [ProductName]
    ,[OrderDate]
    ,DATEADD(DAY, 3, [OrderDate]) AS "Pay Due"
   , DATEADD(MONTH, 1, [OrderDate]) AS "Deliver Due"
FROM [Orders]

-- Problem 19
CREATE TABLE People (
    Id INT,
    Name NVARCHAR(100),
    Birthdate DATETIME
);

INSERT INTO People (Id, Name, Birthdate)
VALUES
(1, 'Victor', '2000-12-07 00:00:00.000'),
(2, 'Steven', '1992-09-10 00:00:00.000'),
(3, 'Stephen', '1910-09-19 00:00:00.000'),
(4, 'John', '2010-01-06 00:00:00.000');

SELECT 
    Name,
    DATEDIFF(YEAR, Birthdate, GETDATE()) - CASE 
        WHEN (MONTH(Birthdate) > MONTH(GETDATE())) 
             OR (MONTH(Birthdate) = MONTH(GETDATE()) AND DAY(Birthdate) > DAY(GETDATE())) THEN 1
        ELSE 0
    END AS [Age in Years],
    DATEDIFF(MONTH, Birthdate, GETDATE()) - CASE
        WHEN DAY(Birthdate) > DAY(GETDATE()) THEN 1
        ELSE 0
    END AS [Age in Months],
    DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
    DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Minutes]
FROM 
    People;