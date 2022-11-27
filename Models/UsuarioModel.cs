using GestorOS.Enums;

namespace GestorOS.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string email { get; set; }
        public  PerfilEnum Perfil { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }

    }
}
