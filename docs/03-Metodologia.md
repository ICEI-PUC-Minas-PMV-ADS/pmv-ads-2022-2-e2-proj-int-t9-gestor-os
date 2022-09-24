
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software : Versão V1
- `unstable`: versão já testada do software, porém instável : Versão V2
- `testing`: versão em testes do software : Versão V4
- `dev`: versão de desenvolvimento do software : Versão V1

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: Foi adicionado o banco de dados ao projeto.
- `bug`: Página de loggin não está loggando.
- `enhancement`: Edição Ordens de Serviços.
- `feature`: Funcionalidade página de cadastro.

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

<li>Foi feito duas ramificações (branchs), uma com o nome "Master" que contém o projeto na primeira versão, e um branch de testes que é derivado de Master, o "Testes".
<li>Os commits são feitos na ramificação "Testes" sem alterar o projeto original que se encontra em "Master", Para cada commit é criado uma nova versão de "Testes".
<li>Depois de feito todas as realizações de testes, O membro da equipe que está na ramificação Master poderá fazer a fusão dos dois ramos gerando uma unica versão estável do software (git merge).
<li> Gerenciamos em conjunto as issues, fazemos uma reunião e dividimos  para qual membro da equipe que irá se responsabilizar, e depois, o membro fará um commit na branch
 "Testes".
  
## Gerenciamento de Projeto
### Divisão de Papéis
A equipe está organizada da seguinte maneira:
-	<strong>Scrum Master:</strong> Eduardo Ramos
-	<strong>Product Owner:</strong> Bemvilac dos Santos.
-	<strong>Equipe de Desenvolvimento:</strong> Gabriel Vinícius; Gustavo Henrique;
- <strong>Equipe de Design:</strong> Lucas Alexandre; Guilherme Costa
### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo poderá fazer uso de ferramentas on-line para acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
 
Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Trello estruturado com as seguintes listas: 

-   <strong>A fazer:</strong> esta lista contém as tarefas que devem ser executadas futuramente no projeto.
- 	<strong>Em andamento:</strong> Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos desenvolvendo
-	<strong>Concluído:</strong> esta lista do trello contém todas as etapas concluídas da aplicação e que já foram testadas pela equipe.

O quadro kanban do grupo no Trello está disponível através da URL  ** e é apresentado, no estado atual, na figura abaixo. A definição desta estrutura se baseou na proposta feita por Littlefield (2016).

<img src='img/trello-2.png'/><br>
A tarefas são, ainda, etiquetadas em função da natureza da atividade e seguem o seguinte esquema de cores/categorias:
-	Feito
-	Em execução
-	Finalizado
-	Atrasado

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código : Visual Studio Code 19
- Ferramentas de comunicação : Teams.
- Ferramentas de desenho de tela (_wireframing_): MockFlow.

O editor de código foi escolhido porque ele possui uma integração com o
sistema de versão. As ferramentas de comunicação utilizadas possuem
integração semelhante e por isso foram selecionadas. Por fim, para criar
diagramas utilizamos essa ferramenta por melhor captar as
necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [MockFlow] - Criação de diagramas. (Equipe já tem experiencia com o programa)
> - [Github](https://github.com/) - Repositório do projeto
> - [VisualStudioCode 2019] - Edição de codigo (O mais completo na visão dos desenvolvedores da equipe)
> - [Git] - Organização de commits,versionamento e etc.. do projeto ao Github. (Recomendação da faculdade)
> - [Microsoft SQL Server] - Conexão com o banco de dados. (Facil manuseio)
> - [NClass] - Ferramenta para criação de Diagrama de Classes UML (Equipe já tem experiencia com esse programa)
> - [Trello] - Para organização de sprints e backlog de desenvolvimento. (Praticidade do manuseio)
