create Database Project;
use Project;

 

create table patient (
id int primary key auto_increment,
other_id varchar(255),
name varchar(50),
telephone varchar(10),
mobile varchar(10),
fax varchar(10),
other_telephone varchar(10),
email varchar(70),
sex varchar(15),
birth_date varchar(30),
process_number varchar(255),
postal_code varchar(10),
postal_area varchar(10),
locality varchar(30),
postal_code_id varchar(255),
address varchar(50),
town varchar(50),
postal_code_full varchar(255),
nif varchar(9),
sns varchar(9)
);

 

create table module (
id int primary key auto_increment,
patient_id int,
episode varchar(255),
module varchar(255),
foreign key (patient_id) references patient(id)
);