# Programação de Funcionalidades



|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha". | Index.cshtml / LoginController.cs | 
|RF-002| A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS. Com campos para informar o escopo da requisição tais como: descrição, tipo, data e hora desejada para realização da demanda. | Create.cshtml / ClienteController.cs | 
|RF-003| A aplicação deverá exibir uma tela de controle das solicitações feitas, a fim de poder alterar, editar, excluir e criar ordens de serviço  | Index.cshtml / OrdensDeServicosController.cs |
|RF-004| A aplicação deverá verificar o perfil do usuário | PerfilEnum.cs |
|RF-005| A aplicação deverá exibir a página de Admin para usuário Admin logado | PaginaParaAdministradorLogado.cs |
|RF-006| A aplicação deverá exibir a página de Usuário para Usuário logado | PaginaParaUsuarioLogado.cs |
|RF-007| A aplicação deverá exibir a sessão criada quando logado | Sessao.cs / ISessao.cs | 

# Arquitetura do banco de dados

## Tabela Cliente

> aspecto visual 

![ClientesSGBD](https://user-images.githubusercontent.com/36858665/198900248-8c65ebf5-5d17-4dca-ad5c-9d49fb6d854a.png)

## Banco Usuários

> aspecto visual 

![SQLusuarios](https://user-images.githubusercontent.com/36858665/198900293-a4c3a23b-5974-4ef6-8b47-339f30f380e6.png)

## Tabela Ordens de Serviço [OSs]

> aspecto visual 

![SQLordensservicos](https://user-images.githubusercontent.com/36858665/198900311-b591a2da-ae83-473d-9635-dd8c7065e0a4.png)

## Perfil de Usuários

> aspecto visual

![Enums](https://user-images.githubusercontent.com/76191741/204103334-d28c6347-9293-41ed-8d4e-4612c6b41afb.JPG)

## Página para Usuário Admin

> aspecto visual

![Filters_admin_page](https://user-images.githubusercontent.com/76191741/204103409-53527a04-462b-48f6-8f0c-3f3eb58f198d.JPG)

## Página para Usuário Comum

> aspecto visual

![Filters_user_page](https://user-images.githubusercontent.com/76191741/204103437-e8e90f9c-e056-4d45-9f55-a93a11a18bc5.JPG)

## Sessão do Usuário

> aspecto visual

![Helper_sessao](https://user-images.githubusercontent.com/76191741/204103513-d60fa863-871c-4001-9ce7-1b024a767f32.JPG)

![Helper_ISessao](https://user-images.githubusercontent.com/76191741/204103518-25f79062-482e-463d-ad98-d17b55639031.JPG)



# Instruções de acesso

Para ter acesso a aplicação interativa, <a href="https://gestordeos.azurewebsites.net/">clique aqui</a>.

Para fazer o login no sistema, utilize os dados abaixo:

Email: eduardoramossilva@live.com
<br>
Senha: *

