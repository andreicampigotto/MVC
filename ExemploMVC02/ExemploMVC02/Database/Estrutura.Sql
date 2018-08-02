DROP TABLE recrutadoras;

CREATE TABLE recrutadoras(
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Nome VARCHAR (100) NOT NULL,
	CPF CHAR (11) NOT NULL,
	Tempo_espera SMALLINT,
	Salario DECIMAL (12,2)
);

INSERT INTO recrutadoras
	(nome,cpf,tempo_espera, salario) VALUES
	('Doufim', '12345678912',2,10000.00),
	('Joafim', '32165498701',3,20000.00),
	('Cafim', '45678912305', 4, 1500.00);  

SELECT * FROM recrutadoras;