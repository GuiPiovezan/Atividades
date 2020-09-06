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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexao objCon = new Conexao();
            lblResultado.Text = objCon.TesteConectar();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno objAluno = new Aluno();
                objAluno.Nome = txtNome.Text;
                objAluno.RM = txtRm.Text;
                objAluno.Cidade = txtCidade.Text;

                CtrlAluno objContAluno = new CtrlAluno();

                if (objContAluno.Inserir(objAluno)){
                    MessageBox.Show("Cadastro realizado com sucesso!!");
                } else {
                    MessageBox.Show("Ocorreu um erro ao tentar cadastrar!!");
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar!!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.Rows.Clear();

                // Bloquear o dataGrid para edição
                dataGridView1.ReadOnly = true;
                

                dataGridView1.Columns[0].Name = "ID_Aluno";
                dataGridView1.Columns[1].Name = "RM";
                dataGridView1.Columns[2].Name = "Nome";
                dataGridView1.Columns[3].Name = "Cidade";

                CtrlAluno objCtrlAluno = new CtrlAluno();
                foreach(Aluno objAluno in objCtrlAluno.Listar())
                {
                    dataGridView1.Rows.Add(
                        objAluno.IdAluno.ToString(), 
                        objAluno.RM, 
                        objAluno.Nome, 
                        objAluno.Cidade);
                }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!!" + ex);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.
                Cells[0].Value.ToString();
            txtRm.Text = dataGridView1.CurrentRow.
                Cells[1].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.
                Cells[2].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.
                Cells[3].Value.ToString();

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno objAluno = new Aluno();
                objAluno.IdAluno = 
                    Convert.ToInt16(txtID.Text);
                objAluno.Nome = txtNome.Text;
                objAluno.RM = txtRm.Text;
                objAluno.Cidade = txtCidade.Text;

                CtrlAluno objCtrlAluno = new CtrlAluno();
                if (objCtrlAluno.Alterar(objAluno))
                {
                    MessageBox.Show("Registro atualizado com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao enviar os dados ao banco de dados!");
                }
             }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao editar os dados!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string rm = txtRm.Text;
                Aluno objAluno = new Aluno();
                CtrlAluno objCtrlAluno = new CtrlAluno();
                objAluno = objCtrlAluno.Selecionar(rm);

                txtID.Text = Convert.ToString(objAluno.IdAluno);
                txtNome.Text = objAluno.Nome;
                txtCidade.Text = objAluno.Cidade;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }
    }
}
