using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ManutencaoChamado
    {
        Conexao con = new Conexao();

        public void atualizar(Chamado chamado) {
            String sql = "UPDATE chamado SET " +
                " descricao=@valorDescricao, id_status_chamado=@valorIdStatus, " +
                " login_responsavel=@valorLoginResponsavel, data_fechamento=@valorDataFechamento " +
                " WHERE id_chamado=@valorId";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorDescricao", chamado.descricao));
            parametros.Add(new SqlParameter("valorIdStatus", chamado.status.id));
            parametros.Add(new SqlParameter("valorLoginResponsavel", chamado.usuario_responsavel.login));

            SqlParameter data_fechamento = new SqlParameter();
            data_fechamento.ParameterName = "valorDataFechamento";
            data_fechamento.IsNullable = true;
            if (chamado.data_fechamento == "")
                data_fechamento.Value = DBNull.Value;
            else
                data_fechamento.Value = DateTime.ParseExact(chamado.data_fechamento, "dd/MM/yyyy HH:mm:ss",
                                           System.Globalization.CultureInfo.InvariantCulture);
            parametros.Add(data_fechamento);

            parametros.Add(new SqlParameter("valorId", chamado.id));

            con.executar(sql, parametros);
        }

        public void salvar(Chamado chamado)
        {
            String sql = "INSERT INTO chamado VALUES (@descricao, @valorSenha, @valorTipo, @valorNome)";
        }
    }
}
