/* Write your T-SQL query statement below */
select
 p.lastName ,
 p.firstName,
 A.city,
 A.state
from Person P 
Left join Address A on P.personId = A.personId 