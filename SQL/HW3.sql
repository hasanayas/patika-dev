--1
SELECT * FROM country
WHERE country LIKE 'A%a'
ORDER BY country;


--2
SELECT * FROM country
WHERE length(country) >=6 AND country LIKE '%n'
ORDER BY country;


--3
SELECT * FROM film
WHERE title ILIKE '%T%T%T%T%'
ORDER BY title;


--4
SELECT * FROM film
WHERE title LIKE 'C%' AND length(title) >90 AND rental_rate = 2.99
ORDER BY title;