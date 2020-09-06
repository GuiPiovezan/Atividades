using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao
{
    public partial class frm_conversao : Form
    {
        Double celsius, kelvin, faht, resultado;
        public frm_conversao()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_ce.Text = "";
            txt_far.Text = "";
            txt_kel.Text = "";
            grb_graus.Enabled = true;
        }

        private void grb_graus_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            
                if (txt_ce.Text != "" && txt_far.Text == "" && txt_kel.Text == "")
                {
                    try
                    {
                        Convert.ToDouble(txt_ce.Text.Replace(".", ","));
                        celsius = Convert.ToDouble(txt_ce.Text);
                        faht = (1.8 * celsius) + 32;
                        kelvin = celsius + 273;
                        txt_far.Text = Convert.ToString(faht);
                        txt_kel.Text = Convert.ToString(kelvin);
                        grb_graus.Enabled = false;
                    }
                    catch
                    {
                        txt_ce.Text = "ERRO";
                        txt_far.Text = "ERRO";
                        txt_kel.Text = "ERRO";
                    }
                }
                
                if(txt_far.Text != "" && txt_ce.Text=="" && txt_kel.Text=="")
                {
                   try
                   {
                    Convert.ToDouble(txt_far.Text.Replace(".", ","));
                    faht = Convert.ToDouble(txt_far.Text);
                    celsius = (faht - 32)/1.8;
                    kelvin = ((faht - 32) / 1.800) + 273.15;
                    txt_ce.Text = Convert.ToString(celsius);
                    txt_kel.Text = Convert.ToString(kelvin);
                    grb_graus.Enabled = false;

                    }
                catch
                   {
                    txt_ce.Text = "ERRO";
                    txt_far.Text = "ERRO";
                    txt_kel.Text = "ERRO";
                    }
                 
                }
                 if(txt_kel.Text != "" && txt_ce.Text == "" && txt_far.Text == "")
                {
                    try
                    {
                    Convert.ToDouble(txt_kel.Text.Replace(".", ","));
                    kelvin = Convert.ToDouble(txt_kel.Text);
                    celsius = kelvin - 273.15;
                    faht = ((kelvin - 273) * 1.8) + 32;
                    txt_ce.Text = Convert.ToString(celsius);
                    txt_far.Text = Convert.ToString(faht);
                    grb_graus.Enabled = false;
                    }
                     catch
                    {
                    txt_ce.Text = "ERRO";
                    txt_far.Text = "ERRO";
                    txt_kel.Text = "ERRO";
                    }
            }
          
            
            
        }
    }
}
