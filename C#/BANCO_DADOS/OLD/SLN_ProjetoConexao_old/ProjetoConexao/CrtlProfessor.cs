using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjetoConexao
{
    class CtrlProfessor
    {
        SqlConnection conn = new SqlConnection();
        public Boolean Inserir(Professor objProfessor)
        {
            try
            {
                conn = Conexao.Conectar();
                string incluiSQL = @"insert into tbProfessor (nome, telefone, email, area, cpf, rg) values (@nome, @telefone, @email, @area, @cpf, @rg);";
                SqlCommand cmd = new SqlCommand(incluiSQL, conn);

                cmd.Parameters.Add(new SqlParameter("@nome", objProfessor.Nome));
                cmd.Parameters.Add(new SqlParameter("@telefone", objProfessor.Telefone));
                cmd.Parameters.Add(new SqlParameter("@email", objProfessor.Email));
                cmd.Parameters.Add(new SqlParameter("@area", objProfessor.AreaAtuacao));
                cmd.Parameters.Add(new SqlParameter("@cpf", objProfessor.Cpf));
                cmd.Parameters.Add(new SqlParameter("@rg", objProfessor.Rg));
                //Manda o comando para o Banco de dados sem retornar nenhuma informação
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                return false;
            }
        }

        public List<Professor> Listar()
        {
            
                List<Professor> ListaProfessor = new List<Professor>();
                try
                {
                    //Conexão com o Banco de Dados
                    conn = Conexao.Conectar();
                    //Comando que será enviado ao banco para realizar consultas de dados
                    string pesqSQl = "Select * from tbProfessor";
                    //Através da conexão conn o cmd envia a consulta SQL
                    SqlCommand cmd = new SqlCommand(pesqSQl, conn);
                    //Realizando a leitura dos Dados do Banco de Dados
                    SqlDataReader dr = cmd.ExecuteReader();
                    //Enquanto houver dados ele armazenará na Lista Alunos
                    while (dr.Read())
                    {

                        Professor objProfessor = new Professor();
                        objProfessor.IdProf = Convert.ToInt16(dr["idProf"]);
                        objProfessor.Nome = dr["nome"].ToString();
                        objProfessor.Telefone = dr["telefone"].ToString();
                        objProfessor.Email = dr["email"].ToString();
                        objProfessor.AreaAtuacao = dr["area"].ToString();
                        objProfessor.Rg = dr["rg"].ToString();
                        objProfessor.Cpf = dr["cpf"].ToString();

                        ListaProfessor.Add(objProfessor);
                    }
                    dr.Close();
                    conn.Close();
                    return ListaProfessor;
                }
                catch
                {
                    return null;
                }  
        }

        public Boolean Alterar(Professor objProfessor)
        {
            try
            {
                conn = Conexao.Conectar();
                string altSQL = @"UPDATE tbProfessor SET nome = @nome, telefone = @telefone, email = @email, area = @area, cpf = @cpf, rg = @rg WHERE idProf = @id;";
                SqlCommand cmd = new SqlCommand(altSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@nome", objProfessor.Nome));
                cmd.Parameters.Add(new SqlParameter("@telefone", objProfessor.Telefone));
                cmd.Parameters.Add(new SqlParameter("@email", objProfessor.Email));
                cmd.Parameters.Add(new SqlParameter("@area", objProfessor.AreaAtuacao));
                cmd.Parameters.Add(new SqlParameter("@cpf", objProfessor.Cpf));
                cmd.Parameters.Add(new SqlParameter("@rg", objProfessor.Rg));
                cmd.Parameters.Add(new SqlParameter("@id", objProfessor.IdProf));
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public Boolean Excluir (int idProf)
        {
            try
            {
                conn = Conexao.Conectar();
                string excSQL = @"DELETE FROM tbProfessor WHERE idProf = @id;";
                SqlCommand cmd = new SqlCommand(excSQL, conn);
                cmd.Parameters.Add(new SqlParameter("@id", idProf));
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
