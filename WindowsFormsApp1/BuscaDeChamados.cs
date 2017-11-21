using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BuscaDeChamados
    {
        Conexao con = new Conexao();

        public List<Chamado> buscar() {
            String sql = "SELECT c.id_chamado, c.descricao, " +
                " cli.id_cliente, cli.nome, " +
                " s.id_status_chamado, s.descricao, " +
                " p.id_prioridade_chamado, p.descricao, " +
                " uc.login, uc.nome, c.data_criacao, " +
                " ur.login, ur.nome, c.data_fechamento " +
                " FROM chamado c " +
                " JOIN cliente cli ON c.id_cliente=cli.id_cliente"+
                " JOIN status_chamado s ON c.id_status_chamado=s.id_status_chamado" +
                " JOIN prioridade_chamado p ON c.id_prioridade_chamado=p.id_prioridade_chamado" +
                " JOIN usuario uc ON c.login_criacao=uc.login" +
                " JOIN usuario ur ON c.login_responsavel=ur.login";

            List<Chamado> chamados = new List<Chamado>();
            foreach (String[] resultado in con.busca(sql)) {
                Chamado chamado = new Chamado();
                chamado.id = resultado[0];
                chamado.descricao = resultado[1];
                chamado.cliente = new Cliente(resultado[2], resultado[3]);
                chamado.status = new StatusChamado(resultado[4], resultado[5]);
                chamado.prioridade = new PrioridadeChamado(resultado[6], resultado[7]);
                chamado.usuario_criacao = new Usuario(resultado[8], resultado[9]);
                chamado.data_criacao = resultado[10];
                chamado.usuario_responsavel = new Usuario(resultado[11], resultado[12]);
                chamado.data_fechamento = resultado[13];
                chamados.Add(chamado);
            }
            return chamados;
        }

    }
}
