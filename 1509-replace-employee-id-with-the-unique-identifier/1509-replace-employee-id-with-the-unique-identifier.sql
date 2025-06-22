# Write your MySQL query statement below
Select emp.name ,
 E.unique_id 
 From Employees  emp
 Left join EmployeeUNI  E  on emp.id  = E.id
