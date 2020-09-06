CREATE DATABASE BDVENDAS;
/* Base da Dados referente a disciplina de TLBD baseado no livro
de MACHADO, Felipe N. R., ABREU, Mauricio P., Projeto de Banco de Dados. 12 ed. Érica.
Exemplo do BD - pg. 201
*/


/* Criando a Tabela Cliente */
create table cliente
( codigo_cliente 	integer not null,
  nome_cliente 		varchar(40),
  endereco		varchar(50),
  cidade		varchar(30),
  cep			char(10),
  uf			char(2),
  cgc			char(16),
  ie 			char(20),
  constraint pk_codigo_cliente primary key (codigo_cliente)
);

/* Criando a Tabela Vendedor*/
create table vendedor 
( codigo_vendedor 	integer not null,
  nome_vendedor 	varchar(40),
  salario_fixo  	numeric(10,2),
  faixa_comissao	char(1),
  constraint pk_codigo_vendedor primary key(codigo_vendedor)
);

/* Criando a Tabela Pedido */
create table pedido
( num_pedido 		integer not null,
  prazo_entrega		smallint not null,
  codigo_cliente	integer not null,
  codigo_vendedor	integer not null,
  constraint pk_num_pedido primary key (num_pedido),
  constraint fk_num_pedio foreign key (codigo_cliente) references cliente,
  constraint fk_codigo_vendedor foreign key (codigo_vendedor) references vendedor
);

/* Criando a Tabela Produto */
create table produto
( codigo_produto 	integer not null,
  unidade		char(3),
  descricao_produto	varchar(30),
  val_unit		numeric(10,2),
  constraint pk_produto primary key (codigo_produto)
);

/* Criando a Tabela Item do Pedido */
create table item_do_pedido
( num_pedido		integer not null,
  codigo_produto 	integer not null,
  quantidade 		numeric(10,2),
  constraint pk_item_pedido primary key (num_pedido,codigo_produto),
  constraint fk_num_pedido foreign key (num_pedido) references pedido,
  constraint fk_codigo_produto foreign key (codigo_produto) references produto
);


/*-- INSERINDO DADOS NAS TABELAS --*/	


/* Inserindo Dados na Tabela Cliente*/

insert into cliente
values (720,'Ana','Rua 17 n. 19','Niterói','24358310','RJ','12113231/0001-34','2134');

insert into cliente
values (870,'Flávio','Av Pres. Vargas 10', 'São Paulo','22763931','SP','22534126/9387-9','4631');

insert into cliente (codigo_cliente,nome_cliente,endereco,cidade,cep,uf,cgc)
values (110,'Jorge','Rua Caiapo 13','Curitiba','30078500','PR','14512764/9834-9');

