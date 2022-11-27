using GestorOS.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GestorOS.Repositorio
{
    public class CadastroRepositorio : ICadastro
    {
        private readonly BancodeDados _context;
        public CadastroRepositorio(BancodeDados bancodedados)
        {
            this._context = bancodedados; 
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioModel BuscarPorLogin(string email)
        {
            return _context.Usuario.FirstOrDefault(x => x.email.ToUpper() == email.ToUpper());
        }
    }
}
