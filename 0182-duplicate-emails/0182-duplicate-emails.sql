# Write your MySQL query statement below
select email
from Person
Group by Email
having count(Email) > 1;