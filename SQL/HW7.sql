--1
SELECT rating, COUNT(*) FROM film GROUP BY rating;

--2
SELECT replacement_cost,COUNT(*) 
FROM film GROUP BY replacement_cost 
HAVING COUNT(*)>50 
ORDER BY replacement_cost, COUNT(*);

--3
SELECT store_id, COUNT(*) FROM customer 
GROUP BY store_id;

--4
SELECT country_id,COUNT(city) FROM city 
GROUP BY country_id 
ORDER BY COUNT(city) DESC;