using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPinturaOO
{
    public partial class frm_projeto_pintura : Form
    {
        public frm_projeto_pintura()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Visible = true;
            ClassCalculo calq = new ClassCalculo();
            try
            {
                calq.Area = Convert.ToDouble(txt_area.Text);
                calq.ValorLata = Convert.ToDouble(txt_vLatas.Text);
                calq.ValorMaodObra = Convert.ToDouble(txt_vMaodobra.Text);
            }
            catch
            {
                txt_area.Text = "Erro";
                txt_vLatas.Text = "Erro";
                txt_vMaodobra.Text = "Erro";
                lbl_resultado.Visible = false;
                lbl_resultado.Text = "";
            }
            lbl_resultado.Text = "Área a ser pintada: " + calq.Area + "m² " + "\nDias necessários: " + calq.DiasNecessarios() +
            "\nQuantidade de latas: " + calq.CalculoLata() + "\nValor total Latas: R$" + calq.CalculoTintas() + "\nPreço da diária: R$" +
            calq.ValorMaodObra + "\nValor da mão-de-obra: R$" + calq.CalculoMaodObra() + "\nValor total da pintura: R$" + calq.CalculoValorTotal();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            lbl_resultado.Visible = false;
            txt_area.Text = "";
            txt_vLatas.Text = "";
            txt_vMaodobra.Text = "";
            txt_area.Focus();
        }
    }
}
