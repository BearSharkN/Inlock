use inlock_games_tarde

-- Lista todos os usuários
select * from usuarios

select * from tipoUsuario

-- Listar todos os estudios
select idEstudio,nomeEstudio from estudios
-- Listar todos os jogos
select  idJogo, nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio from jogos

delete from jogos where idJogo = 4
-- Listar todos os jogos e seus respectivios estudios
select idJogo, nomeJogo, nomeEstudio,descricaoJogo,dataLancamento,valor from jogos
inner join estudios 
ON jogos.idEstudio = estudios.idEstudio
-- Listar todos 
select nomeEstudio, nomeJogo from estudios
left join jogos
ON jogos.idEstudio = estudios.idEstudio
--- Buscar um usuario por email e senha
select idUsuario, email, senha, idTipoUsuario from usuarios where email = 'adm@adm.com' and senha = 'adm'
-- Busca um jogo por ID
select idJogo, nomeJogo, descricaoJogo, dataLancamento, valor, idEstudio from jogos where idJogo = 1;
-- buscar um estudio pelo o id
select nomeEstudio from estudios where idEstudio = 1;

select * from usuarios
