# Programação de Funcionalidades



|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha". | Index.cshtml / LoginController.cs | 
|RF-002| A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS. Com campos para informar o escopo da requisição tais como: descrição, tipo, data e hora desejada para realização da demanda. | Create.cshtml / ClienteController.cs | 
|RF-003| A aplicação deverá exibir uma tela de controle das solicitações feitas, a fim de poder alterar, editar, excluir e criar ordens de serviço  | Index.cshtml / OrdensDeServicosController.cs |
|RF-004| A aplicação deverá utilizar um seletor na tela de login para verificar o tipo de perfil do usuário. | PerfilEnum.cs |
|RF-005| É um requisito não funcional. A aplicação deverá ter um filtro para identificar quais páginas os tipos de usuários poderão acessar. | PaginaParaAdministradorLogado.cs |
|RF-006| É um requisito não funcional. A aplicação deverá ter um filtro para identificar quais páginas os tipos de usuários poderão acessar. | PaginaParaUsuarioLogado.cs |
|RF-007| É um requisito não funcional. A aplicação deverá exibir a sessão criada quando logado. | Sessao.cs / ISessao.cs | 
|RF-008| Controlador do Administrador | AdmController.cs |
|RF-009| Controlador do Usuário | UsuariosController.cs |
|RF-010| Controlador do Cadastro | CadastroController.cs |
|RF-011| Controlador Restrito | RestritoController.cs |

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

## Controlador do Administrador

> aspecto visual

![adm_controller1](https://user-images.githubusercontent.com/76191741/204132642-896d7e2e-b476-458d-841a-4ae799c76989.JPG)

![adm_controller2](https://user-images.githubusercontent.com/76191741/204132653-2f7fcaf1-e0d8-485e-a2a0-40a61edf96a1.JPG)

![adm_controller3](https://user-images.githubusercontent.com/76191741/204132659-0e266cdf-0cef-4aab-a826-ae15af1473ba.JPG)

![adm_controller4](https://user-images.githubusercontent.com/76191741/204132667-7a0edce7-5d2e-4fc7-aeb6-55ffb97cd85a.JPG)

## Controlador do Usuário

> aspecto visual

![user_controller1](https://user-images.githubusercontent.com/76191741/204132682-91c07bb7-c081-4e5e-96ee-387f8bdb95fd.JPG)

![user_controller2](https://user-images.githubusercontent.com/76191741/204132684-e8c3f701-417f-4df1-b282-fb72f941fc00.JPG)

![user_controller3](https://user-images.githubusercontent.com/76191741/204132691-da1f07e6-686c-449b-99da-f85ff319501d.JPG)

![user_controller4](https://user-images.githubusercontent.com/76191741/204132693-efd63dfd-5b37-470d-a393-0fed4427d0b3.JPG)

## Controlador do Cadastro

> aspecto visual

![cadastro_controller](https://user-images.githubusercontent.com/76191741/204132704-bc5908d8-53da-4068-a40d-6f7508890f5a.JPG)

## Controlador Restrito

> aspecto visual

![restrito_controller](https://user-images.githubusercontent.com/76191741/204132732-66cfcbff-4ccb-4e95-a307-419b7f78ae18.JPG)


# Instruções de acesso

Para ter acesso a aplicação interativa, <a href="https://gestordeos.azurewebsites.net/">clique aqui</a>.

Para fazer o login no sistema, utilize os dados abaixo:

Email: eduardoramossilva@live.com
<br>
Senha: *

