using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ManutencaoDeUsuarios
    {
        Conexao con = new Conexao();

        public void salvar(Usuario usuario) {
            String sql = "INSERT INTO usuario VALUES (@valorLogin, @valorSenha, @valorTipo, @valorNome)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorLogin", usuario.login));
            parametros.Add(new SqlParameter("valorSenha", usuario.senha));
            parametros.Add(new SqlParameter("valorTipo", usuario.tipoUsuario.id));
            parametros.Add(new SqlParameter("valorNome", usuario.nome));

            con.executar(sql, parametros);
        }

        public void excluir(string login)
        {
            string sql = "UPDATE usuario SET status = 0 WHERE login = @valorLogin";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorLogin", login));

            con.executar(sql, parametros);
            
        }
    }
}
