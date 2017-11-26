using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Usuario
    {
        public String login { get; set; }
        public String senha { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public String nome { get; set; }
        public String descricaoTipoUsuario { get { return tipoUsuario.descricao; } }
        public String status { get; set; }

        public Usuario() { }
        public Usuario(String login, String nome) {
            this.login = login;
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome + " (" + login + ")";
        }
    }
}
