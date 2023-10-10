--1
SELECT first_name FROM actor
UNION ALL
SELECT first_name FROM customer;

--2
SELECT first_name FROM actor
INTERSECT
SELECT first_name FROM customer;

--3
SELECT first_name FROM actor
EXCEPT
SELECT first_name FROM customer;


-- Tekrar eden veriler için her bir sorguyu tekrar etme

--1
SELECT first_name, COUNT(*) 
FROM (
    SELECT first_name FROM actor
    UNION ALL
    SELECT first_name FROM customer
) AS combined_names
GROUP BY first_name
HAVING COUNT(*) > 1;

--2
SELECT first_name, COUNT(*) 
FROM (
    SELECT first_name FROM actor
    INTERSECT
    SELECT first_name FROM customer
) AS common_names
GROUP BY first_name
HAVING COUNT(*) > 1;


--3
SELECT first_name, COUNT(*) 
FROM (
    SELECT first_name FROM actor
    EXCEPT
    SELECT first_name FROM customer
) AS actor_only_names
GROUP BY first_name
HAVING COUNT(*) > 1;
