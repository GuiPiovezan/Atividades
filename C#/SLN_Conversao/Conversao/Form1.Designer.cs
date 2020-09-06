namespace Conversao
{
    partial class frm_conversao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conversao));
            this.txt_ce = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_far = new System.Windows.Forms.TextBox();
            this.txt_kel = new System.Windows.Forms.TextBox();
            this.grb_graus = new System.Windows.Forms.GroupBox();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.lbl_farehnheit = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.grb_graus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ce
            // 
            this.txt_ce.ForeColor = System.Drawing.Color.Gold;
            this.txt_ce.Location = new System.Drawing.Point(135, 43);
            this.txt_ce.Name = "txt_ce";
            this.txt_ce.Size = new System.Drawing.Size(100, 25);
            this.txt_ce.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_far
            // 
            this.txt_far.ForeColor = System.Drawing.Color.Gold;
            this.txt_far.Location = new System.Drawing.Point(135, 94);
            this.txt_far.Name = "txt_far";
            this.txt_far.Size = new System.Drawing.Size(100, 25);
            this.txt_far.TabIndex = 2;
            // 
            // txt_kel
            // 
            this.txt_kel.ForeColor = System.Drawing.Color.Gold;
            this.txt_kel.Location = new System.Drawing.Point(135, 145);
            this.txt_kel.Name = "txt_kel";
            this.txt_kel.Size = new System.Drawing.Size(100, 25);
            this.txt_kel.TabIndex = 3;
            // 
            // grb_graus
            // 
            this.grb_graus.BackColor = System.Drawing.Color.Transparent;
            this.grb_graus.Controls.Add(this.lbl_celsius);
            this.grb_graus.Controls.Add(this.lbl_farehnheit);
            this.grb_graus.Controls.Add(this.lbl_kelvin);
            this.grb_graus.Controls.Add(this.txt_ce);
            this.grb_graus.Controls.Add(this.txt_kel);
            this.grb_graus.Controls.Add(this.txt_far);
            this.grb_graus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grb_graus.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_graus.ForeColor = System.Drawing.Color.Gold;
            this.grb_graus.Location = new System.Drawing.Point(12, 12);
            this.grb_graus.Name = "grb_graus";
            this.grb_graus.Size = new System.Drawing.Size(241, 208);
            this.grb_graus.TabIndex = 4;
            this.grb_graus.TabStop = false;
            this.grb_graus.Text = "Graus";
            this.grb_graus.Enter += new System.EventHandler(this.grb_graus_Enter);
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.AutoSize = true;
            this.lbl_celsius.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celsius.ForeColor = System.Drawing.Color.Blue;
            this.lbl_celsius.Location = new System.Drawing.Point(32, 43);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(88, 21);
            this.lbl_celsius.TabIndex = 5;
            this.lbl_celsius.Text = "CELSIUS:";
            this.lbl_celsius.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_farehnheit
            // 
            this.lbl_farehnheit.AutoSize = true;
            this.lbl_farehnheit.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_farehnheit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_farehnheit.Location = new System.Drawing.Point(-3, 93);
            this.lbl_farehnheit.Name = "lbl_farehnheit";
            this.lbl_farehnheit.Size = new System.Drawing.Size(127, 21);
            this.lbl_farehnheit.TabIndex = 6;
            this.lbl_farehnheit.Text = "FAREHNHEIT:";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kelvin.ForeColor = System.Drawing.Color.Blue;
            this.lbl_kelvin.Location = new System.Drawing.Point(32, 145);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(79, 21);
            this.lbl_kelvin.TabIndex = 7;
            this.lbl_kelvin.Text = "KELVIN:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.Gold;
            this.btn_calcular.Location = new System.Drawing.Point(259, 47);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(106, 28);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Gold;
            this.btn_limpar.Location = new System.Drawing.Point(259, 99);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(106, 32);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Gold;
            this.btn_sair.Location = new System.Drawing.Point(259, 157);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(106, 33);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_conversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(378, 258);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.grb_graus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_conversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de temperatura";
            this.grb_graus.ResumeLayout(false);
            this.grb_graus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ce;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_far;
        private System.Windows.Forms.TextBox txt_kel;
        private System.Windows.Forms.GroupBox grb_graus;
        private System.Windows.Forms.Label lbl_celsius;
        private System.Windows.Forms.Label lbl_farehnheit;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

