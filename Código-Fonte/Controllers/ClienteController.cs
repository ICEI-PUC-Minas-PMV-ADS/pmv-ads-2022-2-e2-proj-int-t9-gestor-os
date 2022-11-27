using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorOS.Models;
using GestorOS.Filters;

namespace GestorOS.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ClienteController : Controller
    {
        private readonly BancodeDados _context;

        public ClienteController(BancodeDados context)
        {
            _context = context;
        }

        // GET: Cliente
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdensDeServicos/Create

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,Descricao,Tipo,Data,Feito,Perfil")] OrdensDeServicos ordensDeServicos)
        {
            if (ModelState.IsValid)
            {

                _context.Add(ordensDeServicos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Cliente");
            }
            return View(ordensDeServicos);
        }
    }
}
