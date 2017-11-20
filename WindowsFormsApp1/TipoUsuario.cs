using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TipoUsuario
    {
        public String id { get; set; }
        public String descricao { get; set; }

        public TipoUsuario() { }
        public TipoUsuario(String id)
        {
            this.id = id;
        }
        public TipoUsuario(String id, String descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}
