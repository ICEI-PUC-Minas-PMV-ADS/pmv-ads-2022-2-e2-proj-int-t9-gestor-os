using GestorOS.Models;

namespace GestorOS.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoDoUsuario();
        void CriarSessaoAdm(UsuarioModel usuario);
    }
}
