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
        
        int numero, var_num;
        int cont;
        public frm_numero()
        {
            InitializeComponent();
            btn_confirmar.Enabled = false;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
           try
            {
                numero = Convert.ToInt32(txt_num.Text);
                if(numero > 0 && numero< 99)
                {
                    if (cont < 10)
                    {
                        if (var_num > numero && var_num != numero)
                        {
                            lbl_sorteado.Text = "Maior";
                            txt_num.Text = "";
                            txt_num.Focus();

                        }
                        else if (var_num < numero && var_num != numero)
                        {
                            lbl_sorteado.Text = "Menor";
                            txt_num.Text = "";
                            txt_num.Focus();
                        }
                        else if (var_num == numero)
                        {
                            lbl_sorteado.Text = Convert.ToString(var_num);
                            btn_confirmar.Enabled = false;
                            DialogResult resultado = new DialogResult();
                            Form mensaje = new frm_parabens();
                            resultado = mensaje.ShowDialog();
                            lbl_sorteado.Text = "";
                            txt_num.Text = "";
                            lbl_conta.Text = "";
                            pct_seta.Visible = true;
                        }

                        cont++;
                        lbl_conta.Text = Convert.ToString(cont);
                    }

                    else
                    {
                        
                        btn_confirmar.Enabled = false;
                        DialogResult resultado2 = new DialogResult();
                        Form menssagem = new frm_burro();
                        resultado2 = menssagem.ShowDialog();
                        lbl_sorteado.Text = "";
                        txt_num.Text = "";
                        lbl_conta.Text = "";
                        pct_seta.Visible = true;
                    }

                }
                else
                {
                    MessageBox.Show("Escolha um número entre 0 e 99!");
                    //btn_confirmar.Enabled = false;
                    //pct_seta.Visible = true;
                    cont++;
                    txt_num.Text = "";
                    lbl_conta.Text = Convert.ToString(cont);
                    txt_num.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Permitida a inserção de números do tipo inteiro!");
                //pct_seta.Visible = true;
                cont++;
                txt_num.Text = "";
                lbl_conta.Text = Convert.ToString(cont);
                txt_num.Focus();
            }
            
        }

        private void btn_NovoJogo_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            var_num = randNum.Next(0, 99);

            btn_confirmar.Enabled = true;
            lbl_sorteado.Text = "";
            txt_num.Text = "";
            cont = 0;
            lbl_conta.Text = Convert.ToString(cont);
            pct_seta.Visible = false;
            txt_num.Focus();
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void pct_taca_Click(object sender, EventArgs e)
        {

        }

        private void pct_burro_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
