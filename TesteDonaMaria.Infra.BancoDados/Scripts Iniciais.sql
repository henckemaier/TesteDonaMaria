--Criando a tabela de Materias
	CREATE TABLE [dbo].[TBMateria] (
		[Numero]      INT          IDENTITY (1, 1) NOT NULL,
		[NomeMateria] VARCHAR (50) NOT NULL,
		[Disciplina]  INT          NOT NULL,
		[Serie]       INT          NOT NULL,
		PRIMARY KEY CLUSTERED ([Numero] ASC)
	);


--Inserindo um registro na tabela
	INSERT INTO [TBMATERIA] 
	(
		[NOMEMATERIA], 
		[DISCIPLINA],
		[SERIE]
	)
	VALUES 
	(
		'Flora Brasileira',
		1,
		2
	); 
	--select Scope_Identity();

--Atualizando um registro da tabela
	UPDATE [TBMATERIA]	
		SET
			[NOMEMATERIA] = 'Flora Americana', 
			[DISCIPLINA] = 3,
			[SERIE] = 2
		WHERE
			[NUMERO] = 2

--Excluindo um registro da tabela
	DELETE FROM [TBMATERIA]
		WHERE 
			[NUMERO] = 6

--Retornando todos os registros da tabela
	SELECT 
		[NUMERO],
		[NOMEMATERIA], 
		[DISCIPLINA],
		[SERIE]
	FROM 
		[TBMATERIA]

--Retornando apenas um registro da tabela 
	SELECT 
		[NUMERO],
		[NOMEMATERIA], 
		[DISCIPLINA],
		[SERIE]
	FROM 
		[TBMATERIA]
	WHERE 
		[NUMERO] = 4

select count(*) from TBMateria