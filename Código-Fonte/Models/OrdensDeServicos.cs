using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorOS.Enums;
using Microsoft.Data;

namespace GestorOS.Models
{
    public class OrdensDeServicos
    {
        public int Id  { get; set; }
        public string Descricao { get; set; }

        public string Tipo { get; set; }
        public DateTime Data{ get; set; }

        public bool Feito { get; set; }
      

    }
}
