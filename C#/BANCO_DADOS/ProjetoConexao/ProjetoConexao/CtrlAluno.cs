using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConexao
{
    class CtrlAluno
    {
        SqlConnection conn = new SqlConnection();

        public Boolean Inserir(Aluno objAluno)
        {
            try
            {
                conn = Conexao.Conectar();
                string incluiSQL = @" insert into 
                        tbAluno(rm,nome, cidade) 
                       values(@rm,@nome, @cidade);";

                SqlCommand cmd = new SqlCommand(incluiSQL, conn);
                
                cmd.Parameters.Add(new SqlParameter("@rm", objAluno.RM));
                cmd.Parameters.Add(new SqlParameter("@nome", objAluno.Nome));
                cmd.Parameters.Add(new SqlParameter("@cidade", objAluno.Cidade));

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
                //faz a conexão com o BD
                conn = Conexao.Conectar();

                //string com o comando que será enviado ao BD
                string pesqSQL = "Select * from tbAluno";

                //Através da conexão CONN o CMD envia a consulta SQL
                SqlCommand cmd = new SqlCommand(pesqSQL, conn);

                //dr está recebendo os dados selecionado no BD
                SqlDataReader dr = cmd.ExecuteReader();

                //enquanto houver registros, serão armazemandos 
                //no objAluno
                //para em seguida serem adicionadods na lista
                while (dr.Read())
                {
                    Aluno objAluno = new Aluno();
                    objAluno.IdAluno = Convert.ToInt16(dr["idAluno"]);
                    objAluno.RM = dr["rm"].ToString();
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
                string altSQL = @"update tbAluno set rm = @rm,
                    nome = @nome, cidade = @cidade where idAluno=@id";
                SqlCommand cmd = new SqlCommand(altSQL, conn);
                cmd.Parameters.Add(new 
                    SqlParameter("@rm", objAluno.RM));
                cmd.Parameters.Add(new 
                    SqlParameter("@nome", objAluno.Nome));
                cmd.Parameters.Add(new
                    SqlParameter("@cidade", objAluno.Cidade));
                cmd.Parameters.Add(new
                    SqlParameter("@id", objAluno.IdAluno));

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
                string excSQL = @"delete from tbAluno
                    where idAluno = @id";
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

        public Aluno Selecionar(string rm)
        {
            Aluno objAluno = new Aluno();
            try
            {
                //faz a conexão com o BD
                conn = Conexao.Conectar();

                //string com o comando que será enviado ao BD
                string pesqSQL = "Select * from tbAluno";

                //Através da conexão CONN o CMD envia a consulta SQL
                SqlCommand cmd = new SqlCommand(pesqSQL, conn);

                //dr está recebendo os dados selecionado no BD
                SqlDataReader dr = cmd.ExecuteReader();

                //enquanto houver registros, serão armazemandos 
                //no objAluno
                //para em seguida serem adicionadods na lista
                while (dr.Read())
                {
                   
                    objAluno.IdAluno = Convert.ToInt16(dr["idAluno"]);
                    objAluno.RM = dr["rm"].ToString();
                    objAluno.Nome = dr["nome"].ToString();
                    objAluno.Cidade = dr["cidade"].ToString();

                    
                }
                dr.Close();
                conn.Close();
                return objAluno;
            }
            catch
            {
                return null;
            }

        }

    }
}
