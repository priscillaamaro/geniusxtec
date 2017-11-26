using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BuscaDeUsuarios
    {
        Conexao con = new Conexao();

        public Usuario buscar(String usuario, String senha)
        {
            String query = "SELECT u.login, u.senha, u.id_tipo_usuario, u.nome, t.descricao " +
                " FROM usuario u JOIN tipo_usuario t ON u.id_tipo_usuario=t.id_tipo_usuario " +
                " WHERE u.status = 1 and login = @valorLogin AND senha = @valorSenha";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("valorLogin", usuario));
            parametros.Add(new SqlParameter("valorSenha", senha));

            List<String[]> resultados = con.busca(query, parametros);
            
            if (resultados.Any())
            {
                Usuario user = new Usuario();
                user.login = resultados[0][0];
                user.senha = resultados[0][1];
                user.tipoUsuario = new TipoUsuario(resultados[0][2], resultados[0][4]);
                user.nome = resultados[0][3];
                return user;
            }else
                return null;
            }

        public List<Usuario> buscar()
        {
            string query = "SELECT * FROM usuario";
            List<Usuario> usuarios = new List<Usuario>();
            foreach (String[] resultado in con.busca(query))
            {
                Usuario user = new Usuario();
                user.login = resultado[0];
                user.senha = resultado[1];
                user.tipoUsuario = new TipoUsuario(resultado[2]);
                user.nome = resultado[3];
                usuarios.Add(user);
            }
            return usuarios;
        }

        public List<Usuario> buscarComTipo()
        {
            string query = "SELECT u.login, u.senha, u.id_tipo_usuario, u.nome, t.descricao FROM usuario u JOIN tipo_usuario t ON u.id_tipo_usuario=t.id_tipo_usuario WHERE u.status = 1";
            List<Usuario> usuarios = new List<Usuario>();
            foreach (String[] resultado in con.busca(query))
            {
                Usuario user = new Usuario();
                user.login = resultado[0];
                user.senha = resultado[1];
                user.tipoUsuario = new TipoUsuario(resultado[2], resultado[4]);
                user.nome = resultado[3];
                usuarios.Add(user);
            }
            return usuarios;
        }

        public List<TipoUsuario> buscarTipos() {
            String query = "SELECT * FROM tipo_usuario";

            List<TipoUsuario> tiposUsuario = new List<TipoUsuario>();
            foreach (String[] resultado in con.busca(query)) {
                TipoUsuario tipo = new TipoUsuario();
                tipo.id = resultado[0];
                tipo.descricao = resultado[1];
                tiposUsuario.Add(tipo);
            }
            return tiposUsuario;
        }
    }
}
