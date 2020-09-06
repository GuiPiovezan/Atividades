using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConexao
{
    public partial class frm_professor : Form
    {
        public frm_professor()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor objProfessor = new Professor();

                //Validação do nome
                if (txt_nome.Text == null || txt_nome.Text=="" || txt_nome.Text=="  " )
                {
                    MessageBox.Show("Digite um nome válido!");
                    Focus();
                }
                else
                {
                    objProfessor.Nome = txt_nome.Text;
                }

                //Validação do Telefone
                if (txt_tel.Text == null || txt_tel.Text=="")
                {
                    MessageBox.Show("Digite um telefone válido");
                    Focus();
                }
                else
                {
                    objProfessor.Telefone = txt_tel.Text;
                }

                //Validação do email
                if (txt_email.Text == null || txt_email.Text=="")
                {
                    MessageBox.Show("Digite um e-mail válido");
                    Focus();
                }
                else
                {
                    objProfessor.Email = txt_email.Text;
                }

                //Validação Area de Atuação
                if (txt_area.Text == null || txt_area.Text=="")
                {
                    MessageBox.Show("Digite um valor válido");
                    Focus();
                }
                else
                {
                    objProfessor.AreaAtuacao = txt_area.Text;
                }
                    
                //Validação do CPF
                if(txt_cpf.Text==null || txt_cpf.Text=="")
                {
                    MessageBox.Show("Digite um CPF válido");
                    Focus();
                }
                else
                {
                    objProfessor.Cpf = txt_cpf.Text;
                }
                
                //Validação do RG
                if(txt_rg.Text==null || txt_rg.Text=="")
                {
                    MessageBox.Show("Digite um RG válido");
                    Focus();
                }
                else
                {
                    objProfessor.Rg = txt_rg.Text;
                }
                
                
                
              

                CtrlProfessor objContProfessor = new CtrlProfessor();
                if (objContProfessor.Inserir(objProfessor))
                {
                    MessageBox.Show("Cadastro realizado com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar!!");
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar!!");
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_professor.ColumnCount = 7;
                dgv_professor.Rows.Clear();

                //Bloquear edição pela tabela
                dgv_professor.ReadOnly = true;

                dgv_professor.Columns[0].Name = "ID do Professor";
                dgv_professor.Columns[1].Name = "Nome";
                dgv_professor.Columns[2].Name = "Telefone";
                dgv_professor.Columns[3].Name = "Email";
                dgv_professor.Columns[4].Name = "Área de Atuação";
                dgv_professor.Columns[5].Name = "RG";
                dgv_professor.Columns[6].Name = "CPF";

                CtrlProfessor objCtrlProfessor = new CtrlProfessor();

                foreach (Professor objProfessor in objCtrlProfessor.Listar())
                {
                    dgv_professor.Rows.Add(
                        objProfessor.IdProf.ToString(),
                        objProfessor.Nome,
                        objProfessor.Telefone,
                        objProfessor.Email,
                        objProfessor.AreaAtuacao,
                        objProfessor.Rg,
                        objProfessor.Cpf
                        );
                }
            }
            catch
            {
                MessageBox.Show("Não contém dados");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                Professor objProfessor = new Professor();
                objProfessor.IdProf = Convert.ToInt16(txt_id.Text);
                objProfessor.Nome = txt_nome.Text;
                objProfessor.Telefone = txt_tel.Text;
                objProfessor.Email = txt_email.Text;
                objProfessor.AreaAtuacao = txt_area.Text;
                objProfessor.Cpf = txt_cpf.Text;
                objProfessor.Rg = txt_rg.Text;

                CtrlProfessor objCtrlProfessor = new CtrlProfessor();
                if (objCtrlProfessor.Alterar(objProfessor))
                {
                    MessageBox.Show("Sucesso!!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro no envio dos dados ao DATABASE");
                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado ao tentar editar!");
            }
        }

        private void listarProfessor(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_professor.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dgv_professor.CurrentRow.Cells[1].Value.ToString();
            txt_tel.Text = dgv_professor.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_professor.CurrentRow.Cells[3].Value.ToString();
            txt_area.Text = dgv_professor.CurrentRow.Cells[4].Value.ToString();
            txt_cpf.Text = dgv_professor.CurrentRow.Cells[5].Value.ToString();
            txt_rg.Text = dgv_professor.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Professor objProfessor = new Professor();
                objProfessor.IdProf = Convert.ToInt32(txt_id);
                CtrlProfessor objCtrlProfessor = new CtrlProfessor();
                if (objCtrlProfessor.Excluir(objProfessor.IdProf))
                {
                    MessageBox.Show("Dados excluídos com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao excluir os dados!");
                }
            }
            catch
            {
                MessageBox.Show("Problemas com a conexão, iremos resolver logo!!");
            }
           
        }
    }
}
