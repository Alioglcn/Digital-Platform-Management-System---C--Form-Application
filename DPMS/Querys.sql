
Create database DigitalPlatformManagementSystem

use DigitalPlatformManagementSystem

select * from content

CREATE TABLE audience(
   customer_id  INTEGER  NOT NULL PRIMARY KEY
  ,invoice_number  INTEGER  NOT NULL
  ,reviews_id  INTEGER  NOT NULL
  ,first_name   VARCHAR(15) NOT NULL
  ,last_name    VARCHAR(15) NOT NULL
  ,e_mail     VARCHAR(32) NOT NULL
  ,phone_number VARCHAR(12) NOT NULL
  ,state        VARCHAR(19) NOT NULL
  ,Country      VARCHAR(13) NOT NULL
  ,sign_up_date VARCHAR(11) NOT NULL
  ,username VARCHAR(25) NOT NULL
  ,password VARCHAR(25) NOT NULL
);



CREATE TABLE streams (
	Stream_id INT NOT NULL PRIMARY KEY,
	Customer_id INT,
	Content_id INT,
	Stream_date DATE,
	Stream_time VARCHAR(50),
	Stream_duration INT,
	Stream_rating INT
);

CREATE TABLE content(
   content_id      INTEGER  NOT NULL PRIMARY KEY 
   ,actor_id      INTEGER  NOT NULL
   ,af_id      INTEGER  NOT NULL
  ,title           VARCHAR(90) NOT NULL
  ,episode         INTEGER  NOT NULL
  ,genre           VARCHAR(29) NOT NULL
  ,duration        INTEGER  NOT NULL
  ,cost_per_stream VARCHAR(6) NOT NULL
  ,release_date    VARCHAR(11) NOT NULL
  ,distributor     VARCHAR(36) NOT NULL
);

CREATE TABLE bill(
   Invoice_number INTEGER  NOT NULL PRIMARY KEY 
  ,Sign_up_date   VARCHAR(13) NOT NULL
  ,Customer_Plan  VARCHAR(8) NOT NULL
  ,Service_period VARCHAR(25) NOT NULL
  ,Payment_method VARCHAR(15) NOT NULL
  ,Total          VARCHAR(20) NOT NULL
);




CREATE TABLE Reviews(
  Reviews_id INTEGER NOT NULL PRIMARY KEY		
  ,Reviews_title  VARCHAR(25) NOT NULL
  ,Reviews_content VARCHAR(25) NOT NULL
  ,Total          VARCHAR(20) NOT NULL
);

CREATE TABLE Actors(
   Actor_id INTEGER NOT NULL PRIMARY KEY		
  ,actor_name  VARCHAR(25) NOT NULL
  ,age VARCHAR(25) NOT NULL

);

CREATE TABLE additional_features(

   af_id INTEGER NOT NULL PRIMARY KEY		
  ,dubbing_language    VARCHAR(25)  NOT NULL 
  ,subtitle_language  VARCHAR(25) NOT NULL
  ,ThreeD VARCHAR(25) NOT NULL

);



 -- Advance queries
SELECT COUNT(*) FROM additional_features WHERE subtitle_language = 'no' AND dubbing_language = 'no' AND ThreeD = 'yes';

SELECT TOP 1 customer_plan, COUNT(*) AS how_many
FROM bill
GROUP BY customer_plan
ORDER BY how_many DESC;



SELECT DISTINCT c.first_name, c.last_name 
FROM audience c
LEFT JOIN streams s ON c.customer_id = s.customer_id
WHERE s.stream_date >= DATEADD(MONTH, -6, GETDATE());


SELECT TOP 1 *
FROM content
ORDER BY episode DESC;


SELECT TOP 1 *
FROM streams
ORDER BY stream_time DESC;


SELECT TOP 1 *
FROM actors
ORDER BY age ASC;


SELECT TOP 1 b.customer_plan
FROM reviews r
JOIN bill b ON r.reviews_id = b.invoice_number
GROUP BY b.customer_plan
ORDER BY
    MIN(CASE WHEN r.Total = '1 star' THEN 1
             WHEN r.Total = '2 stars' THEN 2
             WHEN r.Total = '3 stars' THEN 3
             WHEN r.Total = '4 stars' THEN 4
             WHEN r.Total = '5 stars' THEN 5
              
        END) ASC;