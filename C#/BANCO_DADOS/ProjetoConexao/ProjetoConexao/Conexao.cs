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
            //montagem da string de conexão
            string connString = @"Data Source=DESKTOP-P8OF089\TEW_SQLEXPRESS;Initial Catalog=bdTeste;Integrated Security=True";
            try{
                //atribui a string de conexão e abre a conexão
                conn.ConnectionString = connString;
                conn.Open();
                return "Conexão Realizada com Sucesso!!";
            }catch (Exception Ex){                
                return "Erro ao conectar: " + Ex;
            }
        }

        public static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection();
            string connString = @"Data Source=DESKTOP-P8OF089\TEW_SQLEXPRESS;Initial Catalog=bdTeste;Integrated Security=True";
            conn.ConnectionString = connString;
            conn.Open();
            return conn;
        }
    }
}
