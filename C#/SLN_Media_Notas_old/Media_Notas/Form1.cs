using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Notas
{
    public partial class frm_media_nota : Form
    {
        double np1, np2, np3, np4, nt1, nt2, nt3, nt4, mp, mt, total;

        private void frm_media_nota_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                np1 = Convert.ToDouble(txt_np1.Text);
                np2 = Convert.ToDouble(txt_np2.Text);
                np3 = Convert.ToDouble(txt_np3.Text);
                np4 = Convert.ToDouble(txt_np4.Text);
                mp = (np1 + np2 + np3 + np4) / 4;
                mp = mp * 0.7;

                lbl_mp.Text = Convert.ToString(mp);
            }
            catch
            {
                txt_np1.Text = "ERRO";
                txt_np2.Text = "ERRO";
                txt_np3.Text = "ERRO";
                txt_np4.Text = "ERRO";
            }
            try
            {
                nt1 = Convert.ToDouble(txt_nt1.Text);
                nt2 = Convert.ToDouble(txt_nt2.Text);
                nt3 = Convert.ToDouble(txt_nt3.Text);
                nt4 = Convert.ToDouble(txt_nt4.Text);
                mt = (nt1 + nt2 + nt3 + nt4) / 4;
                mt = mt * 0.3;

                lbl_mt.Text = Convert.ToString(mt);
            }
            catch
            {
                txt_nt1.Text = "ERRO";
                txt_nt2.Text = "ERRO";
                txt_nt3.Text = "ERRO";
                txt_nt4.Text = "ERRO";
            }
            total = mp + mt;

            lbl_total.Text = Convert.ToString(total);

            if (total>=0 && total<5)
            {
                lbl_situacao.Text = "Reprovado";
            }
            else if (total>=5 && total<7)
            {
                lbl_situacao.Text = "Recuperação";
            }
            else if (total>=7 && total<=10)
            {
                lbl_situacao.Text = "Aprovado";
            }
            else
            {
                lbl_situacao.Text = "ERRO";
            }
        }

        public frm_media_nota()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Convert.ToString(txt_np1);
            txt_np1.Text = "";
            Convert.ToString(txt_np2);
            txt_np2.Text = "";
            Convert.ToString(txt_np3);
            txt_np3.Text = "";
            Convert.ToString(txt_np4);
            txt_np4.Text = "";
            Convert.ToString(txt_nt1);
            txt_nt1.Text = "";
            Convert.ToString(txt_nt2);
            txt_nt2.Text = "";
            Convert.ToString(txt_nt3);
            txt_nt3.Text = "";
            Convert.ToString(txt_nt4);
            txt_nt4.Text = "";
            Convert.ToString(lbl_mp);
            lbl_mp.Text = "";
            Convert.ToString(lbl_mt);
            lbl_mt.Text = "";
            Convert.ToString(lbl_situacao);
            lbl_situacao.Text = "";
            Convert.ToString(lbl_total);
            lbl_total.Text = "";

        }
    }
}
