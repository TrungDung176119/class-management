Create database ClassManagement

use ClassManagement

-- Create the Class table
CREATE TABLE Class (
    ClassID INT PRIMARY KEY,
    ClassName NVARCHAR(50),
    ClassStartDate DATE,
    ClassEndDate DATE,
    Schedule NVARCHAR(50),
	ClassStatus INT,
);

-- Create the Student table
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    FullName NVARCHAR(100),
    DateOfBirth DATE,
    Gender NVARCHAR(10),
	ContactInfo NVARCHAR(200)
);

-- Create the Attendance table
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY,
    ClassID INT,
    StudentID INT,
    AttendanceDate DATE,
    AttendanceStatus INT,
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);

-- Create the Mark table
CREATE TABLE Mark (
    MarkID INT PRIMARY KEY,
    ClassID INT,
    StudentID INT,
    MarkDate DATE,
    [Subject] VARCHAR(100),
    Mark DECIMAL(5, 2),
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);

-- Create the Payment table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    StudentID INT,
    PaymentDate DATE,
    Amount DECIMAL(10, 2),
    PaymentMethod VARCHAR(50),
	[PaymentStatus] INT
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);

-- Sample data for Class table
INSERT INTO Class (ClassID, ClassName, ClassStartDate, ClassEndDate, Schedule, ClassStatus)
VALUES
    (1, 'Mathematics 101', '2024-03-01', '2024-06-01', 'Monday/Wednesday/Friday 9:00-10:30', 1),
    (2, 'English Literature', '2024-03-05', '2024-05-30', 'Tuesday/Thursday 11:00-12:30', 1),
    (3, 'Computer Science Basics', '2024-03-10', '2024-05-25', 'Monday/Wednesday 13:00-14:30', 1);

-- Sample data for Student table
INSERT INTO Student (StudentID, FullName, DateOfBirth, Gender, ContactInfo)
VALUES
    (1, 'John Doe', '2000-05-15', 'Male', 'john.doe@example.com, +1234567890'),
    (2, 'Jane Smith', '2001-08-20', 'Female', 'jane.smith@example.com, +1987654321'),
    (3, 'Michael Johnson', '1999-11-10', 'Male', 'michael.johnson@example.com, +1654321890');

-- Sample data for Attendance table
INSERT INTO Attendance (AttendanceID, ClassID, StudentID, AttendanceDate, AttendanceStatus)
VALUES
    (1, 1, 1, '2024-03-01', 1),
    (2, 1, 2, '2024-03-01', 1),
    (3, 1, 3, '2024-03-01', 0),
    (4, 1, 1, '2024-03-03', 1),
    (5, 1, 2, '2024-03-03', 1),
    (6, 1, 3, '2024-03-03', 1),
    (7, 2, 1, '2024-03-05', 1),
    (8, 2, 2, '2024-03-05', 1),
    (9, 2, 3, '2024-03-05', 0);

-- Sample data for Mark table
INSERT INTO Mark (MarkID, ClassID, StudentID, MarkDate, [Subject], Mark)
VALUES
    (1, 1, 1, '2024-03-15', 'Mathematics', 85),
    (2, 1, 2, '2024-03-15', 'Mathematics', 90),
    (3, 1, 3, '2024-03-15', 'Mathematics', 75),
    (4, 2, 1, '2024-03-15', 'English Literature', 88),
    (5, 2, 2, '2024-03-15', 'English Literature', 92),
    (6, 2, 3, '2024-03-15', 'English Literature', 80);

-- Sample data for Payment table
INSERT INTO Payment (PaymentID, StudentID, PaymentDate, Amount, PaymentMethod, PaymentStatus)
VALUES
    (1, 1, '2024-03-10', 500, 'Credit Card', 1),
    (2, 2, '2024-03-10', 500, 'PayPal', 1),
    (3, 3, '2024-03-10', 500, 'Bank Transfer', 0);
