using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorOS.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
