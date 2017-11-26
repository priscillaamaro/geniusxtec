using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class StatusChamado
    {
        public String id { get; set; }
        public String descricao { get; set; }

        public StatusChamado() { }
        public StatusChamado(String id)
        {
            this.id = id;
        }
        public StatusChamado(String id, String descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public Boolean fechado() {
            return id == "7";
        }

        public override string ToString()
        {
            return id + " - " + descricao;
        }
    }
}
