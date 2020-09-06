using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frm_calculdora : Form
    {
        Double n1, n2, resultado;
        public frm_calculdora()
        {
            InitializeComponent();
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Text = "";
            txt_n2.Clear();
            lbl_resultado.Text = "";
        }

        private void frm_calculdora_Load(object sender, EventArgs e)
        {

        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                n2 = Convert.ToDouble(txt_n2.Text);
                resultado = n1 * n2;
                lbl_resultado.Text = Convert.ToString(resultado);
            }
            catch
            {
                txt_n1.Text = "erro";
                txt_n2.Text = "erro";
            }
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                n2 = Convert.ToDouble(txt_n2.Text);
                resultado = n1 - n2;
                lbl_resultado.Text = Convert.ToString(resultado);
            }
            catch
            {
                txt_n1.Text = "erro";
                txt_n2.Text = "erro";
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                n2 = Convert.ToDouble(txt_n2.Text);
                if (n2 !=0)
                {
                    resultado = n1 / n2;
                    lbl_resultado.Text = Convert.ToString(resultado);
                }
                else
                {
                    txt_n2.Text = "Não zero";
                }
            }
            catch
            {
                txt_n1.Text = "erro";
                txt_n2.Text = "erro";
            }
            
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                //n2 = Convert.ToDouble(txt_n2.Text);

                if (n1 > 0 || n2 ==0)
                {
                    resultado = Math.Sqrt(n1);
                    lbl_resultado.Text = Convert.ToString(resultado);
                    txt_n2.Text = "0";
                }
                else 
                {
                    txt_n1.Text = "Erro";
                    txt_n2.Text = "Ñ utilizar";
                }
                
                
            }

                
            catch
            {
                txt_n1.Text = "erro";
                txt_n2.Text = "erro";
                 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(txt_n1.Text);
                n2 = Convert.ToDouble(txt_n2.Text);
                resultado = n1 + n2;
                lbl_resultado.Text = Convert.ToString(resultado);
            }
            catch
            {
                txt_n1.Text = "erro";
                txt_n2.Text = "erro";

            }
            
            //lbl_resultado.Text = txt_n1.Text + txt_n2.Text; 
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
