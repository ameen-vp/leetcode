/* Write your T-SQL query statement below */
select C.name As Customers 
From Customers C
Left  Join Orders O  on C.id = O.customerId 
where O.id Is null
