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
    public partial class frm_conexao : Form
    {
        public frm_conexao()
        {
            InitializeComponent();
        }

        private void btn_conexao_Click(object sender, EventArgs e)
        {
            Conexao conecta = new Conexao();
            lbl_resultado.Text = Convert.ToString(conecta.TesteConectar());
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
                MessageBox.Show("Não foi possível cadastrar!!");
            }
            
        }
    }
}
