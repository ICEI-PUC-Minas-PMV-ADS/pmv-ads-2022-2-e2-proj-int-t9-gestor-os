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
        public Usuario Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public Usuario BuscarPorLogin(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.email.ToUpper() == email.ToUpper());
        }
    }
}
