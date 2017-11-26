﻿CREATE TABLE TIPO_USUARIO (
    ID_TIPO_USUARIO tinyint,
    DESCRICAO VARCHAR(50),    
    CONSTRAINT PK_TIPO_USUARIO PRIMARY KEY (ID_TIPO_USUARIO));

CREATE TABLE USUARIO (
    LOGIN VARCHAR(15),
    SENHA VARCHAR(10),
    ID_TIPO_USUARIO tinyint,    
    NOME VARCHAR(35),
    STATUS BIT NULL DEFAULT 1,	
    CONSTRAINT PK_USUARIO PRIMARY KEY (LOGIN),    
    CONSTRAINT FK_TIPO_USUARIO FOREIGN KEY (ID_TIPO_USUARIO)
        REFERENCES TIPO_USUARIO (ID_TIPO_USUARIO));

CREATE TABLE STATUS_CHAMADO (
    ID_STATUS_CHAMADO tinyint,
    DESCRICAO VARCHAR(50),    
    CONSTRAINT PK_STATUS_CHAMADO PRIMARY KEY (ID_STATUS_CHAMADO));

CREATE TABLE PRIORIDADE_CHAMADO (
    ID_PRIORIDADE_CHAMADO tinyint,
    DESCRICAO VARCHAR(50),    
    CONSTRAINT PK_PRIORIDADE_CHAMADO PRIMARY KEY (ID_PRIORIDADE_CHAMADO));

CREATE TABLE CLIENTE (
   ID_CLIENTE int NOT NULL IDENTITY(1,1),
   NOME VARCHAR(30),
   TELEFONE VARCHAR(14),
   ENDERECO VARCHAR(40),
   UF VARCHAR(2),
   LOGIN VARCHAR(15),  
   STATUS BIT NULL DEFAULT 1, 
   CONSTRAINT PK_CLIENTE PRIMARY KEY (ID_CLIENTE),   
   CONSTRAINT FK_USUARIO FOREIGN KEY (LOGIN)
        REFERENCES USUARIO (LOGIN));

CREATE TABLE CHAMADO (
    ID_CHAMADO int NOT NULL IDENTITY(1,1),
    DESCRICAO VARCHAR(255),
    ID_CLIENTE int,
    ID_STATUS_CHAMADO tinyint,
    ID_PRIORIDADE_CHAMADO tinyint,
    DATA_CRIACAO datetime2,
    DATA_FECHAMENTO datetime2,
    LOGIN_CRIACAO VARCHAR(15),
    LOGIN_RESPONSAVEL VARCHAR(15),
    
    CONSTRAINT PK_CHAMADO PRIMARY KEY (ID_CHAMADO),    
    CONSTRAINT FK_CLIENTE FOREIGN KEY (ID_CLIENTE)
        REFERENCES CLIENTE (ID_CLIENTE),        
    CONSTRAINT FK_STATUS_CHAMADO FOREIGN KEY (ID_STATUS_CHAMADO)
        REFERENCES STATUS_CHAMADO (ID_STATUS_CHAMADO),        
    CONSTRAINT FK_PRIORIDADE_CHAMADO FOREIGN KEY (ID_PRIORIDADE_CHAMADO)
        REFERENCES PRIORIDADE_CHAMADO (ID_PRIORIDADE_CHAMADO),        
    CONSTRAINT FK_LOGIN_CRIACAO FOREIGN KEY (LOGIN_CRIACAO)
        REFERENCES USUARIO (LOGIN),        
    CONSTRAINT FK_LOGIN_RESPONSAVEL FOREIGN KEY (LOGIN_RESPONSAVEL)
        REFERENCES USUARIO (LOGIN));
