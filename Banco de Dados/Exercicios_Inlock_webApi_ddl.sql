
--Cria o banco de dados inlock games
CREATE DATABASE inlock_games_tarde;

USE inlock_games_tarde;

-- Cria a tabela Funcionarios
CREATE TABLE estudios 
(
	idEstudio	INT IDENTITY PRIMARY KEY
	,nomeEstudio VARCHAR(200) NOT NULL
);


-- Cria a tabela de jogos
CREATE TABLE jogos 
(
	idJogo	INT IDENTITY PRIMARY KEY
	,nomeJogo VARCHAR(200) NOT NULL
	,descricaoJogo VARCHAR(200) NOT NULL
	,dataLancamento date not null
	,valor money NOT NULL
	,idEstudio INT FOREIGN KEY REFERENCES estudios(idEstudio)
);
GO


-- Cria a tabela de tipos usuarios
CREATE TABLE tipoUsuario(
	idTipoUsuario INT IDENTITY PRIMARY KEY
	,titulo VARCHAR(200) NOT NULL
);
GO

-- Cria a tabela de usuarios
CREATE TABLE usuarios(
	idUsuario INT IDENTITY PRIMARY KEY
	,email VARCHAR(200) NOT NULL UNIQUE
	,senha VARCHAR(200) NOT NULL
	,idTipoUsuario INT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario)
);
GO




