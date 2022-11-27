using GestorOS.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Threading;

namespace GestorOS.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;
        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext; 
        }

        public void CriarSessaoAdm(UsuarioModel cadastro)
        {
            throw new System.NotImplementedException();
        }

        public UsuarioModel BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
        }

        public void CriarSessaoUsuario(UsuarioModel cadastro)
        {
            string valor = JsonConvert.SerializeObject(cadastro);
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado",valor);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }

    }
}
