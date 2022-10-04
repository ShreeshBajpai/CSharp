create database election
use election

create table admin_user(id int, pass nvarchar(20), aadhar bigint, voter_id nvarchar(20) primary key, mpin int )

insert into admin_user values (1, 'abc123', 726987675645, 'UK07AS00111232', 1966)--
insert into admin_user values (2, 'xyz123', 726987675645, 'UK07AS00115263', 5678) --
insert into admin_user values (3, 'pqr123', 726987675645, 'UK07AS00114526', 4567)--
insert into admin_user values (4, 'abc123', 726987675645, 'UK07AS00116788', 9845)
insert into admin_user values (5, 'mno123', 726987675645, 'UK07AS00119862', 5678)
insert into admin_user values (6, 'lmn123', 726987675645, 'UK07AS00115462', 4657)
insert into admin_user values (7, 'abc123', 726987675645, 'UK07AS00114590', 0986)
insert into admin_user values (8, 'pqr123', 726987675645, 'UK07AS00111025', 8765)--
insert into admin_user values (9, 'mno123', 726987675645, 'UK07AS00118471', 1234)

select * from admin_user
drop table admin_user

create table constituency (id int primary key, c_name nvarchar(20))

insert into constituency values (313, 'Dehradun')
insert into constituency values (413, 'Noida')
insert into constituency values (513, 'Rishikesh')
insert into constituency values (613, 'Lucknow')
insert into constituency values (713, 'Bengaluru')
insert into constituency values (813, 'Mumbai')
insert into constituency values (910, 'Delhi')
insert into constituency values (810, 'Gurgaon')
insert into constituency values (710, 'Moradabad')
insert into constituency values (610, 'Gorakhpur')
insert into constituency values (510, 'Roorkee')
insert into constituency values (410, 'Haldwani')

select * from constituency
drop table constituency

create table candidate (candidate_id int primary key, candidate_name nvarchar(20), constituency_id int not null, CONSTRAINT fk_cand_const 
FOREIGN KEY (constituency_id)  
REFERENCES constituency (id), party nvarchar(10))

insert into candidate values (101, 'Shreesh', 313, 'BJP')
insert into candidate values (102, 'Abhijeet', 313, 'INC')
insert into candidate values (103, 'Bhanu', 513, 'NCP')
insert into candidate values (104, 'Abhishek', 813, 'BJP')
insert into candidate values (105, 'Nitin', 713, 'BJP')
insert into candidate values (106, 'Sajal', 713, 'INC')
insert into candidate values (107, 'Shivani', 813, 'BJP')
insert into candidate values (108, 'Mohit', 313, 'AAP')
insert into candidate values (109, 'Pawan', 710, 'BJP')
insert into candidate values (110, 'Purvesh', 810, 'INC')
insert into candidate values (111, 'Shresth', 313, 'MNC')
insert into candidate values (112, 'Stuti', 713, 'TMC')

insert into candidate values (113, 'Ishita', 413, 'BJP')
insert into candidate values (114, 'Priyanshi', 613, 'INC')
insert into candidate values (115, 'Anamika', 410, 'BJP')
insert into candidate values (116, 'Hritik', 510, 'INC')
insert into candidate values (117, 'Sawant', 610, 'BJP')
insert into candidate values (118, 'Abhijeet', 910, 'INC')
insert into candidate values (119, 'Sejal', 413, 'INC')
insert into candidate values (120, 'Shubh', 613, 'BJP')
insert into candidate values (121, 'Anu', 410, 'INC')
insert into candidate values (122, 'candiate 1', 810, 'BJP')

--delete from candidate where candidate_id=123 and party='INC'
select * from candidate where party='BJP' and constituency_id=810

select * from candidate

create table voting(voter_id nvarchar(20) not null, CONSTRAINT fk_vote_user 
FOREIGN KEY (voter_id)  
REFERENCES admin_user (voter_id), 
constituency_id int not null, CONSTRAINT fk_vote_cand 
FOREIGN KEY (constituency_id)  
REFERENCES constituency (id), vote_id int IDENTITY(1,1), voting_party nvarchar(10))


insert into voting values ('UK07AS00111232', 313,'BJP')
insert into voting values ('UK07AS00115263', 413,'MNC')
insert into voting values ('UK07AS00114526', 513,'INC')
insert into voting values ('UK07AS00111025', 810,'BJP') --UK07AS00116788
insert into voting values ('UK07AS00116788', 810,'BJP')
insert into voting values ('UK07AS00114526', 810,'INC')
insert into voting values ('UK07AS00114526', 810,'INC')
insert into voting values ('UK07AS00114526', 810,'INC')



use election
select * from voting
select * from candidate where constituency_id=810

SELECT COUNT(vote_id) as total_of_bjp FROM voting WHERE voting_party='BJP' and constituency_id=810;
