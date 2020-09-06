using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palavras
{
    public partial class frm_palavras : Form
    {
        int num = 0;
        String[] palavra = new string[40];
        int tamanho = 0;
        public frm_palavras()
        {
            InitializeComponent();
        }

        private void frm_palavras_Load(object sender, EventArgs e)
        {
            
            palavra[0] = "Cedral";
            palavra[1] = "José Bonifácio";
            palavra[2] = "São José do Rio Preto";
            palavra[3] = "Mirassol";
            palavra[4] = "Pindamonhangaba";
            palavra[5] = "Sales";
            palavra[6] = "Araçatuba";
            palavra[7] = "Joenvile";
            palavra[8] = "Guapiaçu";
            palavra[9] = "Icém";
            palavra[10] = "Tulipa";
            palavra[11] = "Girassol";
            palavra[12] = "Violeta";
            palavra[13] = "Lírio";
            palavra[14] = "Orquídea";
            palavra[15] = "Cravo";
            palavra[16] = "Margarida";
            palavra[17] = "Camélia";
            palavra[18] = "Azaleia";
            palavra[19] = "Golf";
            palavra[20] = "Gol";
            palavra[21] = "Corolla";
            palavra[22] = "Civic";
            palavra[23] = "Renault Sandero";
            palavra[24] = "BMW";
            palavra[25] = "Ferrari";
            palavra[26] = "IX35";
            palavra[27] = "Opala";
            palavra[28] = "Corsa";
            palavra[29] = "Fusion";
            palavra[30] = "Maçã";
            palavra[31] = "Uva";
            palavra[32] = "Pessêgo";
            palavra[33] = "Melão";
            palavra[34] = "Melancia";
            palavra[35] = "Abacate";
            palavra[36] = "Kiwi";
            palavra[37] = "Banana";
            palavra[38] = "Caju";
            palavra[39] = "Abacaxi";

        }

        private void btn_sorteio_Click(object sender, EventArgs e)
        {
            Random palavra_aleatoria = new Random();
            num = palavra_aleatoria.Next(0, 39);
            lbl_palavra.Text = palavra[num];
            tamanho = palavra[num].Length;
            lbl_qtde.Text = Convert.ToString(tamanho);
            lbl_partes.Text = palavra[num].Substring(0, 3);
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}