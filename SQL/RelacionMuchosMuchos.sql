-- Active: 1717310365940@@bcqy3edrkgzmicpkse8d-mysql.services.clever-cloud.com@3306@bcqy3edrkgzmicpkse8d
CREATE TABLE Students(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Names VARCHAR(125),
    LastName VARCHAR(125),
    Email VARCHAR(125) UNIQUE
);

CREATE TABLE Courses(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(125),
    Description VARCHAR(125),
    AuthorId INT
);

CREATE TABLE StudentCourses(
    StudentId INT,
    CourseId INT,
    Status ENUM('Activo','Inactivo')
);

ALTER TABLE StudentCourses ADD FOREIGN KEY (StudentId) REFERENCES Students(Id);
ALTER TABLE StudentCourses ADD FOREIGN KEY (CourseId) REFERENCES Courses(Id);

INSERT INTO Students(Names, LastName, Email) VALUES
('John', 'Doe', 'johndoe@example.com'),
('Jane', 'Smith', 'janesmith@example.com'),
('Michael', 'Johnson', 'ichaeljohnson@example.com'),
('Emily', 'Davis', 'emilydavis@example.com'),
('David', 'Miller', 'davidmiller@example.com'),
('Olivia', 'Wilson', 'oliviawilson@example.com'),
('Sophia', 'Anderson', 'ophiaanderson@example.com'),
('Ava', 'Taylor', 'avataylor@example.com'),
('Noah', 'Moore', 'noahmoore@example.com'),
('Liam', 'Thomas', 'liamthomas@example.com');

INSERT INTO Courses(Name, Description, AuthorId) VALUES
('Mathematics', 'Fundamentals of mathematics for beginners.', 1),
('Physics', 'Introduction to classical mechanics and electromagnetism.', 2),
('Chemistry', 'Basic principles of chemistry and its applications.', 3),
('Biology', 'Study of life and living organisms.', 4),
('Computer Science', 'Introduction to programming and computer science.', 5),
('English', 'Grammar, vocabulary, and writing skills.', 6),
('History', 'Exploration of historical events, people, and cultures.', 7);

INSERT INTO StudentCourses(StudentId, CourseId, Status) VALUES
(1, 1, 'Activo'),
(2, 2, 'Activo'),
(3, 3, 'Activo'),
(4, 4, 'Activo'),
(5, 5, 'Activo'),
(6, 6, 'Activo'),
(7, 7, 'Activo'),
(8, 1, 'Activo'),
(9, 2, 'Activo'),
(10, 3, 'Activo');