using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescobreNumero
{
    public partial class frm_numero : Form
    {
        
        int numero;
        int cont;
        private object listaResultado;

        public frm_numero()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
           try
            {
                numero = Convert.ToInt16(txt_num.Text);
            }
            catch
            {
                MessageBox.Show("Permitida a inserção de números do tipo inteiro!");
            }
            Random randNum = new Random();
             for (int cont=0; cont<10; cont--)
            {
                listaResultado.items.Add(randNum.Next(0, 99));
            }
            lbl_conta.Text = Convert.ToString(cont--);
        }

        private void btn_NovoJogo_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
