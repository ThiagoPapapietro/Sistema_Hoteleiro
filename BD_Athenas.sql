-- Criando um Banco de Dados
CREATE DATABASE Athenas
GO

-- Utilizando um Banco de Dados 
USE Athenas
GO

-- criando tabela Cargos
CREATE TABLE Cargos
(
	id_Cargo int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Cargo varchar (30) NOT NULL,
);
GO



-- criando tabela Funcionario
CREATE TABLE Funcionario
(
	id_Funcionario int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (100) NOT NULL,
	DataDeNasc varchar(15) NOT NULL,
	RG varchar(15) NOT NULL,
	DataExpedicao varchar(15) NOT NULL,
	OrgaoEmissor varchar(15) NOT NULL,
	CPF varchar(15) NOT NULL,
	Cargo varchar(30) NOT NULL,
	Salario varchar(15) NOT NULL,
	Sexo varchar(15) NOT NULL,
	CEP varchar(10) NOT NULL,
	Rua varchar(100) NOT NULL,
	Numero varchar(7) NOT NULL,
	Complemento varchar(50) NOT NULL,
	Bairro varchar(50) NOT NULL,
	Cidade varchar(50) NOT NULL,
	Estado varchar(3) NOT NULL,
	Tel_Res varchar(15) NOT NULL,
	Celular varchar(15) NOT NULL,
	Email varchar(30) NOT NULL,
	Data Date NOT NULL,
);
GO



-- criando tabela Usuarios
CREATE TABLE Usuarios
(
	id_Usuario int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (100) NOT NULL,
	Cargo varchar(30) NOT NULL,
	Usuario varchar (30) NOT NULL,
	Senha varchar(30) NOT NULL,
	Data Date NOT NULL,
);
GO


-- criando tabela Fornecedores
CREATE TABLE Fornecedores
(
	id_Fornecedores int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (50) NOT NULL,
	Endereco varchar(50) NOT NULL,
	Telefone varchar (20) NOT NULL,	
);
GO



-- criando tabela Produtos
CREATE TABLE Produtos
(
	id_Produtos int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (50) NOT NULL,
	Descricao varchar(80) NOT NULL,
	Valor_Venda Decimal (10,2) NOT NULL,
	Valor_Compra Decimal (10,2) NULL DEFAULT 0, -- definir como valor 0
	Estoque int NULL  DEFAULT 0,	
	Fornecedor int NOT NULL,	-- int
	Data Date NOT NULL,
	Imagem image NULL,	
);
GO



-- criando tabela Servicos
CREATE TABLE Servicos
(
	id_Servico int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (40) NOT NULL,
	Valor Decimal (10,2) NOT NULL,	
);
GO



-- criando tabela Produtos
CREATE TABLE Vendas
(
	id_Vendas int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Valor_Total Decimal (10,2) NOT NULL,
	Funcionario varchar (40) NOT NULL,	
	Status varchar (25) default 'Efetuada' NOT NULL,
	Data Date NOT NULL,
);
GO



-- criando tabela Detalhes Vendas
CREATE TABLE Detalhes_Venda
(
	id_DetalhesVendas int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	id_Venda int NOT NULL,-- DEFAULT 0,
	Produto Varchar(40) NOT NULL,	
	Quantidade int NOT NULL,	
	Valor_Unitario Decimal (10,2) NOT NULL, -- int
	Valor_Total Decimal (10,2) NOT NULL, -- int
	Funcionario varchar (30) NOT NULL,
	id_Produto int NOT NULL,
);
GO

-- criando tabela Movimentacoes
CREATE TABLE Movimentacoes
(
	id_Movimentacoes int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Tipo Varchar(15) NOT NULL,-- DEFAULT 0,
	Movimento Varchar(25) NOT NULL,	
	Valor Decimal (10,2) NOT NULL, -- int
	Funcionario varchar (30) NOT NULL,
	Data Date NOT NULL,
	id_Movimento int NOT NULL,
);
GO

select * from Movimentacoes

-- criando tabela Gastos
CREATE TABLE Gastos
(
	id_Gastos int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Descricao Varchar(60) NOT NULL,
	Valor Decimal (10,2) NOT NULL, -- int
	Funcionario varchar (30) NOT NULL,
	Data Date NOT NULL,
);
GO

CREATE TABLE Hospedes
(
	id_Hospede int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Nome varchar (100) NOT NULL,
	CPF varchar(15) NOT NULL,
	Sexo varchar(15) NOT NULL,
	Celular varchar(15) NOT NULL,
	CEP varchar(10) NOT NULL,
	Endereco varchar(100) NOT NULL,
	Numero varchar(7) NOT NULL,
	Bairro varchar(50) NOT NULL,
	Cidade varchar(50) NOT NULL,
	Estado varchar(3) NOT NULL,
	Funcionario varchar (30) NOT NULL,
	Data Date NOT NULL,
);
GO

CREATE TABLE Novo_Servico
(
	id_NovoServico int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Hospede varchar (100) NOT NULL,
	Servico varchar(30) NOT NULL,
	Quarto varchar(10) NOT NULL,
	Quantidade int NOT NULL,	
	Valor Decimal (10,2) NOT NULL, 
	Funcionario varchar (30) NOT NULL,
	Data Date NOT NULL,
);
GO

-- criando tabela Quartos
CREATE TABLE Quartos
(
	id_Quarto int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Descricao varchar (40) NOT NULL,
	Quarto varchar (5) NOT NULL,
	Valor Decimal (10,2) NOT NULL,
	Pessoas varchar (5) NOT NULL,
);
GO

CREATE TABLE Reservas
(
	id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Quarto varchar(10) NOT NULL,
	Entrada Date NOT NULL,	
	Saida Date NOT NULL,	
	Dias int NOT NULL,
	Valor Decimal (10,2) NOT NULL, 
	Nome varchar(30) NOT NULL,
	Telefone varchar(20) NOT NULL,
	Data Date NOT NULL,		
	Funcionario varchar (30) NOT NULL,
	Status varchar (20) default 'Confirmada' NOT NULL,
	Checkin varchar (5) default 'Não' NOT NULL,
	Checkout varchar (5) default 'Não' NOT NULL,
	Pago varchar (5) default 'Não' NOT NULL,
);
GO

-- criando tabela Ocupações
CREATE TABLE Ocupacoes
(
	id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Quarto varchar (5) NOT NULL,
	Data Date NOT NULL,		
	Funcionario varchar (30) NOT NULL,
	id_Reserva varchar (5) default '0' NOT NULL,
);
GO

drop table Ocupacoes
INSERT INTO Ocupacoes (Quarto, Data, Funcionario, id_Reserva) VALUES ('101', '2021-11-02', 'Thiago', 0);
INSERT INTO Ocupacoes (Quarto, Data, Funcionario, id_Reserva) VALUES ('101', '2021/11/08', 'Thiago', 0);

select * from Ocupacoes

DELETE FROM Reservas
WHERE id_Reserva = 0