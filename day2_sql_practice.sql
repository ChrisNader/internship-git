CREATE DATABASE practice;
USE practice;

CREATE TABLE students (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    age INT,
    city VARCHAR(50)
);

INSERT INTO students VALUES (1, 'Chris', 25, 'Alexandria');
INSERT INTO students VALUES (2, 'Sara', 22, NULL);
INSERT INTO students VALUES (3, 'Omar', 30, 'Cairo');

SELECT * FROM students;
SELECT * FROM students WHERE city IS NOT NULL ORDER BY age;

SELECT * FROM students ORDER BY age DESC;
SELECT name, city FROM students WHERE age > 23;

SELECT * FROM students WHERE name LIKE 'C%';
SELECT * FROM students WHERE city IN ('Cairo', 'Alexandria');
SELECT * FROM students WHERE age BETWEEN 20 AND 28;

UPDATE students SET city = 'Giza' WHERE name = 'Sara';
DELETE FROM students WHERE id = 3;
SELECT * FROM students;

INSERT INTO students VALUES (4, 'Layla', 28, NULL);
SELECT * FROM students WHERE city IS NULL;
SELECT * FROM students WHERE city IS NOT NULL;