insert into cliente
values (222,'Lúcia','Rua Itabira 123 Loja 9','Belo 

Horizonte','22124391','MG','28315213/9348-8','2985');

insert into cliente
values (830,'Maurício','Av.Paulista 1236 sl/2345','São Paulo','3012683','SP','32816985/7465-6','9343');

insert into cliente
values (130,'Edmar','Rua da Praia sn/','Salvador','30079300','BA','23463284/234-9','7121');

insert into cliente
values (410,'Rodolfo','Largo da Lapa 27 sobrado','Rio de Janeiro','30078900','RJ','12835128/2346-9','7431');

insert into cliente
values (20,'Beth','Av. Climério n. 45','São Paulo','25679300','SP','32485126/7326-8','9280');

insert into cliente (codigo_cliente,nome_cliente,endereco,cidade,uf,cgc,ie)
values (157,'Paulo','Tv Moraes c/3','Londrina','PR','32848223/324-2','1923');

insert into cliente (codigo_cliente,nome_cliente,endereco,cidade,cep,uf,cgc)
values (180,'Lívio','Av. Beira Mar n. 1256','Florianópolis','30077500','SC','12736571/2347-4');

insert into cliente
values (260,'Susana','Rua Lopes Mendes n. 12','Niterói','30046500','RJ','21763571/232-9','2530');

insert into cliente
values (290,'Renato','Rua Meireles n. 123 bl.2 sl.345','São Paulo','30225900','SP','13276571/1231-4','1820');

insert into cliente
values (390,'Sebastião','Rua da Igreja n. 10','Uberaba','30438700','MG','32176547/213-3','9071');

insert into cliente
values (234,'José','Quadra 3 bl. 3 sl. 1003','Brasília','22841650','DF','21763576/1232-3','2931');


/* Inserindo Dados na Tabela Vendedor*/

insert into vendedor values (209,'José',1800.00,'C');

insert into vendedor values (111,'Carlos',2490.00,'A');

insert into vendedor values (11,'João',2780.00,'C');

insert into vendedor values (240,'Antônio',9500.00,'C');

insert into vendedor values (720,'Felipe',4600.00,'A');

insert into vendedor values (213,'Jonas',2300.00,'A');

insert into vendedor values (101,'João',2650.00,'C');

insert into vendedor values (310,'Josias',870.00,'B');

insert into vendedor values (250,'Maurício',2930.00,'C');


/* Inserindo Dados na Tabela Pedido*/

insert into pedido values (121,20,410,209);

insert into pedido values (97,20,720,101);

insert into pedido values (101,15,720,101);

insert into pedido values (137,20,720,720);

insert into pedido values (148,20,720,101);

insert into pedido values (189,15,870,213);

insert into pedido values (104,30,110,101);

insert into pedido values (203,30,830,250);

insert into pedido values (98,20,410,209);

insert into pedido values (143,30,20,111);

insert into pedido values (105,15,180,240);

insert into pedido values (111,20,260,240);

insert into pedido values (103,20,260,11);

insert into pedido values (91,20,260,11);

insert into pedido values (138,20,260,11);

insert into pedido values (108,15,290,310);

insert into pedido values (119,30,390,250);

insert into pedido values (127,10,410,11);



/* Inserindo Dados na Tabela Produto */

insert into produto values (25,'Kg','Queijo',0.97);

insert into produto values (31,'BAR','Chocolate',0.87);

insert into produto values (78,'L','Vinho',2.00);

insert into produto values (22,'M','Linho',0.11);

insert into produto values (30,'SAC','Açúcar',0.30);

insert into produto values (53,'M','Linha',1.80);

insert into produto values (13,'G','Ouro',6.18);

insert into produto values (45,'M','Madeira',0.25);

insert into produto values (87,'M','Cano',1.97);

insert into produto values (77,'M','Papel',1.05);


/* Inserindo Dados na Tabela Item do Pedido */

insert into item_do_pedido values (121,25,10);

insert into item_do_pedido values (121,31,35);

insert into item_do_pedido values (97,77,20);

insert into item_do_pedido values (101,31,9);

insert into item_do_pedido values (101,78,18);

insert into item_do_pedido values (101,13,5);

insert into item_do_pedido values (98,77,5);

insert into item_do_pedido values (148,45,8);

insert into item_do_pedido values (148,31,7);

insert into item_do_pedido values (148,77,3);

insert into item_do_pedido values (148,25,10);

insert into item_do_pedido values (148,78,30);

insert into item_do_pedido values (104,53,32);

insert into item_do_pedido values (203,31,6);

insert into item_do_pedido values (189,78,45);

insert into item_do_pedido values (143,31,20);

insert into item_do_pedido values (143,78,10);

insert into item_do_pedido values (105,78,10);

insert into item_do_pedido values (111,25,10);

insert into item_do_pedido values (111,78,70);

insert into item_do_pedido values (103,53,37);

insert into item_do_pedido values (91,77,40);

insert into item_do_pedido values (138,22,10);

insert into item_do_pedido values (138,77,35);

insert into item_do_pedido values (138,53,18);

insert into item_do_pedido values (108,13,17);

insert into item_do_pedido values (119,77,40);

insert into item_do_pedido values (119,13,6);

insert into item_do_pedido values (119,22,10);

insert into item_do_pedido values (119,53,43);

insert into item_do_pedido values (137,13,8);



/* Salvando os Dados Inseridos */

/*commit;*/


/* Fim */

/*EXERCÍCIOS*/

/*1. Selecione os campos nome do cliente, endereço e estado de todos os clientes*/
SELECT nome_cliente, endereco, uf from CLIENTE;

/*Liste todos os vendedores.*/
SELECT * FROM VENDEDOR;

/*3. Liste os campos código do produto e quantidade da tabela Item do Pedido. */
SELECT QUANTIDADE, CODIGO_PRODUTO FROM item_do_pedido;

/*Liste o campo “código do cliente” da tabela pedidos e elimine as linhas duplicadas.*/
SELECT  DISTINCT (CODIGO_CLIENTE)  FROM CLIENTE;

/*5. Selecione os campos código do produto, descrição do produto e valor unitário e altere a linha de cabeçalho dos campos selecionados*/
SELECT CODIGO_PRODUTO AS "CÓDIGO DO PRODUTO", DESCRICAO_PRODUTO AS "DESCRIÇÃO DO PRODUTO", VAL_UNIT AS "VALOR UNITARIO" FROM PRODUTO;

/*6. Faça uma consulta que mostre o nome do cliente e estado e altere a linha de cabeçalho dos campos selecionados*/
SELECT NOME_CLIENTE AS "NOME DO CLIENTE", UF AS "ESTADO" FROM CLIENTE;

/*7. Quais são as cidades que a empresa possui clientes? */
SELECT DISTINCT (CIDADE) FROM CLIENTE;

/*8. Liste da tabela produto o campo Descrição e faça o produto do campo valor unitário por 1,3. */
SELECT DESCRICAO_PRODUTO,val_unit*1.3 AS"VALOR UNITÁRIO" FROM PRODUTO;

/*9. Elabore uma consulta que mostre o código do cliente e mostre o prazo de entrega prorrogado por mais 3 dias da tabela pedido. */
SELECT CODIGO_CLIENTE,PRAZO_ENTREGA AS"PRAZO DE ENTREGA", PRAZO_ENTREGA*3 AS "PRORROGAÇÃO DE PRAZO ENTREGA" FROM pedido;

/*10. Liste o nome do vendedor e faixa de comissão dos vendedores que possuem o salário fixo maior que R$ 4.000,00.*/
SELECT NOME_VENDEDOR, FAIXA_COMISSAO FROM VENDEDOR WHERE SALARIO_FIXO>4000;

/*11. Selecione os produtos cuja unidade do produto seja igual a kg.*/
SELECT * FROM PRODUTO WHERE UNIDADE = 'KG';

/*12. Faça uma consulta que mostre o nome do cliente e a cidade quando o estado for igual a SP ou cidade igual a Londrina da tabela cliente*/
SELECT NOME_CLIENTE, CIDADE FROM CLIENTE WHERE UF='SP' OR CIDADE='LONDRINA';

/*13. Elabore uma consulta que mostre o número do pedido e o prazo de entrega dos pedidos que tiverem o código do cliente igual a 720 e o código do vendedor igual a 101*/
SELECT NUM_PEDIDO, PRAZO_ENTREGA FROM PEDIDO WHERE CODIGO_CLIENTE = 720 AND CODIGO_VENDEDOR = 101;

/*14. Selecione da tabela item do pedido o campo número do pedido quando a quantidade for maior igual a 30 e elimine as linhas duplicadas*/
SELECT DISTINCT (NUM_PEDIDO) FROM ITEM_DO_PEDIDO WHERE QUANTIDADE>=30;

/*15. Liste todos os vendedores, exceto os que possuem a faixa de comissão igual a „C?.*/
SELECT * FROM VENDEDOR WHERE FAIXA_COMISSAO='A' OR FAIXA_COMISSAO='B';

-- 16 Liste as descrições de todos os produtos, exceto os que possuem a unidade o produto igual a 'M'
select descricao_produto
from produto
where unidade != 'm';

-- 17 Crie uma consulta que mostre os nomes dos vendedores que possuem o Salário Fixo na faixa de R$ 1.000,00 até R$ 3.000,00.
select nome_vendedor
from vendedor
where salario_fixo between 1000 and 3000;

--18 Selecione os campos número dos pedidos e prazo de entrega de todos os pedidos que possuem o prazo de entrega que esteja entre 15 a 25 dias
select num_pedido, prazo_entrega
from pedido
where prazo_entrega between 15 and 25;

-- 19 Localizem os registros de vendedores que não comecem com a letra 'J'.
select codigo_vendedor, nome_vendedor, salario_fixo, faixa_comissao
from vendedor
where nome_vendedor not like 'J%';

-- 20 Localizem os registros de clientes cujos nomes contenham as letras 'io'. 
select codigo_cliente, nome_cliente, endereco, cidade, cep, uf, cgc, ie
from cliente
where nome_cliente like '%io%';

-- 21 Selecionem os nomes dos clientes que comecem com letra 'A' até a letra 'F'
select nome_cliente
from cliente
where nome_cliente between 'a' and 'g';

-- 22 Mostre a descrição dos produtos quando a unidade do produto não seja igual a 'M' e 'Kg'.
select descricao_produto
from produto
where unidade not like 'm' and unidade not like 'kg';

-- 23 Selecionem os vendedores que não possuem a faixa de comissão.
select nome_vendedor
from vendedor
where faixa_comissao is null;

-- 24 Listem os clientes que possuem Inscrição Estadual, ou seja, Inscrição Estadual não nula.
select nome_cliente
from cliente
where ie is null;

-- 25 . Crie uma consulta que exiba os clientes ordenados pelo nome do cliente.
select nome_cliente
from cliente
order by nome_cliente;

-- 26 Faça uma consulta da tabela vendedor que mostre nome do vendedor e o salário fixo dos vendedores ordenados pelo nome do vendedor.
select nome_vendedor, salario_fixo
from vendedor
order by nome_vendedor;

-- 27 Mostre o nome do cliente e o endereço dos clientes do estado de SP ordenados pelo código do cliente. 
select nome_cliente, endereco
from cliente
where uf='sp'
order by codigo_cliente;

-- 28 Selecione o número do pedido dos pedidos que possuem o prazo de entrega igual a 20 dias classificado em ordem decrescente pelo número do pedido.
select num_pedido
from pedido
where prazo_entrega = 20
order by num_pedido desc;

-- 29 Listem as faixas de comissões, os nomes e os códigos dos vendedores ordenados pela faixa de comissão e pelo nome do vendedor.
select faixa_comissao, nome_vendedor, codigo_vendedor
from vendedor
order by faixa_comissao, nome_vendedor;

-- 30 Realize uma consulta que exiba os estados e os nomes dos clientes que comecem com a letra 'P' até a letra 'Z', classificados por estado e nome.
select uf, nome_cliente
from cliente
where nome_cliente between 'p' and 'z'
order by uf, nome_cliente;

-- 31) Mostre o produto que possui o menor e o maior preço
select min(val_unit), max(val_unit)
from produto;

