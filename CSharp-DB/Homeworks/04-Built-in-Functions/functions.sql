USE [SoftUni]
-- analytic function
SELECT 
	PERCENTILE_CONT(0.5)
	WITHIN GROUP (ORDER BY Salary DESC)
	OVER (PARTITION BY DepartmentId)
FROM [Employees]

-- ranking function
SELECT
	ROW_NUMBER() OVER (ORDER BY d."Name") AS "Row Number",
	CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
	d."Name" AS Department,
	RANK() OVER (ORDER BY d.[Name]) AS "Rank",
	DENSE_RANK() OVER (ORDER BY d.[Name]) AS "Dense Rank"
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

-- string replicate to anonymise names
SELECT CONCAT(CONCAT(LEFT(FirstName, 1), REPLICATE('*', LEN(FirstName) - 1))
, ' '
,CONCAT(LEFT(LastName, 1), REPLICATE('*', LEN(LastName) - 1)))
FROM Employees

-- calculate the required number of pallets to ship each item
USE Demo
SELECT *,
CEILING(CEILING(Quantity * 1.0/BoxCapacity) * 1.0 / PalletCapacity) AS "Number of Pallets"
FROM Products

-- Date functions
SELECT DATEPART(DAYOFYEAR, '2024-05-24')

USE SoftUni
SELECT CONCAT(FirstName, ' ', LastName), DATEDIFF(MONTH, HireDate, GETDATE()) FROM Employees

SELECT DATENAME(WEEKDAY, GETDATE())

SELECT DATEADD(DAY, 180, GETDATE())

SELECT EOMONTH(GETDATE())