# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| CT-01 – Visualizar tela de login  	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - O site deve apresentar uma tela inicial de login para cada tipo de login o usuário deseja realizar. |
| Objetivo do Teste 	| Verificar se a aplicação web exibe todos os elementos requisitados. |
| Passos 	| - 1) Acessar o Navegador 
2) Informar o endereço da aplicação web 
3) Visualizar a página principal 
4) Selecionar a opção de usuário 
5) Visualizar a tela de login 
|
|Critério de Êxito | - Deve ser exibido uma tela de login para a entrada de usuários. |
|  	|  	|
| **Caso de Teste** 	| CT-02 – Visualizar página de cadastro de ordens de serviço.	|
|Requisito Associado | RF-03 - Na tela de entrada de dados da OS devem haver campos para o usuário informar o escopo de sua requisição.    |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com campos de preenchimento para o usuário cadastrar os dados das OSs. |
| Passos 	| 1) Acessar o Navegador 
2) Informar o endereço da aplicação web 
3) Visualizar a página principal 
4) Selecionar a opção de usuário 
5) Visualizar a tela de login 
6) Realizar o login 
7) Visualizar a página inserção de dados 
8) Cadastrar os dados da solicitação
9) Clicar em salvar
|
|Critério de Êxito | - Deve ser exibido após o login, uma página especifica para inserção de dados das OSs, salvar e informar o protocolo da ordem de serviço.|
|  	|  	|

| **Caso de Teste** 	| CT-03 – Visualizar página de Gerenciamento OS.	|
|Requisito Associado | RF-04 - Na tela de gerenciamento de OS, o site deverá exibir uma barra de pesquisa onde ao pesquisar as datas ou os tipos das OS elas serão exibidas    |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários, alterar, ver detalhes, excluir ou adicionar solicitações. |
| Passos 	| 
1) Acessar o Navegador 
2) Informar o endereço da aplicação web 
3) Visualizar a página principal 
4) Selecionar a opção de usuário 
5) Visualizar a tela de login 
6) Realizar o login 
7) Visualizar a página de registro
|
|Critério de Êxito | - Deve ser exibido após o login, uma página especifica do registro de dados dos funcionários e solicitações.|
|  	|  	| 

| **Caso de Teste** 	| CT-04 – Visualizar página de Alterar solicitação	|
|Requisito Associado | RF-04 -Na tela de gerenciamento de OS, o site deverá exibir uma barra de pesquisa onde ao pesquisar as datas ou os tipos das OS elas serão exibidas.   |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários e alterar a solicitação. |
| Passos 	| 
1) Acessar o Navegador 
2) Informar o endereço da aplicação web 
3) Visualizar a página principal 
4) Selecionar a opção de usuário 
5) Visualizar a tela de login 
6) Realizar o login 
7) Visualizar a página de registro
8) Escolher a solicitação desejada
9) Clicar em Alterar
10) Informar o que deseja ser alterado
11) Salvar para que seja alterado.
|
|Critério de Êxito | - Deve ser exibido na página especifica do gerenciamento de OS, a opção de alterar, informar o que deve ser alterado e salvar.|
|  	|  	| 

| **Caso de Teste** 	| CT-05 – Visualizar página de Deletar solicitação	|
|Requisito Associado | RF-06 -Na tela de gerenciamento de OS, o site deve exibir um procedimento de exclusão de OS. |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários, alterar, ver detalhes, excluir ou adicionar solicitações. |
| Passos 	| 
1) Acessar o Navegador 
2) Informar o endereço da aplicação web 
3) Visualizar a página principal 
4) Selecionar a opção de usuário 
5) Visualizar a tela de login 
6) Realizar o login 
7) Visualizar a página de registro
8) Escolher a solicitação desejada
9) Clicar na opção deletar
10) Confirmar se é essa solicitação e clicar em “Delete”
|
|Critério de Êxito | - Deve ser exibido na página especifica do gerenciamento de OS, a opção de deletar, escolher a OS e clicar em “Delete”.|
|  	|  	| 



> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