-- 32) Façam a média e a soma do salário fixo dos vendedores
select avg(salario_fixo), sum(salario_fixo)
from vendedor;

-- 33) Encontre a quantidade de clientes que não possuem a Inscrição Estadual nula.
select count(nome_cliente)
from cliente
where ie != 0;

-- 34) Exiba o maior valor e a soma do salário fixo dos vendedores que possuem a faixa de comissão 'A'
select max(salario_fixo), sum(salario_fixo)
from vendedor
where faixa_comissao = 'a';

-- 35) Mostre a quantidade total pedida, para o produto 'papel' de código '77' na tabela item do pedido.
select count(unidade) AS'Quantidade total'
from produto
where descricao_produto = 'papel' and codigo_produto = 77;

-- 36) Quantos produtos possuem um valor unitário menor que R$ 2,00
select count(unidade) AS'Quantidade de produtos'
from produto
where val_unit < 2;

-- 37) Liste a quantidade clientes que cada estado contém.
select uf, count(uf) AS'Quantidade de clientes'
from cliente 
group by uf;

-- 38) Exiba a quantidade de vendedores e a soma do salário fixo agrupados pela faixa de comissão.
select count(*), sum(salario_fixo)
from vendedor
group by faixa_comissao;

-- 39) Mostre a soma do valor unitário da tabela produto, agrupados pela unidade.
select sum(val_unit), unidade
from produto
group by unidade;

