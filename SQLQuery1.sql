
--IF NOT EXISTS (select group_id from Groups where group_name=@group_name) 
--BEGIN 
--INSERT  
--		Groups(group_name, [start_date],learning_time, direction, learning_form, learning_days) 
--VALUES	('@group_name',  '@start_date', '@learning_time', '@direction', '@learnig_form',  '@learning_days' ) 
--END

IF NOT EXISTS (select group_id from Groups where group_name='SD_311') BEGIN 
INSERT  
		Groups(group_name, [start_date],learning_time, direction, learning_form, learning_days) 
VALUES	('SD_311',  '18.11.2024 15:22:12', '15:22:12.6795145', '2', '1',  '21' ) end