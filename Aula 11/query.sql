insert into dados_alunos (nome, numero_mecanografico, telefone) values 
('João Silva', 98451, 965244644),
('Sandra Santos', 98745, 945678463),
('Miguel Costa', 97486, 917356356);

select * from dados_alunos;

update dados_alunos set nome = 'João Coelho Silva' where id = 1;

select nome, numero_mecanografico from dados_alunos;
select distinct(nome) from dados_alunos;
select max(numero_mecanografico) from dados_alunos;
select nome, numero_mecanografico from dados_alunos order by numero_mecanografico 
desc limit 2;

insert into dados_alunos (nome, numero_mecanografico, telefone) values ('João 
Silva', 98451, 965244664);
delete from dados_alunos where id = 1;
delete from dados_alunos where id = 2;
delete from dados_alunos where id = 3;
delete from dados_alunos where id = 4;
DELETE FROM dados_alunos
WHERE id BETWEEN 22 AND 35;

/* Exericios */
TRUNCATE TABLE dados_alunos;
insert into dados_alunos (nome, numero_mecanografico, telefone) values 
('Maria', 95876, 912456869),
('José', 94335, 913548666),
('Ana', 93568, 961548668),
('Luis', 96315, 915483584),
('Ricardo', 94666, 933547895);

select * from dados_alunos;

/*2.6.2 Obter os dados do aluno com o mecanográfico mais baixo (use uma subquery).*/
SELECT *
FROM dados_alunos
WHERE numero_mecanografico = (
  SELECT MIN(numero_mecanografico)
  FROM dados_alunos
);

/*2.6.3 Adicionar o último nome do aluno alterando a linha correspondente.*/
update dados_alunos set nome = 'Maria Mota' where id = 1;
update dados_alunos set nome = 'José Pedro' where id = 2;
update dados_alunos set nome = 'Ana Malhoa' where id = 3;
update dados_alunos set nome = 'Luis Mota' where id = 4;
update dados_alunos set nome = 'Ricardo Simão' where id = 5;


/*2.6.4 Remover o aluno com o mecanográfico mais elevado.*/
DELETE dados_alunos
FROM dados_alunos
JOIN (
    SELECT MAX(numero_mecanografico) AS max_numero_mecanografico
    FROM dados_alunos
) AS max_num
WHERE dados_alunos.numero_mecanografico = max_num.max_numero_mecanografico;

SELECT * FROM dados_alunos;


