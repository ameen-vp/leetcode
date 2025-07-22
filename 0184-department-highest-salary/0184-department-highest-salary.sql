# Write your MySQL query statement below
select D.name As Department ,
E.name As Employee 
,E.salary As Salary
from Employee E
join Department  D on E.departmentId  = D.id
WHERE 
    e.salary = (
        SELECT MAX(salary)
        FROM Employee
        WHERE departmentId = e.departmentId
    );