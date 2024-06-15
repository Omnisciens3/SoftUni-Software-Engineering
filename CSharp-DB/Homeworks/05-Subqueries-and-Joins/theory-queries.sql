-- Problem 1
SELECT 
	e.FirstName
	, e.LastName
	, e.HireDate
	, d.[Name] AS DepartmentName
FROM Employees e
	INNER JOIN Departments d
	ON (e.DepartmentID = d.DepartmentID
	AND e.HireDate > '1/1/1999'
	AND d.[Name] IN ('Sales', 'Finance'))
ORDER BY e.HireDate

-- Problem 2
SELECT TOP (50)
	e.EmployeeID
	,CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName
	,CONCAT(m.FirstName, ' ', m.LastName) AS ManagerName
	,d.[Name] AS DepartmentName
FROM Employees AS e
LEFT JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

-- Problem 3
SELECT
	MIN(dt.AverageSalary) AS MinAverageSalary
FROM 
	(SELECT
		AVG(Salary) AS AverageSalary
	FROM Employees
	GROUP BY DepartmentID) AS dt

-- Example for CTE

WITH MyCTE (FirstName, LastName, DepartmentName)
AS
(SELECT
	e.FirstName
	,e.LastName
	,d.Name
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID)

SELECT * FROM MyCTE