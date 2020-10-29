-- drop table people;
-- drop table charactertype;

-- creating the type of person --
create table charactertype
(
	id serial primary key,
	chartype varchar(15)
);

-- creating the people table --
create table people
(
	id serial primary key,
	name varchar(100) not null,
	address varchar(200) not null,
    password varchar(200) not null,
	chartype int references charactertype (id)
);

-- inserting seed data --
insert into charactertype (chartype) values 
('Customer'), 
('Manager');

insert into people (name, address, password, chartype) values
('John Barr', '453 CA','12345', 1),
('Steve Smith', '123 NY','hello', 1),
('Larry Jo', '276 NY','password', 2),
('Ben Cor', '841 CA','mypassword', 2);
