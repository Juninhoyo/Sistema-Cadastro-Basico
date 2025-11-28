using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastroPessoa.Models
{
    
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public int Idade { get; set; }
        public string Email { get; set; } = "";        
    }
}