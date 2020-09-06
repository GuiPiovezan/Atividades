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
    public partial class frm_aluno : Form
    {
        public frm_aluno()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txt_nome.Text = ("");
            txt_rm.Text = "";
            txt_cidade.Text = "";
            txt_id.Text = "";

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno objAluno = new Aluno();
                objAluno.Rm = txt_rm.Text;
                objAluno.Nome = txt_nome.Text;
                objAluno.Cidade = txt_cidade.Text;

                CtrlAluno objContAluno = new CtrlAluno();
                if (objContAluno.Inserir(objAluno))
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
                MessageBox.Show("Algo deu errado, por favor comunique o desenvolvedor!!");
            }
            limparCampos();
            atualizarLista();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_listar.ColumnCount = 4;
                dgv_listar.Rows.Clear();

                //Bloquear edição pela tabela
                dgv_listar.ReadOnly = true;

                dgv_listar.Columns[0].Name = "ID do Aluno";
                dgv_listar.Columns[1].Name = "RM";
                dgv_listar.Columns[2].Name = "Nome";
                dgv_listar.Columns[3].Name = "Cidade";

                CtrlAluno objCtrlAluno = new CtrlAluno();

                foreach (Aluno objAluno in objCtrlAluno.Listar())
                {
                    dgv_listar.Rows.Add(
                        objAluno.IdAluno.ToString(),
                        objAluno.Rm,
                        objAluno.Nome,
                        objAluno.Cidade
                        );
                }
            }
            catch
            {
                MessageBox.Show("Não contém dados");
            }
            atualizarLista();
        }

        private void dgv_listar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_listar.CurrentRow.Cells[0].Value.ToString();
            txt_rm.Text = dgv_listar.CurrentRow.Cells[1].Value.ToString();
            txt_nome.Text = dgv_listar.CurrentRow.Cells[2].Value.ToString();
            txt_cidade.Text = dgv_listar.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno objAluno = new Aluno();
                objAluno.IdAluno = Convert.ToInt16(txt_id.Text);
                objAluno.Nome = txt_nome.Text;
                objAluno.Rm = txt_rm.Text;
                objAluno.Cidade = txt_cidade.Text;

                CtrlAluno objCtrlAluno = new CtrlAluno();
                if(objCtrlAluno.Alterar(objAluno))
                {
                    MessageBox.Show("Sucesso!!");
                }
                else
                {
                    MessageBox.Show("Algo deu errado ao tentar editar!");
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro no envio dos dados ao DATABASE"); 
            }
            atualizarLista();
            limparCampos();
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno objAluno = new Aluno();
                objAluno.IdAluno = Convert.ToInt16(txt_id.Text);

                CtrlAluno objCtrlAluno = new CtrlAluno();
                if (objCtrlAluno.Excluir(objAluno.IdAluno))
                {
                    MessageBox.Show("Excluído com sucesso");
                }
                else
                    MessageBox.Show("Algo deu errado ao excluir o registro!");
            }
            catch
            {
                MessageBox.Show("Estamos com problemas técnicos, iremos resolver em breve!");
            }
            limparCampos();
            atualizarLista();
        }

        public void atualizarLista()
        {

            try
            {
                dgv_listar.ColumnCount = 4;
                dgv_listar.Rows.Clear();

                //Bloquear edição pela tabela
                dgv_listar.ReadOnly = true;

                dgv_listar.Columns[0].Name = "ID do Aluno";
                dgv_listar.Columns[1].Name = "RM";
                dgv_listar.Columns[2].Name = "Nome";
                dgv_listar.Columns[3].Name = "Cidade";

                CtrlAluno objCtrlAluno = new CtrlAluno();

                foreach (Aluno objAluno in objCtrlAluno.Listar())
                {
                    dgv_listar.Rows.Add(
                        objAluno.IdAluno.ToString(),
                        objAluno.Rm,
                        objAluno.Nome,
                        objAluno.Cidade
                        );
                }
            }
            catch
            {
                MessageBox.Show("Não contém dados");
            }
        }
    }
}
