using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cliente
    {
        public String id { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }
        public String endereco{ get; set; }
        public String uf { get; set; }
        public Usuario usuario { get; set; }
    }
}
