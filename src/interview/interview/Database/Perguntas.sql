-- Script de criação da tabela perguntas
-- Necessário verificar se a abordagem será utilizando SQL ou Migrations

-- Autor @paulhenrique
CREATE TABLE Perguntas (
	Id integer PRIMARY KEY AUTO_INCREMENT,
	Description varchar(255),
	idTema int -- adicionar posteriormente relacionamento com a tabela tema
);