select * from TIPO_USUARIO;
insert into TIPO_USUARIO values (1, 'Cliente');
insert into TIPO_USUARIO values (2, 'Atendente');
insert into TIPO_USUARIO values (3, 'Desenvolvedor');

select * from USUARIO;
insert into USUARIO (login, senha, ID_TIPO_USUARIO, nome) values ('cteste', 123, 1, 'Cliente de teste');
insert into USUARIO (login, senha, ID_TIPO_USUARIO, nome) values ('ateste', 123, 2, 'Atendente de teste');
insert into USUARIO (login, senha, ID_TIPO_USUARIO, nome) values ('dteste', 123, 3, 'Desenvolvedor de teste');

select * from PRIORIDADE_CHAMADO;
insert into PRIORIDADE_CHAMADO values (1, 'Baixo');
insert into PRIORIDADE_CHAMADO values (2, 'Médio');
insert into PRIORIDADE_CHAMADO values (3, 'Alto');

select * from STATUS_CHAMADO;
insert into STATUS_CHAMADO values (1, 'Aberto');
insert into STATUS_CHAMADO values (2, 'Em análise');
insert into STATUS_CHAMADO values (3, 'Encaminhado para correção');
insert into STATUS_CHAMADO values (4, 'Em correção');
insert into STATUS_CHAMADO values (5, 'Em validação');
insert into STATUS_CHAMADO values (6, 'Reaberto');
insert into STATUS_CHAMADO values (7, 'Fechado');