-- 42) Selecione os pedidos que têm mais do que 3 produtos na tabela item do pedido.
select num_pedido, count(quantidade)
from item_do_pedido
group by num_pedido
having count(quantidade)>3;

-- 43) Liste da tabela item do pedido os produtos que contenha a soma das quantidades maior igual a 50.
select codigo_produto, sum(quantidade)
from item_do_pedido
group by codigo_produto
having sum(quantidade)>=50;

-- 44) Mostre os produtos cuja média do valor unitário agrupados pela unidade seja menor que R$ 1,50.
select descricao_produto, unidade, avg(val_unit)
from produto
group by unidade, descricao_produto
having avg(val_unit)<1.50;

-- 45) Selecione o nome e a cidade dos clientes que possui o pedido com o prazo de entrega superiores a 25 dias.
select C.nome_cliente, C.cidade
from CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.codigo_cliente
WHERE P.prazo_entrega>25;

--46. Apresente a descrição, a unidade e a quantidade dos produtos pedidos que possuem a quantidade maior do que 40. 
SELECT PROD.descricao_produto, PROD.unidade, ITEM.quantidade
FROM PRODUTO PROD INNER JOIN item_do_pedido ITEM ON PROD.codigo_produto = ITEM.codigo_produto
WHERE ITEM.quantidade>40;

