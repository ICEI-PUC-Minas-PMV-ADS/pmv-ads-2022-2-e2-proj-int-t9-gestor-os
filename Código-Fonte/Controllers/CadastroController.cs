using GestorOS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GestorOS.Controllers
{

    
    public class CadastroController : Controller
    {
        private readonly BancodeDados _context;

        //    private readonly ICadastro _cadastroRepositorio;
        //   public UsuariosController(ICadastro cadastroRepositorio)
        //   {
        //        _cadastroRepositorio = cadastroRepositorio; 
        //   }
        //   [HttpPost]
        //   public IActionResult Criar(Usuario usuario)
        // {
        //      _cadastroRepositorio.Adicionar(usuario);
        //       return RedirectToAction("Index");
        //    } 

        public CadastroController(BancodeDados context)
        {
            _context = context;
        }
        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,email,Perfil")] UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");

            }
            return View(usuario);
        }
    }
}

