CREATE DATABASE GAME;
USE GAME;

CREATE TABLE PALAVRA
(
  idPalavra int not null identity primary key,
  Palavra varchar(45) not null,
  Dica varchar(45) not null
);
INSERT INTO PALAVRA (Palavra, Dica) Values('gato', 'Animal dom�stico');
INSERT INTO PALAVRA (Palavra, Dica) Values('maracuja', 'Fruta de cor amarela');
INSERT INTO PALAVRA (Palavra, Dica) Values('engenharia', 'Profissional que constroem coisas');
INSERT INTO PALAVRA (Palavra, Dica) Values('margarida', 'Flor');
INSERT INTO PALAVRA (Palavra, Dica) Values('ornitorrinco', 'Animal mam�fero que bota ovos');
INSERT INTO PALAVRA (Palavra, Dica) Values('feij�o', 'Faz parte dos vegetais leguminosos');
INSERT INTO PALAVRA (Palavra, Dica) Values('Carnaval', 'Festa t�pica do Brasil, com origem africana');
INSERT INTO PALAVRA (Palavra, Dica) Values('helicoptero', 'Transporte a�reo');
INSERT INTO PALAVRA (Palavra, Dica) Values('tupi-guarani', 'Faz parte das "l�nguas mortas"');
INSERT INTO PALAVRA (Palavra, Dica) Values('otorrinolaringologista', 'Especialidade M�dica');
Select * from PALAVRA;


CREATE TABLE USUARIO
(
 idUsuario int not null identity primary key,
 Nome varchar(45) not null,
 Fase int not null
);
INSERT INTO USUARIO (Nome, Fase) VALUES ('Teste', '1');
INSERT INTO USUARIO (Nome, Fase) VALUES ('Guilherme', '10');
SELECT * FROM USUARIO;