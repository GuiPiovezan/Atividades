using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescobreNumero
{
    public partial class frm_parabens : Form
    {
        public frm_parabens()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Parabéns!!!!");
            Close();
            
        }
    }
}
