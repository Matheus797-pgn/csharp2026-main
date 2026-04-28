 -- criação do banco de dados --
 CREATE TABLE Contas(
 id INT identity(1,1) PRIMARY KEY,
 Titular NVARCHAR(30) NOT NULL,
 NumeroDaConta INT NOT NULL UNIQUE,
 Saldo DECIMAL(10,2) NOT NULL,
 )
 GO