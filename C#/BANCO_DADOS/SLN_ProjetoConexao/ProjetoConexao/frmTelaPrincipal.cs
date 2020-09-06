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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            Conexao conecta = new Conexao();
            MessageBox.Show(conecta.TesteConectar());
        }

        private void pct_aluno_Click(object sender, EventArgs e)
        {
            frm_aluno aluno = new frm_aluno();
            aluno.Show();
        }

        private void pct_professor_Click(object sender, EventArgs e)
        {
            frm_professor professor = new frm_professor();
            professor.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
