# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: https://gestoros.azurewebsites.net/
<br> Para logar com admin use Email: admin2@gmail.com  senha: 2


## Cadastre-se (RNF-01, RF-01)
A tela de CADASTRO do sistema contém campos para inserir o email, nome, senha e tipo de Usuário, assim que feito o cadastro essas informações são enviadas ao SGBD SQL Server, cadastradas e liberando o usuário para poder fazer o login no sistema.

<img src ="/docs/img/Cadastrar.png">
## Artefatos da funcionalidade 

 <li> UsuarioController.cs </li>
 <li> Create.htmlcs </li>

## Enviar OS(RNF-002,RF-02)

Na tela de criação das ordens de serviços , o usuário irá informar a descrição, tipo, data , hora e se já foi realizado a OS. Depois de feito, a ordem de serviço irá ser enviada ao SGBD SQL SERVER onde o administrador do sistema poderá visualizar e fazer suas edições das ordens de serviços.
<img src ="/docs/img/Enviarr.png">

### Artefatos da funcionalidade 

 <li> OrdensDeServicosController.cs </li>
 <li> Create.htmlcs </li>
 
## Gerenciar OS (RF-03,RF-04)

Tela de gerenciamento de ordens de serviços onde o administrador tem 2 CRUD'S, um para ordens de serviços que foram registradas no banco de dados e um para gerenciar os usuários.

<img src ="/docs/img/Gerenciarr.png">

### Artefatos da funcionalidade 

 <li> AdmController.cs  </li>
 <li> OrdensDeServicosController.cs </li>
 <li> UsuarioController.cs  </li>
 <li> Create.htmlcs </li>
 <li> Details.htmlcs </li>
 <li> Edit.htmlcs</li>
 <li> Index.htmlcs </li>

## Gerenciar Usuários (RF-05)
Tela de gerenciamento de usuários onde somente o administrador do sistema pode acessar, a tela contém todos os usuários que fizeram registro no site e o administrador poderá alter cada campo registrado ou criar um novo login.

<img src ="/docs/img/Usuars.png">

### Artefatos da funcionalidade 
 <li> AdmController.cs  </li>
 <li> UsuarioController.cs  </li>
 <li> Create.htmlcs </li>
 <li> Details.htmlcs </li>
 <li> Edit.htmlcs</li>
 <li> Index.htmlcs </li>
 <li> Adm.htmlcs </li>
 

## Disponibilidade do sistema(RNF-02/03,04,05)

Com o código a seguir , o sistema mantém as sessões dos usuários aberta por somente 1 hora, disponiblidade em todos os horários e suporta pelo menos dez usuários simultaneamente 24/7.

<img src ="/docs/img/CODIGO.png">

### Artefatos da funcionalidade 

 <li>appsettings.json </li>
 <li>profile.arm.json </li>
 <li>launchSettings.json </li>
 <li>Startup.cs </li>
 <li>Program.cs </li>

### Requisitos atendidos 

- RNF-001	Os dados inseridos pelos usuários na tela de login serão cadastrados no banco de dados.
- RNF-002	Os dados das OSs devem mostrar data, hora e situação para o coordenador/administrador.
- RNF-003	A aplicação web deverá ter disponibilidade em todos os horários.
- RNF-004	A aplicação web deve manter o usuário logado somente por 1 hora.
- RNF-005	A aplicação deve suportar pelo menos dez usuários simultaneamente, e se manter disponível 24/7.

### Artefatos da funcionalidade 
<h1> Controllers:</h1>
<ul>
 
 <li> AdmController.cs </li>
 <li> ClienteController.cs </li>
 <li> UsuarioController.cs </li>
 <li> HomeController.cs </li>
 <li> LoginController.cs </li>
 <li> RestritoController.cs </li>
 <li> OrdensDeServiçosController.cs </li>
 <li> CadastroController.cs </li>
  
</ul>
  
  <h1> Sessions( Controla a sessão do usuário e administrador )  </h1>
 <ul>
  <li> Sessao </li>
  <li> |Sessao </li>
 </ul>
  <h1> Filters( Controla os filtros para usuário e administrador )  </h1>
  <li> PaginaParaAdmnistradorLogado.cs </li>
  <li> PaginaParaUsuarioLogado.cs </li>
  


## Requisitos atendidos
|ID    | Descrição do Requisito                                                                                                                        |Prioridade|
|------|-----------------------------------------------------------------------------------------------------------------------------------------------|----------|
|RF-001| A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha" e escolher qual tipo de usúario.               |Alta      |
|RF-002| A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS onde haverão campos para informar o escopo de requisição tais como: Descrição, tipo, data , horário e realização da OS.                               |Alta      |
|RF-003| A aplicação deverá exibir uma tela para o Administrador onde ele poderá alterar, editar , excluir e criar ordens de serviços | Média     |
|RF-004| A aplicação deverá exibir uma uma barra de pesquisa na tela de gerenciamento de ordens de serviços para pesquisar as OS's | Média     |
|RF-005| A aplicação deverá exibir uma tela para o administrador criar, deletar, detalhar, e alterar os usuários. | Média     |

## SQL SERVER
<img src ="/docs/img/TABELASSQL.png">


