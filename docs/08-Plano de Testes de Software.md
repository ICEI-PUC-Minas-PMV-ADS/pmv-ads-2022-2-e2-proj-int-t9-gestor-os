# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes utilizados na realização dos testes da aplicação, coincidindo com os requisitos funcionais e mostrando os critérios de êxito.

Casos de testes:
 
| **Caso de Teste** 	| CT-01 – Visualizar tela de login  	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha" e escolher qual tipo de usúario. |
| Objetivo do Teste 	| Verificar se a aplicação web exibe todos os elementos requisitados. |
|   Passos | -                     -                 -     | 
|    1   	|    Acessar o Navegador                        |
|    2    |    Informar o endereço da aplicação web       |
|    3    |    Visualizar a página principal              |
|    4    |    Selecionar a opção de "Faça o Login"       |
|    5    |    Visualizar a tela de login                 |
|Critério de Êxito | Deve ser exibido uma tela de login para a entrada de usuários. |

<br>*

| **Caso de Teste** 	| CT-02 – Visualizar página de cadastro de ordens de serviço.	|
| :---: | :---:|
|Requisito Associado | RF-02 - A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS onde haverão campos para informar o escopo de requisição tais como: Descrição, tipo, data , horário e realização da OS.    |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com campos de preenchimento para o usuário cadastrar os dados das OSs. |
| Passos |  -                -                         - |            
|    1   |     Acessar o Navegador                       |
|    2   |     Informar o endereço da aplicação web      |
|    3   |     Visualizar a página principal             |
|    4   |     Selecionar a opção de "Faça o Login"      |
|    5   |     Visualizar a tela de login                |  
|    6   |     Realizar o login                          |
|    7   |     Visualizar a página inserção de dados     |
|    8   |     Cadastrar os dados da solicitação         |
|    9   |     Clicar em salvar                          |       
|Critério de Êxito |  Deve ser exibido após o login, uma página especifica para inserção de dados das OSs, salvar e informar o protocolo da ordem de serviço.|

<br>*

| **Caso de Teste** 	| CT-03 – Visualizar página de Gerenciamento OS.	|
| :---: | :---:|
|Requisito Associado | RF-03 - A aplicação deverá exibir uma tela para o Admnistrador onde ele poderá alterar, editar , excluir e criar ordens de serviços |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários, alterar, ver detalhes, excluir ou adicionar solicitações. |
| Passos   |     -                  -              -  |
|     1    |     Acessar o Navegador                  |
|     2    |     Informar o endereço da aplicação web |
|     3    |     Visualizar a página principal        |
|     4    |     Selecionar a opção de "Faça o Login" | 
|     5    |     Visualizar a tela de login           |
|     6    |     Realizar o login                     |
|     7    |     Visualizar a página de registro      |
|Critério de Êxito | Deve ser exibido após o login, uma página especifica do registro de dados dos funcionários e solicitações.|
<br>*

| **Caso de Teste** 	| CT-04 – Visualizar página de Alterar solicitação	|
| :---: | :---:|
|Requisito Associado | RF-03 -A aplicação deverá exibir uma tela para o Admnistrador onde ele poderá alterar, editar , excluir e criar ordens de serviços  |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários e alterar a solicitação. |
| Passos 	|  -              -                 -   |
|   1     |  Acessar o Navegador                  |
|   2     |  Informar o endereço da aplicação web | 
|   4     |  Visualizar a página principal        |
|   5     |  Selecionar a opção de "Faça o Login" |
|   6     |  Visualizar a tela de login           |
|   7     |  Realizar o login                     |
|   8     |  Visualizar a página de registro      |
|   9     |  Escolher a solicitação desejada      |
|   10    |  Clicar em Alterar                    |
|   11    |  Informar o que deseja ser alterado   | 
|   12    |  Salvar para que seja alterado.       |
|Critério de Êxito | Deve ser exibido na página especifica do gerenciamento de OS, a opção de alterar, informar o que deve ser alterado e salvar.|

<br>*

| **Caso de Teste** 	| CT-05 – Visualizar página de Deletar solicitação	|
| :---: | :---:|
|Requisito Associado | RF-03 -A aplicação deverá exibir uma tela para o Admnistrador onde ele poderá alterar, editar , excluir e criar ordens de serviços |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários, alterar, ver detalhes, excluir ou adicionar solicitações. |
| Passos 	|        -         -             -       |
|    1    |        Acessar o Navegador             |                 
|    2    |  Informar o endereço da aplicação web  |
|    3    |  Visualizar a página principal         |
|    4    |  Selecionar a opção de "Faça o Login"  | 
|    5    |  Visualizar a tela de login            |       
|    6    |  Realizar o login                      |
|    7    |  Visualizar a página de registro       |
|    8    |  Escolher a solicitação desejada       |
|    9    |  Clicar na opção deletar               |          
|    10   |  Confirmar se é essa solicitação e clicar em “Delete” |
|Critério de Êxito | Deve ser exibido na página especifica do gerenciamento de OS, a opção de deletar, escolher a OS e clicar em “Delete”.|


| **Caso de Teste** 	| CT-06 – Visualizar página de Pesquisar OS	|
| :---: | :---:|
|Requisito Associado | RF-04 -A aplicação deverá exibir uma tela para pesquisar as OS's  |
| Objetivo do Teste 	| Verificar se a aplicação web exibe uma página com dados dos funcionários e alterar a solicitação. |
| Passos 	|  -              -                 -   |
|   1     |  Acessar o Navegador                  |
|   2     |  Informar o endereço da aplicação web | 
|   4     |  Visualizar a página principal        |
|   5     |  Selecionar a opção de "Faça o Login" |
|   6     |  Visualizar a tela de login           |
|   7     |  Realizar o login Adm                 |
|   8     |  Visualizar a página de registro      |
|   9     |  Selecionar o campo em branco após o "Pesquisar" e digitar o que deseja      |
|Critério de Êxito | Deve ser exibido o resultado da pesquisa.|

<br>*

| **Caso de Teste** 	| CT-07 – Visualizar página de Gerenciar os Usuarios	|
| :---: | :---:|
|Requisito Associado | RF-05 -A aplicação deverá exibir uma tela para o Admin gerenciar os Usuários.  |
| Objetivo do Teste 	| Verificar se o Perfil Adm consegue gerenciar os usuarios. |
| Passos 	|  -              -                 -   |
|   1     |  Acessar o Navegador                  |
|   2     |  Informar o endereço da aplicação web | 
|   4     |  Visualizar a página principal        |
|   5     |  Selecionar a opção de "Faça o Login" |
|   6     |  Visualizar a tela de login           |
|   7     |  Realizar o login Adm                 |
|   8     |  Visualizar a página de registro      |
|   9     |  Selecionar a opção "Gerenciar os usuários"     |
|Critério de Êxito | Deve ser exibido a lista de registros de gerenciamento de usuários.|