--47. Encontre os nomes dos clientes atendidos pelo vendedor João que possui código igual a 101.
SELECT C.nome_cliente
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.codigo_cliente INNER JOIN VENDEDOR V ON V.codigo_vendedor = P.codigo_vendedor
WHERE V.codigo_vendedor=101;

--48. Exiba os nomes dos vendedores que atenderam a Cliente Ana de código 720.
SELECT V.nome_vendedor
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.codigo_cliente INNER JOIN VENDEDOR V ON V.codigo_vendedor = P.codigo_vendedor
WHERE C.codigo_cliente=720;

--49. Liste os clientes e seus respectivos prazos de entrega, ordenados pelo nome do cliente em ordem decrescente. 
SELECT C.nome_cliente, P.prazo_entrega
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente=P.codigo_cliente
ORDER BY C.nome_cliente DESC;

/*50. Mostre os vendedores (ordenados) que emitiram pedidos com prazos de entrega 
superiores a 15 dias e tenham salários fixos iguais ou superiores a R$ 1.000,00.*/

SELECT V.nome_vendedor
FROM VENDEDOR V INNER JOIN PEDIDO P ON V.codigo_vendedor = P.codigo_vendedor
WHERE P.prazo_entrega> 15 AND V.salario_fixo>=1.000
ORDER BY V.nome_vendedor;

-- 51. Quais clientes tem prazo de entrega superior a 15 dias e pertencem aos estados de São Paulo (SP) ou Rio de Janeiro (RJ))? 
SELECT * FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.codigo_cliente
WHERE P.prazo_entrega>15 AND C.uf='SP' OR C.uf='RJ';

-- 52. Encontre os nomes dos clientes (ordenados) atendidos pelo vendedor „Antônio‟.
SELECT C.nome_cliente
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.codigo_cliente INNER JOIN VENDEDOR V ON V.codigo_vendedor = P.codigo_vendedor
WHERE V.nome_vendedor='ANTÔNIO'
ORDER BY C.nome_cliente;

