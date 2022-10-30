using GestorOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GestorOS.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

         
            string sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
           
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;


            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);
            return View(usuario);
        }
    }
}
