USE master
IF EXISTS (SELECT * FROM Sys.databases WHERE name = 'KhumaloCraftDB')
DROP DATABASE KhumaloCraftDB
CREATE DATABASE KhumaloCraftDB
USE KhumaloCraftDB

-- Create Role table
CREATE TABLE [Role] (
    RoleID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    RoleDesc NVARCHAR(250) NOT NULL
);

-- Insert sample data into Role table
INSERT INTO [Role] (RoleDesc) 
VALUES ('User'),('Admin'), ('Artist');

-- Create User table with FullName, Username, Email, PhoneNumber, Password
CREATE TABLE [User] (
    UserID INT PRIMARY KEY,
    RoleID INT NOT NULL,
    FullName VARCHAR(250) NOT NULL,
    Username VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES [Role](RoleID) 
);


-- Insert sample data into Users table
INSERT INTO [User] (UserID, RoleID, FullName, Username, Email, PhoneNumber, Password)
VALUES
    (1, 1,'User', 'user1', 'user1@example.com', '072-456-7890', 'password1'),
    (2, 1,'Admin', 'user2', 'user2@example.com', '082-654-3210', 'password2');

-- Create Artist table
CREATE TABLE Artists (
    ArtistID INT PRIMARY KEY,
    ArtistName VARCHAR(100) NOT NULL
);

-- Insert sample data into Artists table
INSERT INTO Artists (ArtistID, ArtistName)
VALUES
    (1, 'Artist A'),
    (2, 'Artist B');

-- Create Category table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL
);

-- Insert sample data into Categories table
INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, 'Category X'),
    (2, 'Category Y');

-- Create Product table
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(200) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    CategoryID INT,
    ArtistID INT,
    AvailabilityStatus VARCHAR(50) NOT NULL,
    ImageURL NVARCHAR(MAX),
    ImageName NVARCHAR(MAX),
    Quantity BIT NOT NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID)
);

-- Insert sample data into Product table
INSERT INTO Product (ProductID, ProductName, Description, Price, CategoryID, ArtistID, AvailabilityStatus, ImageURL, ImageName, Quantity)
VALUES
    (1, 'Product 1', 'Description 1', 10.99, 1, 1, 'In Stock', NULL, NULL, 1),
    (2, 'Product 2', 'Description 2', 15.99, 2, 2, 'In Stock', NULL, NULL, 1);

-- Create Transaction table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY,
    UserID INT,
    ProductID INT,
    TransactionDate DATETIME NOT NULL,
    Quantity INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Insert sample data into Transactions table
INSERT INTO Transactions (TransactionID, UserID, ProductID, TransactionDate, Quantity, TotalAmount)
VALUES
    (1, 1, 1, GETDATE(), 2, 21.98),
    (2, 2, 2, GETDATE(), 1, 15.99);

-- Create Login table
CREATE TABLE Login (
    LoginID INT PRIMARY KEY,
    UserID INT UNIQUE,
    Username VARCHAR(250) NOT NULL,
    Password VARCHAR(250) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES [User](UserID)
);

-- Insert sample data into Login table
INSERT INTO Login (LoginID, UserID, Username, Password)
VALUES
    (1, 1, 'user1', 'password1'),
    (2, 2, 'user2', 'password2');

-- Create Payment table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    UserID INT,
    TransactionID INT,
    PaymentAmount DECIMAL(10, 2) NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentStatus VARCHAR(250) NOT NULL,
    FOREIGN KEY (UserID) REFERENCES [User](UserID),
    FOREIGN KEY (TransactionID) REFERENCES Transactions(TransactionID)
);

-- Insert sample data into Payment table
INSERT INTO Payment (PaymentID, UserID, TransactionID, PaymentAmount, PaymentDate, PaymentStatus)
VALUES
    (1, 1, 1, 21.98, GETDATE(), 'Completed'),
    (2, 2, 2, 15.99, GETDATE(), 'Completed');

-- Select product information along with categories and artists
SELECT p.ProductID, p.ProductName, p.Description, p.Price, c.CategoryName, a.ArtistName
FROM Product p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
INNER JOIN Artists a ON p.ArtistID = a.ArtistID;

-- Select transactions for a specific user
SELECT *
FROM Transactions
WHERE UserID = 1;

-- Select data from Login, Role, Users, and Payment tables
SELECT * FROM [Login];
SELECT * FROM [Role]
SELECT * FROM [User];
SELECT * FROM Payment;
