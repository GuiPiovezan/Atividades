using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostico
{
    public partial class frm_diagnostico : Form
    {
        Double km_saida, km_chegada, litros, rpercorrido, rkml, rdiagnostico;
        public frm_diagnostico()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cacular_Click(object sender, EventArgs e)
        {
            try
            {
                km_saida = Convert.ToDouble(txt_kms.Text);
                km_chegada = Convert.ToDouble(txt_kmc.Text);
                litros = Convert.ToDouble(txt_litros.Text);
                rpercorrido = (km_chegada - km_saida);
                rkml = (rpercorrido / litros);
                lbl_percorridos.Text = Convert.ToString(rpercorrido);
                lbl_kml.Text = Convert.ToString(rkml);

                if(rkml<=5)
                {
                    lbl_diagnostico.Text = "Veículo Ruim";
                }
                else if(rkml>5 && rkml<=12)
                {
                    lbl_diagnostico.Text = "Veículo Bom";
                }
                else
                {
                    lbl_diagnostico.Text = "Veículo Ótimo";
                }
            }
            catch
            {
                lbl_percorridos.Text = "Erro";
                lbl_kml.Text = "Apenas";
                lbl_diagnostico.Text = "Números";
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_kmc.Clear();
            txt_kms.Clear();
            txt_litros.Clear();
            Convert.ToString(lbl_diagnostico.Text);
            Convert.ToString(lbl_kml.Text);
            Convert.ToString(lbl_percorridos.Text);
            lbl_percorridos.Text= "";
            lbl_kml.Text = "";
            lbl_diagnostico.Text = "";
        }

        private void frm_diagnostico_Load(object sender, EventArgs e)
        {

        }
    }
}
