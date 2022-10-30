# Tela Padrão da Aplicação - Gestor de Ordem de Serviços [OS]



## Tela de Login

##### Como requisito gerador da funcionalidade é requerido uma tela de login que permita o filtro ad hoc do usuário cliente e administrador. Com controles de Email, Senha e Botão de ação - com cadastro a priori.

> Aspecto Visual

![Login](https://user-images.githubusercontent.com/36858665/198390029-830e7b3e-659d-4fce-a70c-1b03f71d4387.png)

> Artefato de Construção

```C#
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
        <input type="text" asp-for="Login" placeholder="Usuário ou email" class="form-control" style="height= 10px;" id="login">
        @Html.ValidationMessageFor(x => x.Login)
    </div>
    <div class="mb-3">
        <label style="font-family:'Helvetica'; font-size:larger; font-weight: bold; color:white; text-shadow:  1px 1px 2px black;" for="senha" class="form-label">Senha</label>
        <input type="password" placeholder="Senha" asp-for="Senha" class="form-control" id="exampleInputPassword1">
        @Html.ValidationMessageFor(x => x.Senha)
    </div>
    <button type="submit" class="btn btn-primary" style="background-color:darkorange; 
                                                         border: 0px;
                                                         border-radius:300px;
margin-left:39.5%;"
      >Entrar</button>

</form>
```

## Tela de Solicitação/Criação de OS's 

##### Como requisito gerador da funcionalidade é requerido uma tela de login que permita ao usário cliente criar/solicitar a criação de OS's.

> Aspecto Visual


![Criar](https://user-images.githubusercontent.com/36858665/198392799-f837b748-47fa-461e-a63e-a76b11b56a69.png)

> Artefato de Construção

```C#
@model GestorOS.Models.OrdensDeServicos

@{
    ViewData["Title"] = "Gestor OS";
}

<h1 style="font-size:medium; font-weight:bolder; color:blanchedalmond ; text-shadow: 1px 1px 2px black;">Adicionar Ordens de Serviços</h1>

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
                <input asp-for="Tipo" class="form-control" />
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
                <input type="submit" value="Criar" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action="Index">Voltar para a lista de OS</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
```




## Tela de Gestão das OS's

##### Como requisito gerador da funcionalidade é requerido uma tela onde o usuário administrador possa controlar, acompanhar, excluir, editar, ver detalhes e concluir as solicitações previamente feitas pelos clientes. 

> Aspecto Visual



![ordensservicos](https://user-images.githubusercontent.com/36858665/198395087-de8d970b-9b58-4623-82f5-e8f18fe179e2.png)

> Artefato de Construção

```C#
@model IEnumerable<GestorOS.Models.OrdensDeServicos>

@{
    ViewData["Title"] = "Index";
}

<h1 style="text-align:center;
         font-size:medium; color:grey; 
         text-shadow: 1px 1px 2px white;
         font-family: sans-serif; 
         font-weight: bold">TABELA DE GERENCIAMENTO DE ORDENS DE SERVIÇOS.</h1>

<p>
    <a style="font-size:medium; 
              font-weight:bolder; 
              color:blanchedalmond ;
              text-shadow: 1px 1px 2px black;"
    ;" asp-action="Create">Criar OS</a>
</p>

<div class="shadow-lg p-3 mb-5 bg-body rounded">
    <table style="font-family:sans-serif;font-weight:bolder; color: white; text-shadow:  1px 1px 2px black;" class="table table-bordered border-primary">
    <thead>
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Descricao)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Tipo)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Data)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Feito)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Descricao)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Tipo)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Data)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Feito)
            </td>
            <td>
                <a style="color:blanchedalmond"asp-action="Edit" asp-route-id="@item.Id">Editar</a> |
                <a style="color:blanchedalmond" asp-action="Details" asp-route-id="@item.Id">Detalhes</a> |
                <a style="color:blanchedalmond" asp-action="Delete" asp-route-id="@item.Id">Deletar</a>
            </td>
        </tr>
}
    </tbody>
</table>
</div>
```
