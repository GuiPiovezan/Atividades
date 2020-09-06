using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robauto
{
    
    public partial class frm_robauto : Form
    {
        String marca, nome, modelo, ano;
        String acessorio = "";
        
        public frm_robauto()
        {
            InitializeComponent();
        }
       

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbo_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelo = cbo_modelo.Text;
        }

        private void lst_acessorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            acessorio = acessorio + " " + lst_acessorios.Text;
            lst_acessorios.Items.Remove(lst_acessorios.SelectedItem);
        }

        private void lbl_apresentacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            lbl_apresentacao1.Visible = true;
            if (cbo_marca.SelectedIndex == -1 || cbo_nome.SelectedIndex == -1 || cbo_modelo.SelectedIndex == -1 || lst_ano.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma marca, nome, modelo e ano!");
            }
            else
            {
                if (marca != "" && modelo != "" && nome != "" && ano != "" && acessorio == "")
                {
                    lbl_apresentacao.Text = "Marca: " + marca + "\nNome: " + nome + "\nModelo: " + modelo + "\nAno: " + ano + "\nAcessórios: sem acessórios";
                }
                else if (acessorio != "")
                {
                    lbl_apresentacao.Text = "Marca: " + marca + "\nNome: " + nome + "\nModelo: " + modelo + "\nAno: " + ano + "\nAcessórios: " + acessorio + ".";
                }
            }

        }

        private void btn_novo_pedido_Click(object sender, EventArgs e)
        {
            lbl_apresentacao1.Visible = false;
            lst_acessorios.Items.Clear();
            ano = "";
            nome = "";
            marca = "";
            modelo = "";
            acessorio = "";
            lbl_apresentacao.Text = "";
            acessorios();
        }
        private void acessorios()
        {
            lst_acessorios.Items.Add("CENTRAL MULTI-MIDIA");
            lst_acessorios.Items.Add("AR CONDICIONADO");
            lst_acessorios.Items.Add("TRAVAS ELETRICAS");
            lst_acessorios.Items.Add("VIDRO ELETRICO");
            lst_acessorios.Items.Add("AIRBERG"); 
            lst_acessorios.Items.Add("BANCO DE COURO");
            lst_acessorios.Items.Add("RODAS DE LIGA LEVE");
            lst_acessorios.Items.Add("COMPUTADOR DE BORDO");
            lst_acessorios.Items.Add("GPS");
            lst_acessorios.Items.Add("FAROL DE MILHA");
        }

        private void lst_ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            ano = lst_ano.Text;
        }

        private void cbo_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            nome = cbo_nome.Text;
            if (nome == "AZERA")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("GLS 3.3 V6");
                cbo_modelo.Items.Add("Azera 3.0 V6");
            }
            if (nome == "HB20")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("Unique 1.0");
                cbo_modelo.Items.Add("Comfort Plus 1.6");
                cbo_modelo.Items.Add("Spec 1.6");
            }
            if (nome == "SANTA FÉ")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("2.4");
                cbo_modelo.Items.Add("2.7");
                cbo_modelo.Items.Add("3.5");
            }
            if (nome == "CIVIC")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("Sport Automático");
                cbo_modelo.Items.Add("Civic EX");
                cbo_modelo.Items.Add("Civic EXL");
            }
            if (nome == "CITY")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("LX CVT");
                cbo_modelo.Items.Add("EX CVT");
                cbo_modelo.Items.Add("EXL CVT");
            }
            if (nome == "CRV")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("CRV - 1.6");
                cbo_modelo.Items.Add("CRV - 2.0");
                cbo_modelo.Items.Add("CRV - 3.3");
            }
            if (nome == "C4")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("Lounge 2018");
                cbo_modelo.Items.Add("DS4");
                cbo_modelo.Items.Add("C4 PICASSO");
            }
            if (nome == "JUMPER")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("2.0");
                cbo_modelo.Items.Add("2.6");
                cbo_modelo.Items.Add("3.5");
            }
            if (nome == "AIRCROSS")
            {
                cbo_modelo.Items.Clear();
                cbo_modelo.Items.Add("2018");
                cbo_modelo.Items.Add("2016");
                cbo_modelo.Items.Add("2014");
            }
            

        }
        private void cbo_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
                marca = cbo_marca.Text;
                if (marca == "HYUNDAI")
                {
                    
                    cbo_nome.Items.Clear();
                    cbo_nome.Items.Add("AZERA");
                    cbo_nome.Items.Add("HB20");
                    cbo_nome.Items.Add("SANTA FÉ");
                    
                 }
                if (marca == "HONDA")
                {
                    
                    cbo_nome.Items.Clear();
                    cbo_nome.Items.Add("CIVIC");
                    cbo_nome.Items.Add("CITY");
                    cbo_nome.Items.Add("CRV");
                    
                 }
                if (marca == "CITROEN")
                {
                    
                    cbo_nome.Items.Clear();
                    cbo_nome.Items.Add("C4");
                    cbo_nome.Items.Add("JUMPER");
                    cbo_nome.Items.Add("AIRCROSS");
                    
                 }
        }
    }
}
