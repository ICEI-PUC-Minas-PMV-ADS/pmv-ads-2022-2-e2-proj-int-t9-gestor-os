
using GestorOS.Helper;
using GestorOS.Models;
using GestorOS.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorOS.Controllers
{

    public class LoginController : Controller
    {
        private readonly ICadastro _cadastroRepositorio;
        private readonly ISessao _sessao;
        public LoginController(ICadastro cadastro, ISessao sessao)
        {
            _cadastroRepositorio = cadastro;
            _sessao = sessao;

        }
        public IActionResult LoginAdm()
        {
            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "");
            return View();


        }

        public IActionResult Index()
        {
           if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
    
        }
        public IActionResult Home()

        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");

        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");   
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            
            try
            {
                
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _cadastroRepositorio.BuscarPorLogin(loginModel.Login);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                            if (usuario.Perfil == GestorOS.Enums.PerfilEnum.Admin)
                            {
                                return RedirectToAction("Index", "OrdensDeServicos");
                            }
                            if (usuario.Perfil == GestorOS.Enums.PerfilEnum.Padrao)
                            {
                                return RedirectToAction("Create", "Cliente");
                            }
                        }
                        TempData["MensagemErro"] = $"Senha do usuário é invalida, tente novamente";
                    }


                    TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login,tente novamente";

                }
                return RedirectToAction("Index", "Login");
            }

            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login , erro: {erro.Message}";
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
  

