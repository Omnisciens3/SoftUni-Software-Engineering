-- Problem 1
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
BEGIN
    SELECT 
        FirstName,
        LastName
    FROM 
        Employees
    WHERE 
        Salary > 35000
END

EXEC usp_GetEmployeesSalaryAbove35000

-- Problem 2
GO

CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber
    @SalaryThreshold DECIMAL(18, 4)
AS
BEGIN
    SELECT 
        FirstName,
        LastName
    FROM 
        Employees
    WHERE 
        Salary >= @SalaryThreshold
END

EXEC usp_GetEmployeesSalaryAboveNumber @SalaryThreshold = 48100

-- Problem 3
GO 

CREATE PROCEDURE usp_GetTownsStartingWith
    @Prefix NVARCHAR(100)
AS
BEGIN

    SELECT 
        [Name]
    FROM 
        Towns
    WHERE 
        [Name] LIKE @Prefix + '%'
END

-- Problem 4
GO

CREATE PROCEDURE usp_GetEmployeesFromTown
    @TownName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.FirstName,
        e.LastName
    FROM 
        Employees e
    JOIN 
        Addresses a ON e.AddressID = a.AddressID
    JOIN 
        Towns t ON a.TownID = t.TownID
    WHERE 
        t.[Name] = @TownName
END

EXEC usp_GetEmployeesFromTown @TownName = 'Sofia'

-- Problem 5
GO

CREATE FUNCTION ufn_GetSalaryLevel
(
    @salary DECIMAL(18,4)
)
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @salaryLevel NVARCHAR(50)

    IF @salary < 30000
        SET @salaryLevel = 'Low'
    ELSE IF @salary >= 30000 AND @salary <= 50000
        SET @salaryLevel = 'Average'
    ELSE
        SET @salaryLevel = 'High'

    RETURN @salaryLevel
END

GO
DECLARE @salary DECIMAL(18,4) = 13500.00;
SELECT @salary AS Salary, dbo.ufn_GetSalaryLevel(@salary) AS SalaryLevel;

DECLARE @salary2 DECIMAL(18,4) = 43300.00;
SELECT @salary2 AS Salary, dbo.ufn_GetSalaryLevel(@salary2) AS SalaryLevel;

DECLARE @salary3 DECIMAL(18,4) = 125500.00;
SELECT @salary3 AS Salary, dbo.ufn_GetSalaryLevel(@salary3) AS SalaryLevel;

-- Problem 6
GO
CREATE PROCEDURE usp_EmployeesBySalaryLevel
    @SalaryLevel NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.FirstName,
        e.LastName
    FROM 
        Employees e
    WHERE 
        dbo.ufn_GetSalaryLevel(e.Salary) = @SalaryLevel
END

EXEC usp_EmployeesBySalaryLevel @SalaryLevel = 'High'

-- Problem 7
GO
CREATE FUNCTION ufn_IsWordComprised
(
    @setOfLetters NVARCHAR(100),
    @word NVARCHAR(100)
)
RETURNS BIT
AS
BEGIN
    DECLARE @isComprised BIT = 1;
    DECLARE @charCount INT;
    DECLARE @i INT = 1;
    DECLARE @char NVARCHAR(1);

    WHILE @i <= LEN(@word)
    BEGIN
        SET @char = SUBSTRING(@word, @i, 1);

        IF CHARINDEX(@char, @setOfLetters) = 0
        BEGIN
            SET @isComprised = 0;
            BREAK; 
        END

        SET @i = @i + 1;
    END

    RETURN @isComprised
END

GO
DECLARE @result BIT;

SELECT @result = dbo.ufn_IsWordComprised('oistmiahf', 'Sofia');
PRINT @result; -- Output: 1

SELECT @result = dbo.ufn_IsWordComprised('oistmiahf', 'halves');
PRINT @result; -- Output: 0

SELECT @result = dbo.ufn_IsWordComprised('bobr', 'Rob');
PRINT @result; -- Output: 1

SELECT @result = dbo.ufn_IsWordComprised('pppp', 'Guy');
PRINT @result; -- Output: 0

-- Problem 8
GO
CREATE PROCEDURE usp_DeleteEmployeesFromDepartment
    @departmentId INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Employees
    WHERE DepartmentID = @departmentId

    DELETE FROM Departments
    WHERE DepartmentID = @departmentId

    SELECT COUNT(*)
    FROM Employees
    WHERE DepartmentID = @departmentId
END

EXEC usp_DeleteEmployeesFromDepartment @departmentId = 1

-- Problem 9
GO

CREATE PROCEDURE usp_GetHoldersFullName
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
    FROM AccountHolders
END

-- Problem 10
GO

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan
    @totalBalance DECIMAL(18, 4)
AS
BEGIN

    SELECT ah.FirstName, ah.LastName
    FROM AccountHolders ah
    JOIN Accounts a ON ah.Id = a.AccountHolderId
    GROUP BY ah.Id, ah.FirstName, ah.LastName
    HAVING SUM(a.Balance) > @totalBalance
    ORDER BY ah.FirstName, ah.LastName
END

-- Problem 11
GO
CREATE FUNCTION ufn_CalculateFutureValue
(
    @initialSum DECIMAL(18, 4),
    @yearlyInterestRate FLOAT,
    @numberOfYears INT
)
RETURNS DECIMAL(18, 4)
AS
BEGIN
    DECLARE @futureValue DECIMAL(18, 4)

    SET @futureValue = @initialSum * POWER((1 + @yearlyInterestRate), @numberOfYears)

    SET @futureValue = ROUND(@futureValue, 4)

    RETURN @futureValue
END

GO
DECLARE @initialSum DECIMAL(18, 4) = 1000
DECLARE @yearlyInterestRate FLOAT = 0.1
DECLARE @numberOfYears INT = 5
SELECT dbo.ufn_CalculateFutureValue(@initialSum, @yearlyInterestRate, @numberOfYears) AS FutureValue

-- Problem 12
GO

CREATE PROCEDURE usp_CalculateFutureValueForAccount
    @AccountId INT,
    @yearlyInterestRate FLOAT
AS
BEGIN
    SET NOCOUNT ON

    SELECT 
        a.Id AS [Account Id],
        ah.FirstName AS [First Name],
        ah.LastName AS [Last Name],
        a.Balance AS [Current Balance],
        dbo.ufn_CalculateFutureValue(a.Balance, @yearlyInterestRate, 5) AS [Balance in 5 years]
    FROM 
        Accounts a
    JOIN 
        AccountHolders ah ON a.AccountHolderId = ah.Id
    WHERE 
        a.Id = @AccountId
END

EXEC usp_CalculateFutureValueForAccount @AccountId = 1, @yearlyInterestRate = 0.1

-- Problem 13
GO

CREATE FUNCTION ufn_CashInUsersGames
(
    @gameName VARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    WITH RankedGames AS (
        SELECT 
            Cash,
            ROW_NUMBER() OVER (ORDER BY Cash DESC) AS RowNumber
        FROM Games
        WHERE GameName = @gameName
    )
    SELECT SUM(Cash) AS SumCash
    FROM RankedGames
    WHERE RowNumber % 2 <> 0
)

