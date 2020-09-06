using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class frm_forca : Form
    {
        String[] palavra;
        string p_digitada;
        int contador1 = 0;
        int vAcerto = 0;
        int contP = 0;

        public frm_forca()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen caneta_red = new Pen(Color.Red);
            Pen caneta_white = new Pen(Color.White);
            Pen caneta_black = new Pen(Color.Black);
            caneta_black.Width = 5;
            caneta_white.Width = 5;
            caneta_red.Width = 5;

            

            g.DrawLine(caneta_black, 25, 50, 100, 50); 
            g.DrawLine(caneta_black,25 ,50, 25,275);
            g.DrawLine(caneta_black, 100, 50, 100, 85);

            if (contador1 == 1)
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
            else if (contador1 == 2)
            {
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);
            }
            else if (contador1 == 3)
            {
                g.DrawLine(caneta_white, 100, 165, 75, 145);
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);

            }
            else if (contador1 == 4)
            {
                g.DrawLine(caneta_white, 100, 165, 75, 145);
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);
                g.DrawLine(caneta_white, 100, 165, 125, 145);
            }

            else if (contador1 == 5)
            {
                g.DrawLine(caneta_white, 100, 200, 85, 250);
                g.DrawLine(caneta_white, 100, 165, 75, 145);
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);
                g.DrawLine(caneta_white, 100, 165, 125, 145);
            }
            else if (contador1 == 6)
            {
                g.DrawLine(caneta_white, 100, 200, 85, 250);
                g.DrawLine(caneta_white, 100, 165, 75, 145);
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);
                g.DrawLine(caneta_white, 100, 165, 125, 145);
                g.DrawLine(caneta_white, 100, 195, 125, 250);
            }
            else if (contador1 == 7)
            {
                g.DrawLine(caneta_white, 100, 165, 75, 145);
                g.DrawEllipse(caneta_white, 75, 85, 50, 50);
                g.DrawLine(caneta_white, 100, 135, 100, 200);
                g.DrawLine(caneta_white, 100, 165, 125, 145);
                g.DrawLine(caneta_red, 75, 137, 125, 142);
                g.DrawLine(caneta_white, 100, 195, 125, 250);
                g.DrawLine(caneta_white, 100, 200, 85, 250);
            }
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ok_palavra_Click(object sender, EventArgs e)
        {
            lbl_dica.Text = "Dica: " + txt_dica.Text;
            lbl_dica.Visible = true;
            gpb_palavra.Enabled = false;
            gpb_teclado.Visible = true;
            lbl_qtd.Visible = true;
            lbl_vetor.Visible = true;
            

            palavra = new string[txt_palavra.TextLength];
            p_digitada = txt_palavra.Text;
            vAcerto = 0;

            for (int i=0;i < txt_palavra.TextLength; i++)
            {
                palavra[i] = "_ ";
                lbl_vetor.Text = lbl_vetor.Text + palavra[i];              
            }
            lbl_qtd.Text = txt_palavra.TextLength + " letras:";

        }

        
               
        private void btn_ok_letra_Click(object sender, EventArgs e)
        {
            
            char caracter = Convert.ToChar(txt_letra.Text);
            string la;
            lbl_vetor.Text = "";

            
            for (int i = 0; i < txt_palavra.TextLength; i++)
            {
                if (caracter == p_digitada[i])
                {
                    la = Convert.ToString(caracter);
                    palavra[i] = la + " ";
                    vAcerto++;
                }
                
                lbl_vetor.Text = lbl_vetor.Text +  palavra[i] ;

            }

            if (vAcerto == 0)
            {
                contador1++;
            }           

            pictureBox1.Refresh();

        }

        private void lbl_qtd_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "a";
            botoes();
            btn_a.Enabled = false;
            avaliar();
       
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "b";
            botoes();
            btn_b.Enabled = false;
            avaliar();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
           
            txt_letra.Text = "c";
            botoes();
            btn_c.Enabled = false;
            avaliar();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {

            txt_letra.Text = "d";
            botoes();
            btn_d.Enabled = false;
            avaliar();
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "e";
            botoes();
            btn_e.Enabled = false;
            avaliar();
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "f";
            botoes();
            btn_f.Enabled = false;
            avaliar();
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "g";
            botoes();
            btn_g.Enabled = false;
            avaliar();
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "h";
            botoes();
            btn_h.Enabled = false;
            avaliar();
        }

        private void btn_traco_Click(object sender, EventArgs e)
        {
            txt_letra.Text = " ";
            botoes();
            btn_traco.Enabled = false;
            avaliar();
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "j";
            botoes();
            btn_j.Enabled = false;
            avaliar();
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "k";
            botoes();
            btn_k.Enabled = false;
            avaliar();
            
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "l";
            botoes();
            btn_l.Enabled = false;
            avaliar();
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "m";
            botoes();
            btn_m.Enabled = false;
            avaliar();
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "n";
            botoes();
            btn_n.Enabled = false;
            avaliar();
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "o";
            botoes();
            btn_o.Enabled = false;
            avaliar();
        
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "p";
            botoes();
            btn_p.Enabled = false;
            avaliar();
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "q";
            botoes();
            btn_q.Enabled = false;
            avaliar();
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "r";
            botoes();
            btn_r.Enabled = false;
            avaliar();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "s";
            botoes();
            btn_s.Enabled = false;
            avaliar();
        }

        private void btn_t_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "t";
            botoes();
            btn_t.Enabled = false;
            avaliar();
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "u";
            botoes();
            btn_u.Enabled = false;
            avaliar();
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "v";
            botoes();
            btn_v.Enabled = false;
            avaliar();
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "w";
            botoes();
            btn_w.Enabled = false;
            avaliar();
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "x";
            botoes();
            btn_x.Enabled = false;
            avaliar();
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "y";
            botoes();
            btn_y.Enabled = false;
            avaliar();
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "z";
            botoes();
            btn_z.Enabled = false;
            avaliar();
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            txt_letra.Text = "i";
            botoes();
            btn_i.Enabled = false;
            avaliar();

        }

        private void botoes()
        {
            {
                char caracter = Convert.ToChar(txt_letra.Text);
                string la = txt_letra.Text;
                lbl_vetor.Text = "";


                for (int i = 0; i < txt_palavra.TextLength; i++)
                {
                    if (caracter == p_digitada[i])
                    {
                        la = Convert.ToString(caracter);
                        palavra[i] = la + " ";
                        vAcerto++;
                        contP++;
                    }


                    lbl_vetor.Text = lbl_vetor.Text + palavra[i];
                }             

                

            }
        }

        private void btn_nj_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pct_lose.Visible = false;
            gpb_palavra.Visible = true;
            btn_nj.Visible = false;
            btn_nj.Enabled = false;
            contador1 = 0;
            pictureBox1.Refresh();
            gpb_palavra.Enabled = true;
            txt_palavra.Text = "";            
            txt_dica.Text = "";
            

            btn_a.Enabled = true;
            btn_b.Enabled = true;
            btn_c.Enabled = true;
            btn_d.Enabled = true;
            btn_e.Enabled = true;
            btn_f.Enabled = true;
            btn_g.Enabled = true;
            btn_h.Enabled = true;
            btn_i.Enabled = true;
            btn_j.Enabled = true;
            btn_k.Enabled = true;
            btn_l.Enabled = true;
            btn_m.Enabled = true;
            btn_n.Enabled = true;
            btn_o.Enabled = true;
            btn_p.Enabled = true;
            btn_q.Enabled = true;
            btn_r.Enabled = true;
            btn_s.Enabled = true;
            btn_t.Enabled = true;
            btn_u.Enabled = true;
            btn_v.Enabled = true;
            btn_w.Enabled = true;
            btn_x.Enabled = true;
            btn_y.Enabled = true;
            btn_z.Enabled = true;
            btn_traco.Enabled = true;

            contP = 0;
            lbl_vetor.Text = "";
            lbl_qtd.Text = "";
        }
        private void avaliar()
        {          
            if (vAcerto == 0)
            {
                contador1++;
            }
           
            pictureBox1.Refresh();
            vAcerto = 0;

            if (contador1 == 7)
            {
                gpb_palavra.Visible = false;
                gpb_teclado.Visible = false;
                lbl_vetor.Visible = false;
                lbl_dica.Visible = false;
                lbl_qtd.Visible = false;
                pictureBox1.Visible = false;

                btn_nj.Visible = true;
                btn_nj.Enabled = true;

                pct_lose.Visible = true;
                MessageBox.Show("O jogo acabou!\nA palavra era: " + txt_palavra.Text+ "\nA dica era: "+txt_dica.Text);

            }
             if(contP == txt_palavra.TextLength)
            {
                pictureBox1.Visible = false;
                gpb_palavra.Visible = false;
                gpb_teclado.Visible = false;
                lbl_vetor.Visible = false;
                lbl_qtd.Visible = false;
                lbl_dica.Visible = false;

                btn_nj.Visible = true;
                btn_nj.Enabled = true;

                MessageBox.Show("Parabéns, você venceu!\nA palavra era: " + txt_palavra.Text+ "\nA dica era: " + txt_dica.Text);
                
            }          


        }
    }
    }
/* if (contador1 < 7)
            {
            int cont=0;
            int p = txt_palavra.TextLength;
            string avaliate = lbl_vetor.Text;
            String[] avaliateVet = new string[p];

            

            for(int i =0;i < p; i++)
            {
            if(avaliateVet[i] == palavra[i])
                {
                    cont++;
                }
            }             

            if (cont == p-1)
            {
                gpb_palavra.Visible = false;
                gpb_teclado.Visible = false;
                lbl_vetor.Visible = false;
                lbl_qtd.Visible = false;

                btn_nj.Visible = true;
                btn_nj.Enabled = true;

                MessageBox.Show("Parabéns, você venceu");
            }
            */
