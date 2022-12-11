# Tela Padrão da Aplicação - Gestor de Ordem de Serviços [OS]

## Tela de Principal

##### Como requisito gerador da funcionalidade é requerido uma tela de login que permita o filtro ad hoc do usuário cliente e administrador. Com controles de Email, Senha e Botão de ação - com cadastro a priori.

> Aspecto Visual

![Tela Principal](https://user-images.githubusercontent.com/108990294/204097536-2d0d01a8-1bca-46ee-b967-1e03a8444c23.png)


> Artefato de Construção

```` C#
@{

    ViewData["Title"] = "Página Principal";
}

<div class="text-center">
     <a class="navbar-brand"  asp-controller="Login" asp-action="Sair">Sair</a>
     <a class="navbar-item" href="/OrdensDeServicos">
         <input type="button" value="Página para ADM"/>
         </a>

     <a class="nav-item" href="/Cliente/Create">
        <input type="button" class="btn-primary" value="Criar OS"/>
     </a>




    <h1 style="font-family:sans-serif;
               font-weight:bold;
               color:blanchedalmond;
               text-shadow:1px 1px 2px black;" class="display-4">
       ORDENS DE SERVIÇOS
    </h1>
    <p style="color:grey;
               text-shadow: 1px 1px 2px white;
               font-family:
               sans-serif;
               font-weight: bold;">Aqui é mais fácil organizar sua empresa.</p>
 
    <div style="font-family:Caladea;
                font-weight: bolder;
                color:black;" class="card-group">
        <div class="small-card">
            <img src="~/css/2083280.png" class="card-img-top" alt="...">
            <div class="card-body">
                <a style="font-size: small; font-weight: bolder; color:black; text-shadow:1px 1px 2px white;" href="https://elevesuasvendas.com.br/blog/negocios/ordem-de-servico-online#:~:text=Uma%20ordem%20de%20servi%C3%A7o%20%C3%A9,tudo%20que%20comp%C3%B5e%20a%20entrega.">
                    <h5 class="card-title">EMPRESAS</h5>
                    <p class="card-text">Saiba mais sobre ordens de serviços.</p>
                </a>
            </div>
            <div class="card-footer">
            </div>
        </div>
        <div class="small-card">
            <img src="~/css/25231.png" class="card-img-top" alt="...">

            <div class="card-body">
                <a style="font-size: small; font-weight: bolder; color:black; text-shadow:1px 1px 2px white;" href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t9-gestor-os/tree/main">

                    <h5 class="card-title">PROJETO NO<span style="color:green;"> GITHUB</span>.</h5>
                    <p class="card-text">Codigo fonte, issues, documentação e exemplos.</p>
                </a>

            </div>
            <div class="card-footer">
            </div>
        </div>
    </div>
</div>
````
## Tela de Criação de Usuário

##### Como requisito gerador da funcionalidade, o usuário ao clicar em cadastre-se é levada a uma tela de cadastro de novo usuário, podendo definir se a criação de um usuário Administrador ou um Cliente.

> Aspecto Visual

![Criar Usuário](https://user-images.githubusercontent.com/108990294/204066743-7d0a33d4-617d-4704-a8d9-b1a726b6bfe3.png)

> Artefato de Construção
```` C#
@model UsuarioModel
@{
    ViewData["Title"] = "Cadastrar usuário";
}
<script>
    function mensagem() {
        alert('Seu usuário foi criada com sucesso.');
    }
</script>

<h1 style="font-size:larger; font-weight:bolder; color:blanchedalmond ; text-shadow: 1px 1px 2px black;">Criar</h1>

<h4 style ="font-size:medium; font-weight:bolder; color:blanchedalmond ; text-shadow: 1px 1px 2px black;">Usuario</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form asp-action="Create">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="Nome" class="control-label"></label>
                <input asp-for="Nome" class="form-control" />
                <span asp-validation-for="Nome" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Senha" class="control-label"></label>
                <input type="password" asp-for="Senha" class="form-control" />
                <span asp-validation-for="Senha" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="email" class="control-label"></label>
                <input asp-for="email" class="form-control" />
                <span asp-validation-for="email" class="text-danger"></span>
            </div>
           
            <div class="form-group">
                <input onclick="mensagem()" type="submit" value="Feito" class="btn btn-primary" />
            </div>
            <select asp-for="Perfil">
                <option value="0">Selecione</option>
                <option value="@GestorOS.Enums.PerfilEnum.Admin">Adm</option>
                <option value="@GestorOS.Enums.PerfilEnum.Padrao">Cliente</option>
            </select>
            <span asp-validation-for="Perfil" class="text-danger"></span>
    
        </form>
    </div>
</div>

<div>
    <a asp-action="Index">Voltar a página inicial</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
````
## Tela de Login

##### Como requisito gerador da funcionalidade é requerido uma tela de login que permita o filtro ad hoc do usuário cliente e administrador. Com controles de Email, Senha e Botão de ação - com cadastro a priori.

> Aspecto Visual

![Tela de Login](https://user-images.githubusercontent.com/108990294/204067081-758b00b7-7713-4feb-b43f-988ec0c3d624.png)

> Artefato de Construção
```` C#
@using GestorOS.Enums
@model LoginModel

@{ 

    Layout = "LayoutDeslogado";
    ViewData["Title"] = "Login";
}
@if (TempData["MensagemErro"] != null)
{
    <div class="alert alert-danger" role="alert">
        <button type="button" class="btn btn-danger btn-sm close-alert" data-bs-dismiss="alert" aria-label="Close">X</button>
        @TempData["MensagemErro"]
    </div>
    
}
<form class="shadow-lg p-3 mb-5 bg-body rounded" style="margin-top:10%; margin-left: 27.5%; width: 40%; background-image: radial-gradient(circle at -7.92% 90.56%, #f5f9f1 0, #f4f9f2 3.33%, #f3faf3 6.67%, #f2faf4 10%, #f1faf5 13.33%, #f0faf6 16.67%, #f0faf7 20%, #effaf8 23.33%, #effaf9 26.67%, #eefafa 30%, #eefafb 33.33%, #effafc 36.67%, #effafd 40%, #effafe 43.33%, #f0f9ff 46.67%, #f1f9ff 50%, #f2f9ff 53.33%, #f3f8ff 56.67%, #f4f8ff 60%, #f5f8ff 63.33%, #f7f7ff 66.67%, #f8f7ff 70%, #f9f7fe 73.33%, #fbf6fe 76.67%, #fcf6fd 80%, #fdf6fc 83.33%, #fef6fb 86.67%, #fff5fa 90%, #fff5f9 93.33%, #fff5f8 96.67%, #fff5f7 100%); border-radius:10px; " asp-controller="Login" asp-action="Entrar" method="post">

    <div class="mb-3">
        <h1 class="text-center" style="color:navajowhite; text-shadow:  1px 1px 2px black; font-family:'Montserrat', sans-serif; font-size:medium; font-weight:bolder; ">Faça o login para continuar</h1>
        <label for="exampleInputEmail1" class="form-label" style="font-family:'Helvetica'; font-size:larger; font-weight: bold; color:white; text-shadow:  1px 1px 2px black;">Email</label>
        <input type="text" asp-for="Login" placeholder="Email" class="form-control" style="height= 10px;" id="email">
        @Html.ValidationMessageFor(x => x.Login)
    </div>
    <div class="mb-3">
        <label style="font-family:'Helvetica'; font-size:larger; font-weight: bold; color:white; text-shadow:  1px 1px 2px black;" for="senha" class="form-label">Senha</label>
        <input type="password" placeholder="Senha" asp-for="Senha" class="form-control" id="exampleInputPassword1">
        @Html.ValidationMessageFor(x => x.Senha)
             <select asp-for="Perfil">
                <option value="0" >Selecione </option>
                <option value="@GestorOS.Enums.PerfilEnum.Admin">Adm</option>
                <option value="@GestorOS.Enums.PerfilEnum.Usuario">Cliente</option>
              </select>
    
    </div>
    <button type="submit" class="btn btn-primary" style="background-color:darkorange; 
                                                         border: 0px;
                                                         border-radius:300px;
margin-left:39.5%;"
      >Entrar</button>

</form>
````
## Tela de Solicitação/Criação de OS's

##### Como requisito gerador da funcionalidade é requerido uma tela de login que permita ao usário cliente criar/solicitar a criação de OS's.

> Aspecto Visual

![Tela de Criação de OS](https://user-images.githubusercontent.com/108990294/204095609-aa25a328-071d-4e06-9568-89efb87eef56.png)

```` C#
@model GestorOS.Models.OrdensDeServicos 
@using GestorOS.Models

@{
    ViewData["Title"] = "Gestor OS";
}
<script>
    function mensagem() {
        alert("Sua OS foi criada com sucesso!");

    }
</script>

<h1 style="font-size:medium; font-weight:bolder; color:blanchedalmond ; text-shadow: 1px 1px 2px black;">Adicionar Ordens de Serviços</h1>
<a class="navbar-brand" style="font-size: medium;" href="/OrdensDeServicos">Gerenciar OS(somente admin)</a>

<hr />
<div class="row">
    <div class="col-md-4">

        <form asp-action="Create">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="Descricao" class="control-label"></label>
                <input asp-for="Descricao" class="form-control" />
                <span asp-validation-for="Descricao" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Tipo" class="control-label"></label>
                <select asp-for="Tipo">
                    <option value="0">Selecione </option>
                    <option value="Manutenção">Manutenção</option>
                    <option value="Limpeza">Limpeza</option>
                    <option value="Jardinagem">Jardinagem</option>
                    <option value="Troca">Troca</option>
                    <option value="Entrega">Entrega</option>
                    <option value="Segurança">Segurança</option>
                    <option value="Organização">Organização</option>
                </select>
                <span asp-validation-for="Tipo" class="text-danger"></span>
                
        
            
              
            
            </div>
            <div class="form-group">
                <label asp-for="Data" class="control-label"></label>
                <input asp-for="Data" class="form-control" />
                <span asp-validation-for="Data" class="text-danger"></span>
            </div>
            <div class="form-group form-check">
                <label class="form-check-label">
                    <input class="form-check-input" asp-for="Feito" /> @Html.DisplayNameFor(model => model.Feito)
                </label>
            </div>
            <div class="form-group">
                <a class="navbar-brand" asp-controller="Login" asp-action="Sair">Sair</a>
                <input onclick="mensagem()" type="submit" value="Criar" class="btn btn-primary" />
            </div>
                
        </form>
    </div>
</div>


@section Scripts {
    @{
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    }
    }

````
## Tela de Acesso Restrito

##### Como requisito gerador da funcionalidade é requerido uma tela de advertência onde o usuário tenta acessar uma área sem ter permissão e recebe uma mensagem de acesso negado.

> Aspecto Visual 

![Tela Acesso Restrito](https://user-images.githubusercontent.com/108990294/204097898-c100c71d-f573-49ad-b2dd-f75a7fe4907c.png)

> Artefato de Construção

```` C#

@{
    ViewData["Title"] = "Acesso negado";
}
<script>
    function mensagem() 
        alert("Tente o login agora como : CLIENTE);
        
        </SCRIPT>
    
    <body style="background-color: black;">
     <strong style="color:red;text-shadow:2px 2px 2px 1px black;">Você não tem permissão para acessar este tipo de conteúdo!   </strong>




    
    </body>
````

## Tela de Gestão das OS's

##### Como requisito gerador da funcionalidade é requerido uma tela onde o usuário administrador possa controlar, acompanhar, excluir, editar, ver detalhes e concluir as solicitações previamente feitas pelos clientes.

> Aspecto Visual Geral

![Tela de Gerenciamento de OS](https://user-images.githubusercontent.com/108990294/204068338-17df89b7-4e9a-4ff0-a5c4-669b19ae9f31.png)

> Aspecto Visual Edição

![Tela de Gerenciamento de OS - Edição](https://user-images.githubusercontent.com/108990294/204068797-89fa9123-770d-4088-95cb-518b329dbead.png)

> Aspecto Visual Detalhes das OS

![Tela de Gerenciamento de OS - Detalhes](https://user-images.githubusercontent.com/108990294/204068808-8f5d6733-498b-4b69-a617-4c99a266b7c9.png)

> Aspecto Visual Deletar OS

![Tela de Gerenciamento de OS - Deletar](https://user-images.githubusercontent.com/108990294/204068815-2ed1eb00-4cfd-40b0-afa4-1f6a61d2d206.png)

> Artefato de Construção

```` C#
@model GestorOS.Models.OrdensDeServicos

@{
    ViewData["Title"] = "Delete";
}
<script>
    function mensagem(){
        alert("OS Deletada!");
    }
</script>
<a class="navbar-brand" asp-controller="Login" asp-action="Sair">Sair</a>
<h1 style="font-size:larger; font-weight:bolder; color:blanchedalmond ; text-shadow: 1px 1px 2px black;">Deletar</h1>

<h3 style="text-align:center; font-size:large; font-weight:bolder; color:red ; text-shadow: 1px 1px 2px white;">Tem certeza que deseja fazer isso?</h3>
<div>
    <h4 style="font-size:medium; font-weight:bolder; color:white ; text-shadow: 1px 1px 2px black;">Ordem de serviço:</h4>
    <hr />
    <dl style="font-size:medium; font-weight:bolder; color:white ; text-shadow: 1px 1px 2px black;"  class="row">
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Descricao)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Descricao)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Tipo)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Tipo)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Data)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Data)
        </dd>
        <dt class = "col-sm-2">
            @Html.DisplayNameFor(model => model.Feito)
        </dt>
        <dd class = "col-sm-10">
            @Html.DisplayFor(model => model.Feito)
        </dd>
    </dl>
    
    <form asp-action="Delete">
        <input type="hidden" asp-for="Id" />
        <input onclick="mensagem()" type="submit" value="Deletar" class="btn btn-danger" /> |
        <a asp-action="Index">Voltar para a lista de OS</a>
    </form>
</div>
````

## Tela de gerenciamento de usuários (somente adm)

##### Como requisito gerador da funcionalidade é requerido uma tela onde o usuário administrador possa gerenciar, acompanhar, excluir, editar, ver detalhes dos usuários cadastrados.

> Aspecto Visual Geral

![Tela de Gerenciamento de Usuários](https://user-images.githubusercontent.com/108990294/204096837-21b11403-80b2-4a9d-b0b9-562a34854deb.png)

> Artefato de Construção

```` C#
@model IEnumerable<GestorOS.Models.UsuarioModel>

@{
    ViewData["Title"] = "Usuario";
}
<a class="navbar-brand" style="margin-left: 80%; margin-top: 25px;" asp-controller="Login" asp-action="Sair">Sair</a>
<h1>Usuários</h1>

<p>
    <a asp-action="Create">Criar novo usuario</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Nome)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Senha)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.email)
            </th>
            <th>

                @Html.DisplayNameFor(model => model.Perfil)
            </th>

        </tr>


    </thead>
    <tbody>
        @foreach (var item in Model)
        {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.Nome)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Senha)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.email)

                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Perfil)
                </td>
                <td>
                    <a asp-action="Edit" asp-route-id="@item.Id">Edit</a> |
                    <a asp-action="Details" asp-route-id="@item.Id">Details</a> |
                    <a asp-action="Delete" asp-route-id="@item.Id">Delete</a>
                </td>
            </tr>
        }
    </tbody>
</table>
````
