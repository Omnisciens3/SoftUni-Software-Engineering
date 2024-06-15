-- Problem 1
USE SoftUni

SELECT TOP (5)
	  [e].[EmployeeID]
	 ,[e].[JobTitle]
	 ,[a].[AddressID]
	 ,[a].[AddressText]
FROM [Employees] AS e
	INNER JOIN [Addresses] AS a 
	ON [e].[AddressID] = [a].[AddressID]
ORDER BY
    [a].[AddressID]

-- Problem 2
SELECT TOP (50)
	  [e].[FirstName]
	 ,[e].[LastName]
	 ,[t].[Name]
	 ,[a].[AddressText]
FROM [Employees] AS e
	INNER JOIN [Addresses] AS a 
	ON [e].[AddressID] = [a].[AddressID]
	INNER JOIN [Towns] AS t
	ON [t].[TownID] = [a].[TownID]
ORDER BY
    [e].[FirstName], [e].[LastName]

-- Problem 3
SELECT
	  [e].[EmployeeID]
	 ,[e].[FirstName]
	 ,[e].[LastName]
	 ,[d].[Name]
FROM [Employees] AS e
	JOIN [Departments] AS d
	ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [d].[Name] = 'Sales'
ORDER BY [e].[EmployeeID]

-- Problem 4
SELECT TOP (5)
	  [e].[EmployeeID]
	 ,[e].[FirstName]
	 ,[e].[Salary]
	 ,[d].[Name]
FROM [Employees] AS e
	JOIN [Departments] AS d
	ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [e].[Salary] > 15000
ORDER BY [d].[DepartmentID]

-- Problem 5
SELECT TOP (3)
	  [e].[EmployeeID]
	 ,[e].[FirstName]
FROM [Employees] AS e
	LEFT JOIN [EmployeesProjects] AS ep
	ON [e].[EmployeeID] = [ep].[EmployeeID]
WHERE [ep].[ProjectID] IS NULL
ORDER BY [e].[EmployeeID]

-- Problem 6
SELECT
	  [e].[FirstName]
	 ,[e].[LastName]
	 ,[e].[HireDate]
	 ,[d].[Name]
FROM [Employees] AS e
	JOIN [Departments] AS d
	ON [e].[DepartmentID] = [d].[DepartmentID]
WHERE [d].[Name] IN ('Sales', 'Finance') AND [e].[HireDate] > '1/1/1999'
ORDER BY [e].[HireDate]

-- Problem 7
SELECT TOP (5)
	  [e].[EmployeeID]
	 ,[e].[FirstName]
	 ,[p].[Name]
FROM [Employees] AS e
	LEFT JOIN [EmployeesProjects] AS ep
	ON [e].[EmployeeID] = [ep].[EmployeeID]
	LEFT JOIN [Projects] AS p
	ON [ep].ProjectID = [p].[ProjectID]
WHERE [p].[StartDate] > '2002/08/13' AND [p].[EndDate] IS NULL
ORDER BY [e].[EmployeeID]

-- Problem 8
SELECT TOP (5)
	  [e].[EmployeeID]
	 ,[e].[FirstName]
	 ,CASE
		WHEN YEAR([p].[StartDate]) >= 2005 THEN NULL
		ELSE [p].[Name]
	   END AS [ProjectName]
FROM [Employees] AS e
	LEFT JOIN [EmployeesProjects] AS ep
	ON [e].[EmployeeID] = [ep].[EmployeeID]
	LEFT JOIN [Projects] AS p
	ON [ep].ProjectID = [p].[ProjectID]
WHERE [e].[EmployeeID] = 24
ORDER BY [e].[EmployeeID]

-- Problem 9
SELECT
	[e].[EmployeeID]
	,[e].[FirstName]
	,[m].[EmployeeID] AS "ManagerID"
	,[m].[FirstName] AS "ManagerName"
FROM [Employees] AS [e]
INNER JOIN [Employees] AS [m]
ON [e].ManagerID = [m].[EmployeeID]
WHERE [m].[EmployeeID] IN(3, 7)
ORDER BY [EmployeeID]

-- Problem 10
SELECT TOP (50)
	[e].[EmployeeID]
	,CONCAT([e].[FirstName], ' ', [e].[LastName]) AS "EmployeeName"
	,CONCAT([m].[FirstName], ' ', [m].[LastName]) AS "ManagerName"
	,[d].[Name] AS "DepartmentName"
FROM [Employees] AS [e]
	INNER JOIN [Employees] AS [m]
		ON [e].ManagerID = [m].[EmployeeID]
	INNER JOIN [Departments] AS [d]
		ON [e].[DepartmentID] = [d].[DepartmentID]
ORDER BY [EmployeeID]

-- Problem 11
SELECT
	MIN([dt].[AverageSalary]) AS [MinAverageSalary]
FROM
	(SELECT
		AVG([Salary]) AS [AverageSalary]
	FROM [Employees]
	GROUP BY [DepartmentID]) AS [dt]

-- Problem 12
USE [Geography]

SELECT
	[c].[CountryCode]
	,[m].[MountainRange]
	,[p].[PeakName]
	,[p].[Elevation]
FROM [Countries] AS [c]
JOIN [MountainsCountries] AS [mc] ON [c].[CountryCode] = [mc].CountryCode
JOIN [Mountains] AS [m] ON [m].[Id] = [mc].MountainId
JOIN [Peaks] AS [p] ON [p].[MountainId] = [m].[Id] 
WHERE [p].[Elevation] > 2835 AND [c].[CountryCode] = 'BG'
ORDER BY [p].[Elevation] DESC

-- Problem 13
SELECT
    [mc].[CountryCode],
    COUNT(DISTINCT [m].[MountainRange]) AS "MountainRanges"
