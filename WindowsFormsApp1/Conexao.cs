using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Conexao
    {
        private const String StringConexao = "Data Source=PRISCILLA-PC\\SQLEXPRESS;Initial Catalog=geniusxtec;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection conexao = new SqlConnection(StringConexao);

        public List<String[]> busca(String sql)
        {
            return busca(sql, new List<SqlParameter>());
        }

        public List<String[]> busca(String sql, List<SqlParameter> parametros) {
            abreConexao();

            SqlCommand command = new SqlCommand(sql, conexao);
            
            foreach (SqlParameter parametro in parametros) {
                command.Parameters.Add(parametro);
            }

            imprimir(sql, parametros);

            List<String[]> resultados = converteParaLista(command.ExecuteReader());

            fechaConexao();

            return resultados;
        }

        public void executar(String sql)
        {
            executar(sql, new List<SqlParameter>());
        }

        public void executar(String sql, List<SqlParameter> parametros) {
            abreConexao();

            SqlCommand command = new SqlCommand(sql, conexao);
            
            foreach (SqlParameter parametro in parametros)
            {
                command.Parameters.Add(parametro);
            }

            imprimir(sql, parametros);

            command.ExecuteNonQuery();

            fechaConexao();
        }

        private void abreConexao()
        {
            conexao.Open();
        }

        private void imprimir(String sql, List<SqlParameter> parametros) {
            Console.WriteLine();
            Console.WriteLine("# Query: " + sql);

            Console.Write("# Parâmetros: ");
            foreach (SqlParameter parametro in parametros)
            {
                Console.Write(parametro.ParameterName + "=" + parametro.Value + "; ");
            }
            Console.WriteLine("\n");
        }

        private List<String[]> converteParaLista(SqlDataReader reader)
        {
            List<String[]> resultados = new List<String[]>();

            while (reader.Read())
            {
                String[] resultado = new String[reader.FieldCount];
                for (int x = 0; x < resultado.Length; x++)
                {
                    Object valor = reader[x];
                    resultado[x] = valor == null ? "" : valor.ToString();
                }
                resultados.Add(resultado);
            }

            return resultados;
        }

        private void fechaConexao()
        {
            conexao.Close();
        }
    }
}
