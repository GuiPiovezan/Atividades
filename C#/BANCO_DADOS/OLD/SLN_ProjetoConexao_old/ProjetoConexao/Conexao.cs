using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConexao
{
    class Conexao
    {
        public string TesteConectar()
        {
            SqlConnection conn = new SqlConnection();

            //monstagem da string conexão
            string connString = @"Data Source=(local);Initial Catalog=BDTESTE;Integrated Security=True";

            try
            {
                //atribui a string de conexão e abre a conexão
                conn.ConnectionString = connString;
                conn.Open();
                return "Conexão Realizada com sucesso!!";
            }
            catch (Exception Ex)
            {
                return "Erro de Conexão :" + Ex;
            }
        }

        public static SqlConnection Conectar ()
        {
            SqlConnection conn = new SqlConnection();
            string connString = @"Data Source=(local);Initial Catalog=BDTESTE;Integrated Security=True";
            conn.ConnectionString = connString;
            conn.Open();
            return conn;    
        }
    }
}
