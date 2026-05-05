
-- OP READ - LER
/*
SELECT * FROM Contas
GO

SELECT id,Titular,NumeroDaConta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas 
WHERE Titular like '%maria%';
GO
SELECT * FROM Contas
WHERE NumeroDaConta = 1002
GO

SELECT * FROM Contas
ORDER BY Saldo DESC
GO*/
SELECT * FROM Contas
ORDER BY Saldo ASC
GO
---Contas quantas contas existe na tabela----
SELECT SUM  (Saldo) AS TotalContas FROM Contas

