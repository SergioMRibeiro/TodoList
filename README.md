# Primeira API em C#.
## Motivo:
  Criar pequenos projetos para aprender novas tecnologias e melhorar meu conhecimento horizontalmente e satisfazer minha curiosidade no mundo do .NET.

## Descrição do projeto:
  O projeto se trata de um CRUD para gerenciar uma lista de tarefas do usuário. Ele roda em localhost e está na versão 1. Ele conta com o banco SQLite e uma documentação padrão gerada no Swagger. 

  Suas rotas são:
  * GET -> /v1/todos (Lista todas as tarefas existentes.)
  * GET -> /v1/todos/{id_da_tarefa} (Necessário passar um id pela rota. Exibe apenas uma tarefa selecionada)
  * POST -> /v1/todos (Necessário passar um body como o exemplo a seguir: `{"title": "string"}`. Ele irá criar uma nova tarefa.)
  * PUT -> /v1/todos/{id_da_tarefa} (Necessário passar um id na rota e um body como o exemplo a seguir: `{"title": "string", "done": "bool"}`. Ele irá alterar uma tarefa existente.)
  * DELETE -> /v1/todos/{id_da_tarefa} (Necessário passar um id na rota. Isso irá apagar uma tarefa existente)

## Pacotes utilizados
* Microsoft.EntityFrameworkCore.Sqlite
* Microsoft.EntityFrameworkCore.Design
