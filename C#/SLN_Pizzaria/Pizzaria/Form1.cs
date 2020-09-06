using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frm_pizzaria : Form
    {
        String tamanho = " ";
        String sabor = " ";
        String complemento = " ";
        int valor;
        public void preparaTela()
        {
            // Radio button tamanho
            rdb_brotinho.Checked = false;
            rdb_grande.Checked = false;
            rdb_media.Checked = false;
            rdb_pequena.Checked = false;

            //Radio button sabor
            rdb_calabresa.Checked = false;
            rdb_frango.Checked = false;
            rdb_mucarela.Checked = false;
            rdb_portuguesa.Checked = false;
            

        }
        public frm_pizzaria()
        {
            InitializeComponent();
        }

        private void rdb_pequena_CheckedChanged(object sender, EventArgs e)
        {
            tamanho = "pequena";
            //valor = valor + 5;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdb_portuguesa_CheckedChanged(object sender, EventArgs e)
        {
            sabor = " portuguesa.";
            //valor = valor + 7;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (rdb_grande.Checked == true) { valor = valor + 10; }
            if (rdb_media.Checked == true) { valor = valor + 7; }
            if (rdb_pequena.Checked == true) { valor = valor + 5; }
            if (rdb_brotinho.Checked == true) { valor = valor + 3; }
            if (rdb_mucarela.Checked == true) { valor = valor + 3; }
            if (rdb_calabresa.Checked == true) { valor = valor + 4; }
            if (rdb_frango.Checked == true) { valor = valor + 5; }
            if (rdb_portuguesa.Checked == true) { valor = valor + 7; }
            grp_tamanho.Enabled = false;
            gro_sabor.Enabled = false;
            grp_complementos.Enabled = false;
            if (rdb_brotinho.Checked == true || rdb_grande.Checked == true || rdb_media.Checked == true || rdb_pequena.Checked == true || rdb_mucarela.Checked == true || rdb_calabresa.Checked == true || rdb_frango.Checked == true || rdb_portuguesa.Checked == true)
            {
                lbl_pedido.Text = "Você escolheu uma pizza no tamanho " + tamanho + " e no sabor " + sabor;
                lbl_pedido.Visible = true;
            } 

           /*else if (rdb_brotinho.Checked == false || rdb_grande.Checked == false || rdb_media.Checked == false || rdb_pequena.Checked == false )
            {
                lbl_pedido.Visible = false;
                MessageBox.Show("Escolha um tamanho!");
            }*/

            if(chk_banana.Checked == true)
            {
                complemento = complemento + " banana ";
                valor = valor + 2;
            }
             if(chk_cheddar.Checked == true)
            {
                complemento = complemento + " cheddar ";
                valor = valor + 2;
            }
             if (chk_cremeazeitona.Checked == true)
            {
                complemento = complemento + " creme de azeitona";
                valor = valor + 2;
            }
             if(chk_crememilho.Checked == true)
            {
                complemento = complemento + " creme de milho ";
                valor = valor + 2;
            }
             if(chk_goiabada.Checked == true)
            {
                complemento = complemento + " goiabada ";
                valor = valor + 2;
            }
             if (chk_picles.Checked == true)
            {
                complemento = complemento + " picles ";
                valor = valor + 2;
            }
            
            
            
            
            if(sabor != "")
            { if (tamanho != " " && sabor == " " && complemento != " " || tamanho != " " && sabor == " " && complemento == " ") { lbl_pedido.Text = " "; MessageBox.Show("Escolha um sabor!"); grp_tamanho.Enabled = true; gro_sabor.Enabled = true; grp_complementos.Enabled = true; }

                if (tamanho!= "")
                {   if(tamanho == " " && sabor != " " && complemento != " " || tamanho == " " && sabor != " " && complemento == " ") { lbl_pedido.Text = " ";  MessageBox.Show("Escolha um tamanho!"); grp_tamanho.Enabled = true; gro_sabor.Enabled = true; grp_complementos.Enabled = true; }


                    if (sabor == " " && tamanho == " " && complemento != " " || sabor == " " && tamanho == " " && complemento == " ") { lbl_pedido.Text = " " ; MessageBox.Show("Escolha um tamanho e um sabor de pizza!"); grp_tamanho.Enabled = true; gro_sabor.Enabled = true; grp_complementos.Enabled = true;  }
                    else
                    {
                        if (complemento != " " && sabor != " " && tamanho != " ")
                        {
                            lbl_pedido.Text = "Você escolheu uma pizza no tamanho " + tamanho + " e no sabor " + sabor + "de complemento " + complemento + "no valor de R$"+valor+",00";
                        }
                        else if (complemento == " " && sabor != " " && tamanho != " ")
                        {
                            lbl_pedido.Text = "Você escolheu uma pizza no tamanho " + tamanho + " e no sabor " + sabor + " sem complemento, no valor de R$"+valor+",00";
                        }
                    }
                    
                        
                }
                
            }
            btn_confirmar.Enabled = false;
             
        }

        private void rdb_grande_CheckedChanged(object sender, EventArgs e)
        {
            tamanho = " grande ";
            //valor = valor + 10;
        }

        private void rdb_media_CheckedChanged(object sender, EventArgs e)
        {
            tamanho = " médio ";
            //valor = valor + 7;
        }

        private void rdb_brotinho_CheckedChanged(object sender, EventArgs e)
        {
            tamanho = " brotinho ";
            //valor = valor + 3;
        }

        private void rdb_mucarela_CheckedChanged(object sender, EventArgs e)
        {
            sabor = " muçarela ";
            //valor = valor + 3;
        }

        private void rdb_calabresa_CheckedChanged(object sender, EventArgs e)
        {
            sabor = " calabresa ";
            //valor = valor + 4;
        }

        private void rdb_frango_CheckedChanged(object sender, EventArgs e)
        {
            sabor = " frango ";
            //valor = valor + 5;
        }

        private void btn_npedido_Click(object sender, EventArgs e)
        {
            chk_banana.Checked = false;
            chk_cheddar.Checked = false;
            chk_cremeazeitona.Checked = false;
            chk_crememilho.Checked = false;
            chk_goiabada.Checked = false;
            chk_picles.Checked = false;
           

            lbl_pedido.Text = " ";
            rdb_brotinho.Checked = false;
            rdb_calabresa.Checked = false;
            rdb_frango.Checked = false;
            rdb_grande.Checked = false;
            rdb_media.Checked = false;
            rdb_mucarela.Checked = false;
            rdb_portuguesa.Checked = false;
            rdb_pequena.Checked = false;
            grp_tamanho.Enabled = true;
            gro_sabor.Enabled = true;
            grp_complementos.Enabled = true;
            tamanho = " ";
            sabor = " ";
            complemento = " ";
            valor = 0;
            btn_confirmar.Enabled = true;
            
        }

        private void grp_complementos_Enter(object sender, EventArgs e)
        {
            
        }

        private void chk_cremedeAzeitona(object sender, EventArgs e)
        {
            
        }

        private void chk_crememilho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_cremeazeitona_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_cheddar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_picles_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chk_banana_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chk_goiabada_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void grp_tamanho_Enter(object sender, EventArgs e)
        {

        }
    }
}
