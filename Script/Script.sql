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

-- Valores fictícios para Pessoa Física
INSERT INTO cliente (NomeRazaoSocial, CpfCnpj, Email, Telefone, DataCadastro, Bloqueado, Tipo, IncricaoEstadual, Isento, DataNascimento, Genero, Senha)
VALUES
    ('Fulano da Silva', '123.456.789-10', 'fulano@example.com', '(11) 98765-4321', '2023-07-26 08:30:00', 0, 1, NULL, 0, '1985-07-10 00:00:00', 1, 'senha123'),
    ('Beltrano dos Santos', '234.567.890-12', 'beltrano@example.com', '(21) 99876-5432', '2023-07-26 09:15:00', 0, 1, NULL, 1, '1990-03-15 00:00:00', 2, 'senha456'),
    ('Maria Souza', '345.678.901-23', 'maria@example.com', '(31) 99999-8888', '2023-07-26 10:00:00', 0, 1, NULL, 0, '1980-11-25 00:00:00', 3, 'senha789'),
    ('José Silva', '456.789.012-34', 'jose@example.com', '(41) 97777-6666', '2023-07-26 10:45:00', 0, 1, NULL, 1, '1975-09-05 00:00:00', 1, 'senhaabc'),
    ('Ana Pereira', '567.890.123-45', 'ana@example.com', '(51) 88888-5555', '2023-07-26 11:30:00', 0, 1, NULL, 0, '1993-04-20 00:00:00', 2, 'senha321'),
    ('Pedro Carvalho', '678.901.234-56', 'pedro@example.com', '(61) 98765-4321', '2023-07-26 12:15:00', 0, 1, NULL, 0, '1988-12-01 00:00:00', 1, 'senha654'),
    ('Mariana Almeida', '789.012.345-67', 'mariana@example.com', '(71) 99999-8888', '2023-07-26 13:00:00', 0, 1, NULL, 1, '1982-06-10 00:00:00', 2, 'senha987'),
    ('Carlos Lima', '890.123.456-78', 'carlos@example.com', '(81) 98888-7777', '2023-07-26 13:45:00', 0, 1, NULL, 0, '1977-02-15 00:00:00', 1, 'senhaxyz'),
    ('Juliana Gomes', '901.234.567-89', 'juliana@example.com', '(91) 97777-6666', '2023-07-26 14:30:00', 0, 1, NULL, 0, '1995-09-30 00:00:00', 2, 'senhaabc'),
    ('Lucas Oliveira', '012.345.678-90', 'lucas@example.com', '(21) 95555-4444', '2023-07-26 15:15:00', 0, 1, NULL, 1, '1989-07-05 00:00:00', 1, 'senhaxyz'),
    ('Amanda Rodrigues', '098.765.432-10', 'amanda@example.com', '(31) 93333-2222', '2023-07-26 16:00:00', 0, 1, NULL, 0, '1997-12-20 00:00:00', 2, 'senha456'),
    ('Rafael Martins', '987.654.321-09', 'rafael@example.com', '(41) 92222-1111', '2023-07-26 16:45:00', 0, 1, NULL, 0, '1983-08-25 00:00:00', 3, 'senha321'),
    ('Beatriz Sousa', '876.543.210-98', 'beatriz@example.com', '(51) 94444-3333', '2023-07-26 17:30:00', 0, 1, NULL, 1, '1992-05-10 00:00:00', 2, 'senha654'),
    ('Gustavo Pereira', '765.432.109-87', 'gustavo@example.com', '(61) 91111-5555', '2023-07-26 18:15:00', 0, 1, NULL, 0, '1979-11-05 00:00:00', 1, 'senha987'),
    ('Larissa Santos', '654.321.098-76', 'larissa@example.com', '(71) 92222-3333', '2023-07-26 19:00:00', 0, 1, NULL, 1, '1984-12-30 00:00:00', 2, 'senhaabc');

-- Valores fictícios para Pessoa Jurídica
INSERT INTO cliente (NomeRazaoSocial, CpfCnpj, Email, Telefone, DataCadastro, Bloqueado, Tipo, IncricaoEstadual, Isento, DataNascimento, Genero, Senha)
VALUES
    ('Empresa ABC Ltda', '12.345.678/0001-90', 'empresa@example.com', '(11) 2222-3333', '2023-07-26 08:30:00', 0, 0, '12345678', 0, '0001-01-01 00:00:00', 0, 'senha123'),
    ('Comércio XYZ S/A', '23.456.789/0001-01', 'comercio@example.com', '(21) 4444-5555', '2023-07-26 09:15:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senha456'),
    ('Loja 123 EIRELI', '34.567.890/0001-23', 'loja123@example.com', '(31) 6666-7777', '2023-07-26 10:00:00', 0, 0, '87654321', 0, '0001-01-01 00:00:00', 0, 'senha789'),
    ('Serviços XYZ Ltda', '45.678.901/0001-45', 'servicos@example.com', '(41) 8888-9999', '2023-07-26 10:45:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senhaabc'),
    ('Comércio Alfa Ltda', '56.789.012/0001-67', 'comercio_alfa@example.com', '(51) 7777-6666', '2023-07-26 11:30:00', 0, 0, '76543210', 0, '0001-01-01 00:00:00', 0, 'senha321'),
    ('Empreendimentos Beta S/A', '67.890.123/0001-89', 'empreendimentos_beta@example.com', '(61) 96666-5555', '2023-07-26 12:15:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senha654'),
    ('Lojas Gama EIRELI', '78.901.234/0001-10', 'lojas_gama@example.com', '(71) 8555-4444', '2023-07-26 13:00:00', 0, 0, '54321098', 0, '0001-01-01 00:00:00', 0, 'senha987'),
    ('Serviços Ômega Ltda', '89.012.345/0001-32', 'servicos_omega@example.com', '(81) 94444-3333', '2023-07-26 13:45:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senhaxyz'),
    ('Comércio Delta Ltda', '90.123.456/0001-54', 'comercio_delta@example.com', '(91) 92222-1111', '2023-07-26 14:30:00', 0, 0, '43210987', 0, '0001-01-01 00:00:00', 0, 'senha321'),
    ('Empreendimentos Sigma S/A', '01.234.567/0001-76', 'empreendimentos_sigma@example.com', '(21) 93333-2222', '2023-07-26 15:15:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senha654'),
    ('Comércio Ômega Ltda', '90.987.654/0001-98', 'comercio_omega@example.com', '(31) 91111-5555', '2023-07-26 16:00:00', 0, 0, '32109876', 0, '0001-01-01 00:00:00', 0, 'senha987'),
    ('Lojas Beta EIRELI', '98.765.432/0001-10', 'lojas_beta@example.com', '(41) 92222-3333', '2023-07-26 16:45:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senhaabc'),
    ('Empreendimentos Delta S/A', '10.987.654/0001-23', 'empreendimentos_delta@example.com', '(51) 94444-3333', '2023-07-26 17:30:00', 0, 0, '21098765', 0, '0001-01-01 00:00:00', 0, 'senha654'),
    ('Comércio Sigma Ltda', '23.456.789/0001-45', 'comercio_sigma@example.com', '(61) 98888-7777', '2023-07-26 18:15:00', 0, 0, NULL, 1, '0001-01-01 00:00:00', 0, 'senha987'),
    ('Empreendimentos Alfa S/A', '34.567.890/0001-67', 'empreendimentos_alfa@example.com', '(71) 92222-3333', '2023-07-26 19:00:00', 0, 0, '09876543', 0, '0001-01-01 00:00:00', 0, 'senhaabc');
