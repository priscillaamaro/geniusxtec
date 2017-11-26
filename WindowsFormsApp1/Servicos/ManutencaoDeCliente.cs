using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ManutencaoDeCliente
    {
        Conexao con = new Conexao();

        public void salvar(Cliente cliente)
        {
            String sql = "INSERT INTO cliente (nome, telefone, endereco, uf, login) VALUES (@valorNome, @valorTelefone, @valorEndereço, @valorUF, @valorLogin)";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorNome", cliente.nome));
            parametros.Add(new SqlParameter("valorTelefone", cliente.telefone));
            parametros.Add(new SqlParameter("valorEndereço", cliente.endereco));
            parametros.Add(new SqlParameter("valorUF", cliente.uf));
            parametros.Add(new SqlParameter("valorLogin", cliente.usuario.login));

            con.executar(sql, parametros);

        }

            public void excluirCliente(string id)
        {
            string sql = "UPDATE cliente SET status = 0 WHERE ID_CLIENTE = @valorId";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorId", id));

            con.executar(sql, parametros);
        }
    }
}
