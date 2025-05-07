	-- Criando banco de dados 
    create database dbExemplo;
    use dbExemplo;
    
    create table Usuarios(
    Id int primary key auto_increment,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
    )
    
    SELECT * FROM  Usuarios;