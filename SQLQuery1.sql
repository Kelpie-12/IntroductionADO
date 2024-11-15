USE PD_311_HW;
GO
UPDATE Groups
SET  direction='5',
learning_form='1',
learning_time = '14:00',
learning_days = '0' ,
start_date = '2024-11-10' 

WHERE group_name='PD_4'
