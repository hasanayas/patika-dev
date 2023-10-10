--1
CREATE TABLE employee
(
	id SERIAL PRIMARY KEY,
	name VARCHAR(100) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);

--2
INSERT INTO employee (name, birthday, email) VALUES
('Mehmet', '1992-09-12', 'mehmet@test.com'),
('Ahmet', '1995-09-08', 'ahmet@test.com'),
('Ayşe', '1994-05-03', 'ayse@test.com'),
('Fatma', '1994-10-08', 'fatma@test.com'),
('Mustafa', '2001-08-24', 'mustafa@test.com'),
('İsmail', '2003-02-08', 'ismail@test.com'),
('Zeynep', '1982-01-02', 'zeynep@test.com'),
('Gül', '1996-07-06', 'gul@test.com'),
('Ali', '1991-01-27', 'ali@test.com'),
('Ayhan', '1997-03-21', 'ayhan@test.com'),
('Merve', '1994-02-20', 'merve@test.com'),
('Emre', '1983-12-09', 'emre@test.com'),
('Aylin', '1990-02-25', 'aylin@test.com'),
('Burak', '1989-06-21', 'burak@test.com'),
('Derya', '2000-04-12', 'derya@test.com'),
('Ceren', '1983-01-27', 'ceren@test.com'),
('Eren', '2000-01-17', 'eren@test.com'),
('Elif', '1988-12-03', 'elif@test.com'),
('Aysun', '1990-06-18', 'aysun@test.com'),
('Esra', '1991-12-08', 'esra@test.com'),
('Oğuz', '2000-07-30', 'oguz@test.com'),
('Yasin', '1996-05-26', 'yasin@test.com'),
('Tugay', '1989-06-05', 'tugay@test.com'),
('Ege', '2002-12-23', 'ege@test.com'),
('Burcu', '2000-09-02', 'burcu@test.com'),
('Deniz', '1992-03-30', 'deniz@test.com'),
('Emir', '1996-01-02', 'emir@test.com'),
('Gonca', '1991-09-20', 'gonca@test.com'),
('Aslı', '2000-03-13', 'asli@test.com'),
('Tarkan', '1999-09-26', 'tarkan@test.com'),
('Serap', '1996-05-22', 'serap@test.com'),
('Canan', '1994-12-15', 'canan@test.com'),
('Kerem', '1996-08-11', 'kerem@test.com'),
('Burak', '2002-04-04', 'burak@test.com'),
('Ebru', '1991-06-10', 'ebru@test.com'),
('Aylin', '2001-02-02', 'aylin@test.com'),
('Emine', '1992-06-07', 'emine@test.com'),
('Levent', '2003-07-27', 'levent@test.com'),
('Rıza', '1986-07-17', 'riza@test.com'),
('Erdem', '1994-09-29', 'erdem@test.com'),
('Elif', '1981-05-15', 'elif@test.com'),
('Kerem', '1995-03-15', 'kerem@test.com'),
('Pelin', '1983-01-18', 'pelin@test.com'),
('Mustafa', '1986-07-19', 'mustafa@test.com'),
('Melike', '1995-10-09', 'melike@test.com'),
('Aysel', '1992-05-26', 'aysel@test.com'),
('Recep', '1998-06-23', 'recep@test.com'),
('Cem', '1995-01-20', 'cem@test.com'),
('Uğur', '2000-01-17', 'ugur@test.com'),
('Deniz', '2002-07-29', 'deniz@test.com');


--3
UPDATE employee
SET name = 'Ali'
WHERE id = 1;


UPDATE employee
SET birthday = '1996-11-15'
WHERE id = 2;


UPDATE employee
SET email = 'ahmet@ornek.com'
WHERE id = 3;


UPDATE employee
SET name = 'Ahmet',
	birthday = '1999-08-09',
	email = 'Ahmet@ornek.com'
WHERE id = 45;


UPDATE employee
SET name = 'Elif'
WHERE id = 40;




--4

DELETE FROM employee
WHERE id = 4;


DELETE FROM employee
WHERE id = 6;


DELETE FROM employee
WHERE birthday = '1994-10-08';


DELETE FROM employee
WHERE birthday = '1994-10-08';


DELETE FROM employee
WHERE name = 'Ahmet';
