using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PrioridadeChamado
    {
        public String id { get; set; }
        public String descricao { get; set; }

        public PrioridadeChamado() { }
        public PrioridadeChamado(String id)
        {
            this.id = id;
        }
        public PrioridadeChamado(String id, String descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}
