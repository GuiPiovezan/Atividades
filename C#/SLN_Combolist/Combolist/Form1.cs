using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combolist
{
    public partial class frm_Combolist : Form
    {

        int tipo = 0;
        String item;
        public frm_Combolist()
        {
            InitializeComponent();
            remove();
            
        }
        private void remove()
        {
            if ((cbo_lista.Items.Count == 0) && (lst_lista.Items.Count == 0))
            {
                btn_remove.Enabled = false;
            }
            else if((cbo_lista.Items.Count > 0) && (lst_lista.Items.Count > 0))
            {
                btn_remove.Enabled = true;
            }
        }

        private void btn_insere_Click(object sender, EventArgs e)
        {
            if (tipo==0)
                {
                lbl_insere.Visible = true;
                txt_item.Visible = true;
                txt_item.Text = " ";
                txt_item.Focus();
                tipo = 1;
                remove();
                
                }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(tipo==0)
            {
                lbl_remove.Visible = true;
                tipo = 2;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
               
                if (tipo == 1)
                {
                    if (txt_item.Text == " " || txt_item.Text == "   " || txt_item.Text == "    ")
                    { MessageBox.Show("Digite um item válido!"); }
                    else
                {
                        btn_remove.Visible = true;
                        cbo_lista.Items.Add(txt_item.Text);
                        lst_lista.Items.Add(txt_item.Text);
                        lbl_insere.Visible = false; txt_item.Visible = false;
                        lbl_conta.Text = Convert.ToString(cbo_lista.Items.Count);
                        tipo = 0;
                        remove();
                    }


                }
                else if (tipo == 2)
                {
                    if (cbo_lista.SelectedIndex == -1 || lst_lista.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por genetileza, selecione mais de um item para ser removido");
                    }
                    else
                    {
                        lbl_cbo.Text = cbo_lista.Text;
                        lbl_list.Text = lst_lista.Text;
                        lbl_1.Visible = true; lbl_2.Visible = true;
                        lbl_cbo.Visible = true; lbl_list.Visible = true;
                        cbo_lista.Items.Remove(cbo_lista.Text);
                        lst_lista.Items.Remove(lst_lista.Text);
                        lbl_conta.Text = Convert.ToString(cbo_lista.Items.Count);
                        tipo = 3;
                    }

                }
                else if (tipo == 3)
                {
                    lbl_remove.Visible = false;
                    lbl_1.Visible = false;
                    lbl_2.Visible = false;
                    lbl_cbo.Visible = false;
                    lbl_list.Visible = false;
                    tipo = 0;
                }

                else
                {
                    tipo = 0;
                }
            
            
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            cbo_lista.Items.Clear();
            lst_lista.Items.Clear();
            remove();
            lbl_conta.Text = " ";
            
        }

        private void cbo_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
