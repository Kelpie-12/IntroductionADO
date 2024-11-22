use PD_311_HW;
go
select last_name, first_name, birth_date, group_name, direction_name
from Students, Groups, Directions
where [group]=group_id and direction = direction_id
 
