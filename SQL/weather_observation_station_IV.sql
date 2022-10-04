/* Question
Find the difference between the total number of CITY entries in the table and the number of distinct CITY entries in the table.

## Input Format
+-------------+--------------+
| Field       | Type         |
+-------------+--------------+
| ID          | NUMBER       |
| CITY        | VARCHAR2(21) |
| STATE       | VARCHAR2(2)  |
| LAT_N       | NUMBER       |
| LONG_W      | NUMBER       |
+-------------+--------------+
*/

SELECT 
    COUNT(CITY) - COUNT(DISTINCT CITY) 
FROM STATION;
