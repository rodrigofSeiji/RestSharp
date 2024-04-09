Feature: Validar pesquisa por departamento existente pelo ID

A short summary of the feature

@tag1
Scenario: [Validar pesquisa por departamento existente pelo ID]
	Given [que o usuário tem acesso à API]
	When [o usuário envia uma requisição GET para obter o departamento com o ID 22]
	Then [a API deve retornar código de status 200 OK]
