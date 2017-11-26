using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Servicos
{
    class BuscaDeClientes
    {
        Conexao con = new Conexao();

        public List<Cliente> buscar()
        {
            String query = "SELECT * FROM cliente WHERE status = 1";

            List<String[]> resultados = con.busca(query);

            List<Cliente> clientes = new List<Cliente>();

            foreach (String[] resultado in resultados)
            {
                Cliente cliente = new Cliente();
                cliente.id = resultado[0];
                cliente.nome = resultado[1];
                clientes.Add(cliente);
            }
            return clientes;
        }
    }
}