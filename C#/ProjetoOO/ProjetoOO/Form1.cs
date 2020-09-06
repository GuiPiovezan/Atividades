using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_3_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            ClassCalculo objCalc = new ClassCalculo();
            objCalc.Peso = Convert.ToDouble(txt_peso.Text);
            objCalc.Altura = Convert.ToDouble(txt_altura.Text);

            lbl_resultado.Text = Convert.ToString(objCalc.CalqIMC());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_peso.Text = "";
            txt_altura.Text = "";
        }
    }
}
