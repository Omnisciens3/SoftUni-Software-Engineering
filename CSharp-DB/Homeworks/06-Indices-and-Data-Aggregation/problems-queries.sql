USE [Gringotts]

-- Problem 1
SELECT COUNT(*) AS [Count] FROM [WizzardDeposits]

-- Problem 2
SELECT MAX([MagicWandSize]) AS [LongestMagicWand] FROM [WizzardDeposits]

-- Problem 3
SELECT [DepositGroup]
	   ,MAX([MagicWandSize]) AS [LongestMagicWand] 
FROM [WizzardDeposits] 
GROUP BY [DepositGroup]

-- Problem 4
SELECT TOP (2) 
	[DepositGroup]
FROM [WizzardDeposits] 
GROUP BY [DepositGroup] 
ORDER BY AVG([MagicWandSize])

-- Problem 5
SELECT 
	[DepositGroup], 
	SUM([DepositAmount]) AS [TotalSum] 
FROM [WizzardDeposits] GROUP BY [DepositGroup]

-- Problem 6
SELECT 
	[DepositGroup]
	, SUM([DepositAmount]) AS [TotalSum] 
FROM [WizzardDeposits] 
WHERE [MagicWandCreator] = 'Ollivander family' 
GROUP BY [DepositGroup]

-- Problem 7
SELECT 
	[DepositGroup]
	,SUM([DepositAmount]) AS [TotalSum] 
FROM [WizzardDeposits] 
WHERE [MagicWandCreator] = 'Ollivander family' 
GROUP BY [DepositGroup] HAVING SUM([DepositAmount]) < 150000 
ORDER BY SUM([DepositAmount]) DESC

-- Problem 8
SELECT 
	[DepositGroup]
	,[MagicWandCreator]
	,MIN([DepositCharge]) AS [MinDepositCharge] 
FROM [WizzardDeposits] 
GROUP BY [DepositGroup], [MagicWandCreator] 
ORDER BY [MagicWandCreator], [DepositGroup]

-- Problem 9
SELECT 
	[AgeGroup]
	,COUNT(*) AS [WizardCount] 
FROM (
		SELECT 
		CASE 
			WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]' 
			WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
			WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]' 
			WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]' 
			WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]' 
			WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]' 
			WHEN [Age] >= 61 THEN '[61+]' END AS [AgeGroup] 
		FROM [WizzardDeposits]
	 ) AS [AgeRanges] 
GROUP BY [AgeGroup]

-- Problem 10
SELECT DISTINCT LEFT([FirstName], 1) AS [FirstLetter] 
FROM [WizzardDeposits] 
WHERE [DepositGroup] = 'Troll Chest' 
ORDER BY [FirstLetter]

-- Problem 11
SELECT [DepositGroup]
	,[IsDepositExpired]
	,AVG([DepositInterest]) AS [AverageInterest] 
FROM [WizzardDeposits] 
WHERE [DepositStartDate] > '1985-01-01' 
GROUP BY [DepositGroup], [IsDepositExpired] 
ORDER BY [DepositGroup] DESC, [IsDepositExpired]

-- Problem 12
SELECT SUM([Difference]) AS [SumDifference] 
FROM (
		SELECT [DepositAmount] - LEAD([DepositAmount], 1) OVER (ORDER BY [Id]) AS [Difference] 
		FROM [WizzardDeposits]
	 ) AS [Differences]

-- Problem 13
USE [SoftUni]

SELECT [DepartmentID]
	,SUM([Salary]) AS [TotalSalary] 
FROM [Employees] 
GROUP BY [DepartmentID] 
ORDER BY [DepartmentID]

-- Problem 14
SELECT [DepartmentID]
	,MIN([Salary]) AS [MinimumSalary] 
FROM [Employees] 
WHERE [DepartmentID] IN (2, 5, 7) AND [HireDate] > '2000-01-01' 
GROUP BY [DepartmentID]

-- Problem 15
SELECT 
*
INTO [EmployeesOver30k]
FROM [Employees]
WHERE [Salary] > 30000

DELETE FROM [EmployeesOver30k]
WHERE [ManagerID] = 42

UPDATE [EmployeesOver30k]
SET [Salary] += 5000
WHERE [DepartmentID] = 1

SELECT [DepartmentID]
	,AVG([Salary]) AS [AverageSalary]
FROM [EmployeesOver30k]
GROUP BY [DepartmentID]

-- Problem 16
SELECT [DepartmentID]
	,MAX([Salary]) AS [MaxSalary] 
FROM [Employees] 
GROUP BY [DepartmentID]
HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000

-- Problem 17
SELECT COUNT(*) AS [Count] FROM [Employees] WHERE [ManagerID] IS NULL

-- Problem 18
SELECT DISTINCT [DepartmentID]
	,[Salary]
	FROM (
		SELECT
        [DepartmentID]
		,[Salary]
		,DENSE_RANK() OVER (PARTITION BY [DepartmentID] ORDER BY [Salary] DESC) AS [SalaryRank]
		FROM [Employees]
		 )
	AS [SalaryRankingQuery]
WHERE [SalaryRank] = 3

-- Problem 19
WITH [DepartmentAvgSalary] AS (
    SELECT
        [DepartmentID]
		,AVG([Salary]) AS [AvgSalary]
    FROM [Employees]
    GROUP BY [DepartmentID]
)
SELECT TOP (10)
    [e].[FirstName]
	,[e].[LastName]
	,[e].[DepartmentID]
FROM [Employees] AS [e]
JOIN [DepartmentAvgSalary] AS [das] ON [e].[DepartmentID] = [das].[DepartmentID]
WHERE [e].[Salary] > [das].[AvgSalary]
ORDER BY [e].[DepartmentID]