using GestorOS.Migrations;
using GestorOS.Models;

namespace GestorOS.Repositorio
{
    public interface ICadastro
    {
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel BuscarPorLogin(string email);

    }
}