/* 53. Mostre os clientes (ordenados) que têm prazo de entrega maior 
que 15 dias para o produto „Queijo‟ e sejam do estado de Rio de Janeiro*/
SELECT *
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente=P.codigo_cliente INNER JOIN ITEM_DO_PEDIDO ITEM ON ITEM.num_pedido = P.num_pedido INNER JOIN PRODUTO PROD ON PROD.codigo_produto = ITEM.codigo_produto
WHERE P.prazo_entrega>15 AND PROD.descricao_produto='QUEIJO' AND C.uf='RJ'
ORDER BY C.nome_cliente

/*54. . Selecionem os códigos e os nomes dos clientes,
 e seus respectivos prazos de entrega dos pedidos de todos os clientes que fizeram ou não pedidos. */
 SELECT C.codigo_cliente, C.nome_cliente, P.prazo_entrega
 FROM CLIENTE C LEFT JOIN PEDIDO P ON C.codigo_cliente=P.codigo_cliente;

 /*56. Relacionem todos os produtos que participaram ou não de algum pedido.
  (Liste o código e o nome do produto, o número do pedido e a quantidade vendida).*/
  SELECT PROD.codigo_produto, PROD.descricao_produto, P.num_pedido, I.quantidade
  FROM PEDIDO P INNER JOIN ITEM_DO_PEDIDO I  ON P.num_pedido= I.num_pedido RIGHT JOIN PRODUTO PROD ON I.codigo_produto=PROD.codigo_produto;

/*64. Crie uma View contendo os códigos e os nomes dos clientes que moram nos estados de SP ou RJ ou MS*/
CREATE VIEW EXERCICIO64 AS
SELECT CODIGO_CLIENTE, NOME_CLIENTE FROM CLIENTE WHERE UF='SP' OR UF='RJ' OR UF='MS';
SELECT * FROM EXERCICIO64;

/*65.  Crie uma View que selecione todos os números dos pedidos, 
códigos dos clientes e os prazos de entrega dos vendedores que tenham o nome ‘Carlos’. */
CREATE VIEW EXERCICIO65 AS
SELECT P.num_pedido, C.codigo_cliente, P.prazo_entrega
FROM CLIENTE C INNER JOIN PEDIDO P ON C.codigo_cliente = P.CODIGO_CLIENTE INNER JOIN VENDEDOR V ON P.codigo_vendedor = V.codigo_vendedor
WHERE V.nome_vendedor='Carlos';
SELECT * FROM EXERCICIO65;

/*66 Faça uma View que contenha o número do pedido, código e descrição do produto, quantidade ,
 val_unit e o total (quantidade * val_unit). */
 CREATE VIEW EXERCICIO66 AS
 SELECT P.num_pedido, PROD.codigo_produto, PROD.descricao_produto, ITEM.quantidade, PROD.val_unit, (ITEM.quantidade * PROD.val_unit) AS 'TOTAL'
 FROM  VENDEDOR V INNER JOIN PEDIDO P ON P.codigo_vendedor = V.codigo_vendedor INNER JOIN ITEM_DO_PEDIDO ITEM ON P.num_pedido = ITEM.num_pedido INNER JOIN PRODUTO PROD ON ITEM.codigo_produto = PROD.codigo_produto;
 SELECT  * FROM EXERCICIO66;

 /*67. Tendo como referencia ao exercício anterior, crie uma visualização que mostre a soma total  de cada pedido.*/


 -------exercicios subconsulta
 --1) QUAIS PRODUTOS PARTICIPAM DE PEDIDDO CUJA QUANTIDADE SEJA MAIOR DO QUE 5

 SELECT P.descricao_produto FROM PRODUTO P inner join item_do_pedido i on P.codigo_produto = I.codigo_produto
 WHERE quantidade in
 (SELECT quantidade  FROM ITEM_DO_PEDIDO where quantidade > 5);
 
 ------------------------------------------------
 SELECT num_pedido FROM item_do_pedido
 WHERE quantidade>
 (SELECT quantidade = 5 FROM ITEM_DO_PEDIDO);




