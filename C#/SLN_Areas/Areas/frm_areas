using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class frm_areas : Form
        
    {
        double n1, n2, n3, total;
        public frm_areas()
        {
            InitializeComponent();
        }

        private void rdb_quadrado_CheckedChanged(object sender, EventArgs e)
        {
           
         
                pct_quadrado.Visible = true;
                pct_circulo.Visible = false;
                pct_retangulo.Visible = false;
                pct_triangulo.Visible = false;
                pct_trapezio.Visible = false;
                lbl_n1.Text = "Lado: ";
                lbl_n1.Visible = true;
                lbl_n2.Visible = false;
                lbl_n3.Visible = false;
                txt_n1.Visible = true;
                txt_n1.Text = "";
                txt_n2.Visible = false;
                txt_n3.Visible = false;
            lbl_totalArea.Visible = true;
            lbl_total_area.Visible = true;
            lbl2.Visible = false;
            btn_calcular.Visible = true;
            btn_limpar.Visible = true;
            lbl_totalArea.Text = "";

           
        }

        private void rdb_retangulo_CheckedChanged(object sender, EventArgs e)
        {
           
                pct_retangulo.Visible = true;
                pct_circulo.Visible = false;
                pct_quadrado.Visible = false;
                pct_triangulo.Visible = false;
                pct_trapezio.Visible = false;

                lbl_n1.Text = "Base: ";
                lbl_n2.Text = "Altura: ";
                lbl_n1.Visible = true;
                lbl_n2.Visible = true;
                lbl_n3.Visible = false;
                txt_n1.Visible = true;
                txt_n1.Text = "";
                txt_n2.Visible = true;
                txt_n2.Text = "";
                txt_n3.Visible = false;
            lbl_totalArea.Visible = true;
            lbl_total_area.Visible = true;
            lbl2.Visible = false;
            btn_calcular.Visible = true;
            btn_limpar.Visible = true;
            lbl_totalArea.Text = "";
        }

        private void rdb_triangulo_CheckedChanged(object sender, EventArgs e)
        {
            pct_triangulo.Visible = true;
            pct_circulo.Visible = false;
            pct_quadrado.Visible = false;
            pct_retangulo.Visible = false;
            pct_trapezio.Visible = false;

            lbl_n1.Text = "Base: ";
            lbl_n2.Text = "Altura: ";
            lbl_n1.Visible = true;
            lbl_n2.Visible = true;
            lbl_n3.Visible = false;
            txt_n1.Visible = true;
            txt_n1.Text = "";
            txt_n2.Visible = true;
            txt_n2.Text = "";
            txt_n3.Visible = false;
            lbl_total_area.Visible = true;
            lbl_totalArea.Visible = true;
            lbl2.Visible = false;
            btn_calcular.Visible = true;
            btn_limpar.Visible = true;
            lbl_totalArea.Text = "";
        }

        private void rdb_trpezio_CheckedChanged(object sender, EventArgs e)
        {
            pct_trapezio.Visible = true;
            pct_retangulo.Visible = false;
            pct_quadrado.Visible = false;
            pct_triangulo.Visible = false;
            pct_circulo.Visible = false;

            lbl_n1.Text = "Base Maior: ";
            lbl_n2.Text = "Base Menor: ";
            lbl_n3.Text = "Altura: ";
            lbl_n1.Visible = true;
            lbl_n2.Visible = true;
            lbl_n3.Visible = true;
            txt_n1.Visible = true;
            txt_n1.Text = "";
            txt_n2.Visible = true;
            txt_n2.Text = "";
            txt_n3.Visible = true;
            txt_n3.Text = "";
            lbl_totalArea.Visible = true;
            lbl_total_area.Visible = true;
            lbl2.Visible = false;
            btn_calcular.Visible = true;
            btn_limpar.Visible = true;
            lbl_totalArea.Text = "";
        }

        private void rdb_circulo_CheckedChanged(object sender, EventArgs e)
        {
            pct_circulo.Visible = true;
            pct_quadrado.Visible = false;
            pct_retangulo.Visible = false;
            pct_trapezio.Visible = false;
            pct_triangulo.Visible = false;

            lbl_n1.Text = "Raio: ";
            lbl_n1.Visible = true;
            lbl_n2.Visible = false;
            lbl_n3.Visible = false;
            txt_n1.Visible = true;
            txt_n1.Text = "";
            txt_n2.Visible = false;
            txt_n3.Visible = false;
            lbl_totalArea.Visible = true;
            lbl_total_area.Visible = true;
            lbl2.Visible = false;
            btn_calcular.Visible = true;
            btn_limpar.Visible = true;
            lbl_totalArea.Text = "";


        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            lbl_totalArea.Text = "";
            rdb_circulo.Checked = false;
            pct_circulo.Visible = false;
            rdb_quadrado.Checked = false;
            pct_quadrado.Visible = false;
            rdb_retangulo.Checked = false;
            pct_retangulo.Visible = false;
            rdb_triangulo.Checked = false;
            pct_triangulo.Visible = false;
            rdb_trpezio.Checked = false;
            pct_trapezio.Visible = false;
            lbl_n1.Visible = false;
            lbl_n2.Visible = false;
            lbl_n3.Visible = false;
            txt_n1.Visible = false;
            txt_n2.Visible = false;
            txt_n3.Visible = false;
            lbl_totalArea.Visible = false;
            lbl_total_area.Visible = false;
            lbl2.Visible = true;
            lbl2.Text = "Escolha uma figura!";
            btn_calcular.Visible = false;
            btn_limpar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (rdb_quadrado.Checked == true)
            {
                try
                {
                    n1 = Convert.ToDouble(txt_n1.Text);
                    total = n1 * n1;
                    lbl_totalArea.Text = Convert.ToString(total);
                }
                catch
                {
                    txt_n1.Text = "ERRO";
                }
            }
            else if (rdb_circulo.Checked == true)
            {
                try
                {
                    n1 = Convert.ToDouble(txt_n1.Text);
                    total = 3.14 * (n1 * n1);
                    lbl_totalArea.Text = Convert.ToString(total);
                }
                catch
                {
                    txt_n1.Text = "ERRO";
                }
            }
            else if (rdb_retangulo.Checked == true)
            {
                try
                {
                    n1 = Convert.ToDouble(txt_n1.Text);
                    n2 = Convert.ToDouble(txt_n2.Text);
                    total = n1 * n2;
                    lbl_totalArea.Text = Convert.ToString(total);
                }
                catch
                {
                    txt_n1.Text = "ERRO";
                    txt_n2.Text = "ERRO";
                }

            }
            else if (rdb_triangulo.Checked == true)
            {
                try
                {
                    n1 = Convert.ToDouble(txt_n1.Text);
                    n2 = Convert.ToDouble(txt_n2.Text);
                    total = n1 * n2;
                    lbl_totalArea.Text = Convert.ToString(total);
                }
                catch
                {
                    txt_n1.Text = "ERRO";
                    txt_n2.Text = "ERRO";

                }

            }
            else if (rdb_trpezio.Checked == true)
            {
                try
                {
                    n1 = Convert.ToDouble(txt_n1.Text);
                    n2 = Convert.ToDouble(txt_n2.Text);
                    n3 = Convert.ToDouble(txt_n3.Text);
                    total = ((n1 + n2) / 2) * n3;
                    lbl_totalArea.Text = Convert.ToString(total);
                }
                catch
                {
                    txt_n1.Text = "ERRO";
                    txt_n2.Text = "ERRO";
                    txt_n3.Text = "ERRO";
                }
            }
            else
            {
                MessageBox.Show("Selecione uma figura!");
            }
           
        }
   }
}
   
