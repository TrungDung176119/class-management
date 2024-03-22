Create database ClassManagement

use ClassManagement

-- Create the Class table
CREATE TABLE Class (
    ClassID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ClassName NVARCHAR(50),
    ClassStartDate DATE,
    ClassEndDate DATE,
	ClassStatus INT,
);

-- Create the Student table
CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FullName NVARCHAR(100),
    DateOfBirth DATE,
    Gender NVARCHAR(10),
	ContactInfo NVARCHAR(200)
);

-- Create the Attendance table
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ClassID INT,
    StudentID INT,
    AttendanceDate DATE,
    AttendanceStatus INT,
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);

-- Create the Mark table
CREATE TABLE Mark (
    MarkID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
    PaymentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    StudentID INT,
    PaymentDate DATE,
    Amount DECIMAL(10, 2),
    PaymentMethod VARCHAR(50),
	[PaymentStatus] INT
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);

CREATE TABLE [DayOfWeek] (
    DayOfWeekID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [DayName] NVARCHAR(20)
);

CREATE TABLE TimeOfDay (
    TimeOfDayID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    TimeSlot NVARCHAR(50)
);

CREATE TABLE ClassSchedule (
    ClassID INT,
    DayOfWeekID INT,
    TimeOfDayID INT,
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
    FOREIGN KEY (DayOfWeekID) REFERENCES [DayOfWeek](DayOfWeekID),
    FOREIGN KEY (TimeOfDayID) REFERENCES TimeOfDay(TimeOfDayID),
    PRIMARY KEY (ClassID, DayOfWeekID, TimeOfDayID)
);

-- Sample data for DayOfWeek table
INSERT INTO [DayOfWeek] ([DayName])
VALUES
    ('Monday'),
    ('Tuesday'),
    ('Wednesday'),
    ('Thursday'),
    ('Friday'),
	('Saturday'),
    ('Sunday');

-- Sample data for TimeOfDay table
INSERT INTO TimeOfDay (TimeSlot)
VALUES
    ('7:00-9:00'),
    ('9:30-11:30'),
    ('14:00-16:00'),
	('17:00-19:00'),
	('19:30-21:30');

	-- Sample data for Class table
INSERT INTO Class (ClassName, ClassStartDate, ClassEndDate, ClassStatus)
VALUES
    ('Mathematics 101', '2024-03-01', '2024-06-01', 1),
    ('English Literature', '2024-03-05', '2024-05-30', 1),
    ('Computer Science Basics', '2024-03-10', '2024-05-25', 1);

-- Sample data for ClassSchedule table
INSERT INTO ClassSchedule (ClassID, DayOfWeekID, TimeOfDayID)
VALUES
    (1, 1, 1), -- Monday, 9:00-10:30
    (2, 3, 1), -- Wednesday, 9:00-10:30
    (3, 5, 1); -- Friday, 9:00-10:30


-- Sample data for Student table
INSERT INTO Student (FullName, DateOfBirth, Gender, ContactInfo)
VALUES
    ('John Doe', '2000-05-15', 'Male', 'john.doe@example.com, +1234567890'),
    ('Jane Smith', '2001-08-20', 'Female', 'jane.smith@example.com, +1987654321'),
    ('Michael Johnson', '1999-11-10', 'Male', 'michael.johnson@example.com, +1654321890');

-- Sample data for Attendance table
INSERT INTO Attendance (ClassID, StudentID, AttendanceDate, AttendanceStatus)
VALUES
    (1, 1, '2024-03-01', 1),
    (1, 2, '2024-03-01', 1),
    (1, 3, '2024-03-01', 0),
    (1, 1, '2024-03-03', 1),
    (1, 2, '2024-03-03', 1),
    (1, 3, '2024-03-03', 1),
    (2, 1, '2024-03-05', 1),
    (2, 2, '2024-03-05', 1),
    (2, 3, '2024-03-05', 0);

-- Sample data for Mark table
INSERT INTO Mark (ClassID, StudentID, MarkDate, [Subject], Mark)
VALUES
    (1, 1, '2024-03-15', 'Mathematics', 85),
    (1, 2, '2024-03-15', 'Mathematics', 90),
    (1, 3, '2024-03-15', 'Mathematics', 75),
    (2, 1, '2024-03-15', 'English Literature', 88),
    (2, 2, '2024-03-15', 'English Literature', 92),
    (2, 3, '2024-03-15', 'English Literature', 80);

-- Sample data for Payment table
INSERT INTO Payment (StudentID, PaymentDate, Amount, PaymentMethod, PaymentStatus)
VALUES
    (1, '2024-03-10', 500, 'Credit Card', 1),
    (2, '2024-03-10', 500, 'PayPal', 1),
    (3, '2024-03-10', 500, 'Bank Transfer', 0);
