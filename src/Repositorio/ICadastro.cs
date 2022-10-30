using GestorOS.Migrations;
using GestorOS.Models;

namespace GestorOS.Repositorio
{
    public interface ICadastro
    {
        Usuario Adicionar(Usuario usuario);
        Usuario BuscarPorLogin(string email);

    }
}
