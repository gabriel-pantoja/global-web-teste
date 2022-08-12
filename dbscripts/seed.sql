\connect db
CREATE TABLE Client
(
 Id serial PRIMARY KEY,
 FullName VARCHAR (250) NOT NULL,
 BirthDate DATE NOT NULL,
 Document VARCHAR (20) NOT NULL,
 Address VARCHAR (250) NOT NULL,
 DateRegister TIMESTAMP NOT NULL,
 Active BOOLEAN NOT NULL
);

Insert into Client(
    FullName,BirthDate, Document, 
    Address, DateRegister, Active
    ) values( 'Guilherme Enrico Pietro Nascimento','2001-01-08', 
    '08276305903', 'Quadra SGAN 914 Módulo C', '2022-08-12', true);