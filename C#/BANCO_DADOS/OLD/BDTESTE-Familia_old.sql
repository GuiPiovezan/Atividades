CREATE DATABASE BDTESTE;
USE BDTESTE;
create table tbAluno(
	idAluno int identity primary key not null,
	rm varchar(5) not null,
	nome varchar(70) not null,
	cidade varchar(40) not null
);

insert into tbAluno (rm, nome, cidade) values ('30191', 'Guilherme Aparecido Ferreira Piovezan', 'Jos� Bonif�cio');

create table tbProfessor(
	idProf int identity primary key not null,
	nome varchar(70) not null,
	telefone varchar(12) not null,
	email varchar(50) not null,
	area varchar(30) not null,
	cpf varchar(15) not null,
	rg varchar(15) not null
);
insert into tbProfessor (nome, telefone, email, area, cpf, rg) values ('Cl�vis Machado', '991380595', 'clovis.machado@etec.sp.gov.br', 'GSOII', '48502555820', '89854541');


Drop Table tbAluno;
Drop Table tbProfessor;

Select * from tbAluno;
Select * from tbProfessor;