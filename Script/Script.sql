CREATE DATABASE smarthint;

USE smarthint;

CREATE TABLE cliente (
  Id int NOT NULL AUTO_INCREMENT,
  NomeRazaoSocial longtext NOT NULL,
  CpfCnpj longtext,
  Email longtext NULL,
  Telefone longtext NOT NULL,
  DataCadastro datetime(6) NOT NULL,
  Bloqueado int NOT NULL,
  Tipo int NOT NULL,
  IncricaoEstadual longtext,
  Isento int NOT NULL,
  DataNascimento datetime(6) NOT NULL,
  Genero int NOT NULL,
  Senha longtext NOT NULL,
  PRIMARY KEY (`Id`)
);

INSERT INTO cliente (NomeRazaoSocial, CpfCnpj, Email, Telefone, DataCadastro, Bloqueado, Tipo, IncricaoEstadual, Isento, DataNascimento, Genero, Senha) VALUES
    ('Fulano da Silva', '123.456.789-10', 'fulano@example.com', '(11) 98765-4321', '2023-07-26 08:30:00', 0, 1, NULL, 0, '1985-07-10 00:00:00', 1, 'senha123'),
    ('Empresa XYZ Ltda', '23.456.789/0001-01', 'empresa@example.com', '(21) 4444-5555', '2023-07-26 09:15:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha456'),
    ('Maria Souza', '345.678.901-23', 'maria@example.com', '(31) 99999-8888', '2023-07-26 10:00:00', 0, 1, NULL, 0, '1980-11-25 00:00:00', 2, 'senha789'),
    ('Comércio ABC Ltda', '45.678.901/0001-23', 'comercio@example.com', '(41) 97777-6666', '2023-07-26 10:45:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaabc'),
    ('Ana Pereira', '567.890.123-45', 'ana@example.com', '(51) 88888-5555', '2023-07-26 11:30:00', 0, 1, NULL, 0, '1993-04-20 00:00:00', 2, 'senha321'),
    ('Loja Alfa EIRELI', '67.890.123/0001-45', 'loja@example.com', '(61) 98765-4321', '2023-07-26 12:15:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha654'),
    ('Mariana Almeida', '789.012.345-67', 'mariana@example.com', '(71) 99999-8888', '2023-07-26 13:00:00', 0, 1, NULL, 1, '1982-06-10 00:00:00', 2, 'senha987'),
    ('Serviços ABC Ltda', '89.012.345/0001-67', 'servicos@example.com', '(81) 98888-7777', '2023-07-26 13:45:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Juliana Gomes', '901.234.567-89', 'juliana@example.com', '(91) 97777-6666', '2023-07-26 14:30:00', 0, 1, NULL, 0, '1995-09-30 00:00:00', 2, 'senhaabc'),
    ('Loja Beta EIRELI', '01.234.567/0001-01', 'loja@example.com', '(21) 95555-4444', '2023-07-26 15:15:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Amanda Rodrigues', '098.765.432-10', 'amanda@example.com', '(31) 93333-2222', '2023-07-26 16:00:00', 0, 1, NULL, 0, '1997-12-20 00:00:00', 2, 'senha456'),
    ('Comércio XYZ S/A', '23.456.789/0001-01', 'comercio@example.com', '(41) 92222-1111', '2023-07-26 16:45:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha321'),
    ('Beatriz Sousa', '876.543.210-98', 'beatriz@example.com', '(51) 94444-3333', '2023-07-26 17:30:00', 0, 1, NULL, 1, '1982-06-10 00:00:00', 2, 'senha987'),
    ('Loja Delta EIRELI', '10.987.654/0001-09', 'loja@example.com', '(61) 98888-7777', '2023-07-26 18:15:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Lucas Oliveira', '012.345.678-90', 'lucas@example.com', '(71) 92222-3333', '2023-07-26 19:00:00', 0, 1, NULL, 0, '1989-07-05 00:00:00', 1, 'senhaabc'),
    ('Loja Sigma EIRELI', '78.901.234/0001-12', 'loja@example.com', '(81) 94444-3333', '2023-07-26 20:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha654'),
    ('Carlos Lima', '890.123.456-78', 'carlos@example.com', '(91) 96666-5555', '2023-07-26 21:00:00', 0, 1, NULL, 0, '1977-02-15 00:00:00', 1, 'senhaxyz'),
    ('Loja Ômega EIRELI', '01.234.567/0001-01', 'loja@example.com', '(21) 93333-2222', '2023-07-26 22:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha456'),
    ('José Silva', '456.789.012-34', 'jose@example.com', '(31) 95555-4444', '2023-07-26 23:00:00', 0, 1, NULL, 0, '1975-09-05 00:00:00', 1, 'senha321'),
    ('Comércio Alfa Ltda', '56.789.012/0001-56', 'comercio@example.com', '(41) 98888-7777', '2023-07-27 08:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha987'),
    ('Pedro Carvalho', '678.901.234-56', 'pedro@example.com', '(51) 92222-1111', '2023-07-27 09:00:00', 0, 1, NULL, 0, '1988-12-01 00:00:00', 1, 'senhaabc'),
    ('Empreendimentos ABC S/A', '01.234.567/0001-01', 'empreendimentos@example.com', '(61) 94444-3333', '2023-07-27 10:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Rafael Martins', '987.654.321-09', 'rafael@example.com', '(71) 91111-5555', '2023-07-27 11:00:00', 0, 1, NULL, 0, '1983-08-25 00:00:00', 1, 'senha987'),
    ('Empreendimentos XYZ S/A', '10.987.654/0001-09', 'empreendimentos@example.com', '(81) 96666-5555', '2023-07-27 12:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaabc'),
    ('Beatriz Silva', '789.012.345-67', 'beatriz@example.com', '(91) 97777-6666', '2023-07-27 13:00:00', 0, 1, NULL, 1, '1982-06-10 00:00:00', 2, 'senha321'),
    ('Empreendimentos Alfa S/A', '23.456.789/0001-01', 'empreendimentos@example.com', '(21) 98888-7777', '2023-07-27 14:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Carlos Gomes', '012.345.678-90', 'carlos@example.com', '(31) 94444-3333', '2023-07-27 15:00:00', 0, 1, NULL, 0, '1989-07-05 00:00:00', 1, 'senha987'),
    ('Empreendimentos Sigma S/A', '98.765.432/0001-09', 'empreendimentos@example.com', '(41) 95555-4444', '2023-07-27 16:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senha456'),
    ('Ana Santos', '567.890.123-45', 'ana@example.com', '(51) 92222-1111', '2023-07-27 17:00:00', 0, 1, NULL, 0, '1993-04-20 00:00:00', 2, 'senha654'),
    ('Empreendimentos Ômega S/A', '01.234.567/0001-01', 'empreendimentos@example.com', '(61) 93333-2222', '2023-07-27 18:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Pedro Lima', '123.456.789-10', 'pedro@example.com', '(71) 94444-3333', '2023-07-27 19:00:00', 0, 1, NULL, 0, '1988-12-01 00:00:00', 1, 'senha321'),
    ('Empreendimentos ABCD S/A', '12.345.678/0001-12', 'empreendimentos@example.com', '(81) 92222-3333', '2023-07-27 20:00:00', 0, 0, '12345678901234', 1, '0001-01-01 00:00:00', 0, 'senhaabc');