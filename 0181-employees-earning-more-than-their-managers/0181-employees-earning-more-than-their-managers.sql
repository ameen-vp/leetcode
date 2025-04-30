/* Write your T-SQL query statement below */
select E.name As Employee
From Employee E
join Employee M on E.managerId = M.id
where E.salary > M.salary;

