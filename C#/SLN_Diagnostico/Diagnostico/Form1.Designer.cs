namespace Diagnostico
{
    partial class frm_diagnostico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_diagnostico));
            this.lbl_kms = new System.Windows.Forms.Label();
            this.lbl_Kmc = new System.Windows.Forms.Label();
            this.lbl_litros = new System.Windows.Forms.Label();
            this.lbl_Kmpercorrido = new System.Windows.Forms.Label();
            this.lbl_KmLitros = new System.Windows.Forms.Label();
            this.lbl_diagn = new System.Windows.Forms.Label();
            this.lbl_linha = new System.Windows.Forms.Label();
            this.txt_kms = new System.Windows.Forms.TextBox();
            this.txt_kmc = new System.Windows.Forms.TextBox();
            this.txt_litros = new System.Windows.Forms.TextBox();
            this.lbl_percorridos = new System.Windows.Forms.Label();
            this.lbl_kml = new System.Windows.Forms.Label();
            this.lbl_diagnostico = new System.Windows.Forms.Label();
            this.btn_cacular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_kms
            // 
            this.lbl_kms.BackColor = System.Drawing.Color.Black;
            this.lbl_kms.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kms.ForeColor = System.Drawing.Color.Red;
            this.lbl_kms.Location = new System.Drawing.Point(81, 93);
            this.lbl_kms.Name = "lbl_kms";
            this.lbl_kms.Size = new System.Drawing.Size(98, 30);
            this.lbl_kms.TabIndex = 0;
            this.lbl_kms.Text = "Km Saída:";
            this.lbl_kms.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Kmc
            // 
            this.lbl_Kmc.BackColor = System.Drawing.Color.Black;
            this.lbl_Kmc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kmc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Kmc.Location = new System.Drawing.Point(51, 143);
            this.lbl_Kmc.Name = "lbl_Kmc";
            this.lbl_Kmc.Size = new System.Drawing.Size(128, 30);
            this.lbl_Kmc.TabIndex = 1;
            this.lbl_Kmc.Text = "Km chegada:";
            this.lbl_Kmc.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_litros
            // 
            this.lbl_litros.BackColor = System.Drawing.Color.Black;
            this.lbl_litros.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_litros.ForeColor = System.Drawing.Color.Red;
            this.lbl_litros.Location = new System.Drawing.Point(51, 186);
            this.lbl_litros.Name = "lbl_litros";
            this.lbl_litros.Size = new System.Drawing.Size(130, 28);
            this.lbl_litros.TabIndex = 2;
            this.lbl_litros.Text = "Litros Gastos:";
            // 
            // lbl_Kmpercorrido
            // 
            this.lbl_Kmpercorrido.AutoSize = true;
            this.lbl_Kmpercorrido.BackColor = System.Drawing.Color.Black;
            this.lbl_Kmpercorrido.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kmpercorrido.ForeColor = System.Drawing.Color.Red;
            this.lbl_Kmpercorrido.Location = new System.Drawing.Point(28, 324);
            this.lbl_Kmpercorrido.Name = "lbl_Kmpercorrido";
            this.lbl_Kmpercorrido.Size = new System.Drawing.Size(149, 26);
            this.lbl_Kmpercorrido.TabIndex = 3;
            this.lbl_Kmpercorrido.Text = "Km percorridos:";
            this.lbl_Kmpercorrido.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_KmLitros
            // 
            this.lbl_KmLitros.AutoSize = true;
            this.lbl_KmLitros.BackColor = System.Drawing.Color.Black;
            this.lbl_KmLitros.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KmLitros.ForeColor = System.Drawing.Color.Red;
            this.lbl_KmLitros.Location = new System.Drawing.Point(28, 376);
            this.lbl_KmLitros.Name = "lbl_KmLitros";
            this.lbl_KmLitros.Size = new System.Drawing.Size(107, 26);
            this.lbl_KmLitros.TabIndex = 4;
            this.lbl_KmLitros.Text = "Km/Litros: ";
            // 
            // lbl_diagn
            // 
            this.lbl_diagn.AutoSize = true;
            this.lbl_diagn.BackColor = System.Drawing.Color.Black;
            this.lbl_diagn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagn.ForeColor = System.Drawing.Color.Red;
            this.lbl_diagn.Location = new System.Drawing.Point(28, 444);
            this.lbl_diagn.Name = "lbl_diagn";
            this.lbl_diagn.Size = new System.Drawing.Size(118, 26);
            this.lbl_diagn.TabIndex = 5;
            this.lbl_diagn.Text = "Diagnóstico:";
            this.lbl_diagn.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_linha
            // 
            this.lbl_linha.BackColor = System.Drawing.Color.Red;
            this.lbl_linha.Location = new System.Drawing.Point(-1, 269);
            this.lbl_linha.Name = "lbl_linha";
            this.lbl_linha.Size = new System.Drawing.Size(496, 12);
            this.lbl_linha.TabIndex = 6;
            this.lbl_linha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_kms
            // 
            this.txt_kms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kms.Location = new System.Drawing.Point(172, 93);
            this.txt_kms.Name = "txt_kms";
            this.txt_kms.Size = new System.Drawing.Size(100, 26);
            this.txt_kms.TabIndex = 7;
            this.txt_kms.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_kmc
            // 
            this.txt_kmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kmc.Location = new System.Drawing.Point(172, 143);
            this.txt_kmc.Name = "txt_kmc";
            this.txt_kmc.Size = new System.Drawing.Size(100, 26);
            this.txt_kmc.TabIndex = 8;
            // 
            // txt_litros
            // 
            this.txt_litros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_litros.Location = new System.Drawing.Point(178, 188);
            this.txt_litros.Name = "txt_litros";
            this.txt_litros.Size = new System.Drawing.Size(100, 26);
            this.txt_litros.TabIndex = 9;
            // 
            // lbl_percorridos
            // 
            this.lbl_percorridos.BackColor = System.Drawing.Color.White;
            this.lbl_percorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percorridos.ForeColor = System.Drawing.Color.Black;
            this.lbl_percorridos.Location = new System.Drawing.Point(174, 330);
            this.lbl_percorridos.Name = "lbl_percorridos";
            this.lbl_percorridos.Size = new System.Drawing.Size(135, 20);
            this.lbl_percorridos.TabIndex = 10;
            this.lbl_percorridos.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_kml
            // 
            this.lbl_kml.BackColor = System.Drawing.Color.White;
            this.lbl_kml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kml.ForeColor = System.Drawing.Color.Black;
            this.lbl_kml.Location = new System.Drawing.Point(126, 380);
            this.lbl_kml.Name = "lbl_kml";
            this.lbl_kml.Size = new System.Drawing.Size(135, 20);
            this.lbl_kml.TabIndex = 11;
            // 
            // lbl_diagnostico
            // 
            this.lbl_diagnostico.BackColor = System.Drawing.Color.White;
            this.lbl_diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagnostico.ForeColor = System.Drawing.Color.Black;
            this.lbl_diagnostico.Location = new System.Drawing.Point(152, 448);
            this.lbl_diagnostico.Name = "lbl_diagnostico";
            this.lbl_diagnostico.Size = new System.Drawing.Size(135, 20);
            this.lbl_diagnostico.TabIndex = 12;
            // 
            // btn_cacular
            // 
            this.btn_cacular.BackColor = System.Drawing.Color.Black;
            this.btn_cacular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cacular.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cacular.ForeColor = System.Drawing.Color.Gold;
            this.btn_cacular.Location = new System.Drawing.Point(337, 203);
            this.btn_cacular.Name = "btn_cacular";
            this.btn_cacular.Size = new System.Drawing.Size(146, 39);
            this.btn_cacular.TabIndex = 13;
            this.btn_cacular.Text = "CALCULAR";
            this.btn_cacular.UseVisualStyleBackColor = false;
            this.btn_cacular.Click += new System.EventHandler(this.btn_cacular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Gold;
            this.btn_limpar.Location = new System.Drawing.Point(47, 514);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(115, 35);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(379, 515);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(91, 34);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nome.Location = new System.Drawing.Point(51, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(348, 30);
            this.lbl_nome.TabIndex = 16;
            this.lbl_nome.Text = "Diagnóstico de veículos";
            // 
            // frm_diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(495, 561);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cacular);
            this.Controls.Add(this.lbl_diagnostico);
            this.Controls.Add(this.lbl_kml);
            this.Controls.Add(this.lbl_percorridos);
            this.Controls.Add(this.txt_litros);
            this.Controls.Add(this.txt_kmc);
            this.Controls.Add(this.txt_kms);
            this.Controls.Add(this.lbl_linha);
            this.Controls.Add(this.lbl_diagn);
            this.Controls.Add(this.lbl_KmLitros);
            this.Controls.Add(this.lbl_Kmpercorrido);
            this.Controls.Add(this.lbl_litros);
            this.Controls.Add(this.lbl_Kmc);
            this.Controls.Add(this.lbl_kms);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnóstico de veiculos ";
            this.Load += new System.EventHandler(this.frm_diagnostico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kms;
        private System.Windows.Forms.Label lbl_Kmc;
        private System.Windows.Forms.Label lbl_litros;
        private System.Windows.Forms.Label lbl_Kmpercorrido;
        private System.Windows.Forms.Label lbl_KmLitros;
        private System.Windows.Forms.Label lbl_diagn;
        private System.Windows.Forms.Label lbl_linha;
        private System.Windows.Forms.TextBox txt_kms;
        private System.Windows.Forms.TextBox txt_kmc;
        private System.Windows.Forms.TextBox txt_litros;
        private System.Windows.Forms.Label lbl_percorridos;
        private System.Windows.Forms.Label lbl_kml;
        private System.Windows.Forms.Label lbl_diagnostico;
        private System.Windows.Forms.Button btn_cacular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_nome;
    }
}

