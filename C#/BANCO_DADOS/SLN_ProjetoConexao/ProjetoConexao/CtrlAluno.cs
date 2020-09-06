using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConexao
{
    class CtrlAluno
    {
        SqlConnection conn = new SqlConnection();
        public Boolean Inserir (Aluno objAluno)
        {
            try
            {
                conn = Conexao.Conectar();
                string incluiSQL = @"insert into tbAluno (rm, nome, cidade) values (@rm, @nome, @cidade);";
                SqlCommand cmd = new SqlCommand(incluiSQL, conn);

                cmd.Parameters.Add(new SqlParameter("@rm", objAluno.Rm));
                cmd.Parameters.Add(new SqlParameter("@nome", objAluno.Nome));
                cmd.Parameters.Add(new SqlParameter("@cidade", objAluno.Cidade));
                //Manda o comando para o Banco de dados sem retornar nenhuma informação
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Aluno> Listar()
        {
            List<Aluno> ListaAluno = new List<Aluno>();
            try
            { 
                //Conexão com o Banco de Dados
                conn =  Conexao.Conectar();
                //Comando que será enviado ao banco para realizar consultas de dados
                string pesqSQl = "Select * from tbAluno";
                //Através da conexão conn o cmd envia a consulta SQL
                SqlCommand cmd = new SqlCommand(pesqSQl, conn);
                //Realizando a leitura dos Dados do Banco de Dados
                SqlDataReader dr = cmd.ExecuteReader();
                //Enquanto houver dados ele armazenará na Lista Alunos
                while(dr.Read())
                {

                    Aluno objAluno = new Aluno();
                    objAluno.IdAluno = Convert.ToInt16(dr["idAluno"]);
                    objAluno.Rm = dr["rm"].ToString();
                    objAluno.Nome = dr["nome"].ToString();
                    objAluno.Cidade = dr["cidade"].ToString();

                    ListaAluno.Add(objAluno);
                }
                dr.Close();
                conn.Close();
                return ListaAluno;
            }
            catch
            {
                return null;
            }
        }

        public Boolean Alterar(Aluno objAluno)


        {
            try
            {
                conn = Conexao.Conectar();
                string altSQL = @"UPDATE tbAluno SET rm = @rm, nome = @nome, cidade = @cidade WHERE idAluno = @id;";
                SqlCommand cmd = new SqlCommand(altSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@rm", objAluno.Rm));
                cmd.Parameters.Add(new SqlParameter("@nome", objAluno.Nome));
                cmd.Parameters.Add(new SqlParameter("@cidade", objAluno.Cidade));
                cmd.Parameters.Add(new SqlParameter("@id", objAluno.IdAluno));
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public Boolean Excluir(int idAluno)
        {
            try
            {
                conn = Conexao.Conectar();
                string excSQL = @"DELETE FROM tbAluno WHERE idAluno = @id";
                SqlCommand cmd = new SqlCommand(excSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@id", idAluno));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
