use inlock_games_tarde

INSERT INTO estudios (nomeEstudio)
values ('Blizzard'), ('Rockstar'), ('Square Enix')

INSERT INTO jogos(nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio)
values('Diablo 3', 'é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã. Seu estúdio é a Blizzard. E o jogo custa R$ 99,00','2018/10/18', 99.00, 1)

INSERT INTO jogos(nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio)
values('Red Dead Redemption II', 'é um jogo eletrônico de ação-aventura western desenvolvido pela Rockstar Studios. Lançado mundialmente em 26 de outubro de 2018. E o jogo custa R$ 120,00', '2018/10/18', 120.00, 2)

INSERT INTO tipoUsuario(titulo)
values('Administrador'),
('Cliente')

INSERT INTO usuarios(email, senha, idTipoUsuario)
values('adm@adm.com', 'adm', 1),
('cliente@cliente.com', 'cliente', 2)


select * from usuarios