FROM [MountainsCountries] [mc]
JOIN [Mountains] [m] ON [mc].[MountainId] = [m].[Id]
WHERE [mc].[CountryCode] IN ('US', 'RU', 'BG')
GROUP BY [mc].[CountryCode]
ORDER BY [mc].[CountryCode]

-- Problem 14
SELECT TOP (5)
	[CountryName]
	,[RiverName]
FROM [Countries] AS [c]
LEFT JOIN [CountriesRivers] AS [cr]
	ON [c].[CountryCode] = [cr].[CountryCode]
LEFT JOIN [Rivers] AS [r]
	ON [r].[Id] = [cr].[RiverId]
WHERE [c].[ContinentCode] = 'AF'
ORDER BY [c].[CountryName]

-- Problem 15
WITH [CurrencyUsage] AS (
    SELECT
        c.ContinentCode,
        c.CurrencyCode,
        COUNT(*) AS CurrencyUsage
    FROM
        Countries c
    GROUP BY
        c.ContinentCode, c.CurrencyCode
    HAVING
        COUNT(*) > 1  
),
MaxCurrencyUsage AS (
    SELECT
        ContinentCode,
        MAX(CurrencyUsage) AS MaxUsage
    FROM
        CurrencyUsage
    GROUP BY
        ContinentCode
)
SELECT
    cu.ContinentCode,
    cu.CurrencyCode,
    cu.CurrencyUsage
FROM
    CurrencyUsage cu
JOIN
    MaxCurrencyUsage mcu ON cu.ContinentCode = mcu.ContinentCode AND cu.CurrencyUsage = mcu.MaxUsage
ORDER BY
    cu.ContinentCode;

-- Problem 15 (second solution)
SELECT [ContinentCode]
	  ,[CurrencyCode]
	  ,[CurrencyUsage]
	FROM (
		SELECT *,
			DENSE_RANK() OVER(PARTITION BY [ContinentCode] ORDER BY [CurrencyUsage] DESC) AS [CurrencyRank]
		FROM (
				SELECT
					[co].[ContinentCode]
					,[c].[CurrencyCode]
					,COUNT([c].[CurrencyCode]) AS [CurrencyUsage]
				FROM [Continents] AS [co]
				LEFT JOIN [Countries] AS [c]
					ON [c].[ContinentCode] = [co].[ContinentCode]
				GROUP BY [co].[ContinentCode], [c].[CurrencyCode]
			 ) AS [CurrencyUsageQuery]
		WHERE [CurrencyUsage] > 1
		 ) AS [CurrencyRankingQuery]
	WHERE [CurrencyRank] = 1
ORDER BY [ContinentCode]

-- Problem 16
SELECT
    COUNT(DISTINCT [c].[CountryCode]) AS [Count]
FROM [Countries] [c]
LEFT JOIN [MountainsCountries] [mc] ON [c].[CountryCode] = [mc].[CountryCode]
WHERE [mc].[CountryCode] IS NULL;

-- Problem 17
WITH [CountryPeaks] AS (
    SELECT
        ,[mc].[CountryCode]
        MAX([p].[Elevation]) AS [HighestPeakElevation]
    FROM
        [MountainsCountries] AS [mc]
    JOIN
        [Mountains] AS [m] ON [mc].[MountainId] = [m].[Id]
    JOIN
        [Peaks] AS [p] ON [m].[Id] = [p].[MountainId]
    GROUP BY
        [mc].[CountryCode]
),
[CountryRivers] AS (
    SELECT
        [cr].[CountryCode],
        MAX([r].[Length]) AS [LongestRiverLength]
    FROM
        [CountriesRivers] AS [cr]
    JOIN
        [Rivers] AS [r] ON [cr].[RiverId] = [r].[Id]
    GROUP BY
        [cr].[CountryCode]
)
SELECT TOP (5)
    [c].[CountryName]
    ,[cp].[HighestPeakElevation]
    ,[cr].[LongestRiverLength]
FROM
    [Countries] AS [c]
LEFT JOIN
    [CountryPeaks] AS [cp] ON [c].[CountryCode] = [cp].[CountryCode]
LEFT JOIN
    [CountryRivers] AS [cr] ON [c].[CountryCode] = [cr].[CountryCode]
ORDER BY
    [cp].[HighestPeakElevation] DESC, -- In SQL Server, NULLs are sorted last in DESC order
    [cr].[LongestRiverLength] DESC,
    [c].[CountryName];

-- Problem 18
SELECT TOP (5)[Country]
		,CASE 
			WHEN [PeakName] IS NULL THEN '(no highest peak)'
			ELSE [PeakName]
		END AS [Highest Peak Name]
		,CASE
			WHEN [Elevation] IS NULL THEN 0
			ELSE [Elevation]
		END AS [Highest Peak Elevation]
		,CASE
			WHEN [MountainRange] IS NULL THEN '(no mountain)'
			ELSE [MountainRange]
		END AS [Mountain]
	FROM (
		SELECT 
			[c].[CountryName] AS [Country]
			,[m].[MountainRange]
			,[p].[PeakName]
			,[p].[Elevation]
			,DENSE_RANK() OVER(PARTITION BY [c].[CountryName] ORDER BY [p].[Elevation] DESC) AS [PeakRank]
		FROM [Countries] AS [c]
		LEFT JOIN [MountainsCountries] AS [mc]
			ON [mc].[CountryCode] = [c].[CountryCode]
		LEFT JOIN [Mountains] AS [m]
			ON [mc].[MountainID] = [m].[Id]
		LEFT JOIN [Peaks] AS [p]
			ON [p].[MountainId] = [m].[Id]
		 ) AS [PeakRankingQuery]
	WHERE [PeakRank] = 1
ORDER BY [Country], [Highest Peak Name]