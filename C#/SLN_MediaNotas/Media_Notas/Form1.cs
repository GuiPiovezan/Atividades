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
        Double np1, np2, np3, np4, nt1, nt2, nt3, nt4, tnp, tnt, mpp, mpt, total;

        private void lbl_medias_Click(object sender, EventArgs e)
        {

        }

        private void frm_media_nota_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_np1.Clear();
            txt_np2.Clear();
            txt_np3.Clear();
            txt_np4.Clear();
            txt_nt1.Clear();
            txt_nt2.Clear();
            txt_nt3.Clear();
            txt_nt4.Clear();
            lbl_mp.Text = "";
            lbl_mt.Text = "";
            lbl_total.Text = "";
            lbl_situacao.Text = "";
        }

        public frm_media_nota()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                np1 = Convert.ToDouble(txt_np1.Text);
                np2 = Convert.ToDouble(txt_np2.Text);
                np3 = Convert.ToDouble(txt_np3.Text);
                np4 = Convert.ToDouble(txt_np4.Text);
                tnp = (np1 + np2 + np3 + np4) / 4;
                mpp = (tnp * 0.7);

            }
            catch
            {
                txt_np1.Text = "Erro";
                txt_np2.Text = "Erro";
                txt_np3.Text = "Erro";
                txt_np4.Text = "Erro";
                lbl_mp.Text = "";
            }
            try
            {
                nt1 = Convert.ToDouble(txt_nt1.Text);
                nt2 = Convert.ToDouble(txt_nt2.Text);
                nt3 = Convert.ToDouble(txt_nt3.Text);
                nt4 = Convert.ToDouble(txt_nt4.Text);
                tnt = (nt1 + nt2 + nt3 + nt4) / 4;
                mpt = (tnt * 0.3);
            }
            catch
            {
                txt_nt1.Text = "Erro";
                txt_nt2.Text = "Erro";
                txt_nt3.Text = "Erro";
                txt_nt4.Text = "Erro";
                lbl_mt.Text = "";
            }

            if (txt_np4.Text == "Erro")
            {
                lbl_mp.Text = "";
            }
            else
            {
                lbl_mp.Text = Convert.ToString(mpp); 
            }


            if (txt_nt4.Text == "Erro")
            {
                lbl_mt.Text = "";
            }
            else
            {
                lbl_mt.Text = Convert.ToString(mpt); 
            }

            total = (mpp + mpt);
            if (txt_np4.Text == "Erro" || txt_nt4.Text=="Erro")
            {
                lbl_total.Text = "";
            }
            else
            {
                lbl_total.Text = Convert.ToString(total); 
            }
                                   
                if (total >= 7)
                {
                    lbl_situacao.Text = "Aprovado";
                }
                else if (total >= 5 && total < 7)
                {
                    lbl_situacao.Text = "Recuperação";
                }
                else
                {
                    lbl_situacao.Text = "Reprovado";
                }
            if (txt_np4.Text == "Erro" || txt_nt4.Text == "Erro")
            {
                lbl_situacao.Text = "";
            }
        }
            
            
                
            


        }

    }
