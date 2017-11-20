using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Chamado
    {
        public String id { get; set; }
        public String descricao { get; set; }
        public Cliente cliente { get; set; }
        public StatusChamado status { get; set; }
        public PrioridadeChamado prioridade { get; set; }
        public String data_criacao { get; set; }
        public String data_fechamento { get; set; }
        public Usuario usuario_criacao { get; set; }
        public Usuario usuario_responsavel { get; set; }

    }
}
