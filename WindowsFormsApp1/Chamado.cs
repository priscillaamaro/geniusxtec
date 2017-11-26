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
        StatusChamado s;
        public StatusChamado status { get { return s; } 
            set{
                this.s = value;
                if (this.s != null && this.s.fechado() && data_fechamento == "") {
                    data_fechamento = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
                }
            }
        }
        public PrioridadeChamado prioridade { get; set; }
        public String data_criacao { get; set; }
        public String data_fechamento { get; set; }
        public Usuario usuario_criacao { get; set; }
        public Usuario usuario_responsavel { get; set; }

    }
}
