namespace Palavras
{
    partial class frm_palavras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_palavras));
            this.btn_sorteio = new System.Windows.Forms.Button();
            this.lbl_palavra = new System.Windows.Forms.Label();
            this.lbl_qtde = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_partes = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sorteio
            // 
            this.btn_sorteio.BackColor = System.Drawing.Color.Transparent;
            this.btn_sorteio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sorteio.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sorteio.ForeColor = System.Drawing.Color.Gold;
            this.btn_sorteio.Location = new System.Drawing.Point(12, 49);
            this.btn_sorteio.Name = "btn_sorteio";
            this.btn_sorteio.Size = new System.Drawing.Size(98, 23);
            this.btn_sorteio.TabIndex = 0;
            this.btn_sorteio.Text = "Sorteio";
            this.btn_sorteio.UseVisualStyleBackColor = false;
            this.btn_sorteio.Click += new System.EventHandler(this.btn_sorteio_Click);
            // 
            // lbl_palavra
            // 
            this.lbl_palavra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_palavra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palavra.ForeColor = System.Drawing.Color.Blue;
            this.lbl_palavra.Location = new System.Drawing.Point(92, 96);
            this.lbl_palavra.Name = "lbl_palavra";
            this.lbl_palavra.Size = new System.Drawing.Size(237, 23);
            this.lbl_palavra.TabIndex = 1;
            // 
            // lbl_qtde
            // 
            this.lbl_qtde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qtde.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtde.ForeColor = System.Drawing.Color.Lime;
            this.lbl_qtde.Location = new System.Drawing.Point(173, 149);
            this.lbl_qtde.Name = "lbl_qtde";
            this.lbl_qtde.Size = new System.Drawing.Size(54, 23);
            this.lbl_qtde.TabIndex = 2;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_1.Location = new System.Drawing.Point(9, 97);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(77, 22);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Palavra:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.Color.Red;
            this.lbl_2.Location = new System.Drawing.Point(9, 149);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(158, 23);
            this.lbl_2.TabIndex = 4;
            this.lbl_2.Text = "Quantidade de letras:";
            // 
            // lbl_partes
            // 
            this.lbl_partes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_partes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partes.ForeColor = System.Drawing.Color.Lime;
            this.lbl_partes.Location = new System.Drawing.Point(192, 202);
            this.lbl_partes.Name = "lbl_partes";
            this.lbl_partes.Size = new System.Drawing.Size(66, 23);
            this.lbl_partes.TabIndex = 5;
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.Red;
            this.lbl_3.Location = new System.Drawing.Point(10, 202);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(176, 23);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "Três primeiras palavras:";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.Gold;
            this.btn_sair.Location = new System.Drawing.Point(264, 226);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_palavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Palavras.Properties.Resources.imagem_plf;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_partes);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_qtde);
            this.Controls.Add(this.lbl_palavra);
            this.Controls.Add(this.btn_sorteio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_palavras";
            this.Text = "Palavras";
            this.Load += new System.EventHandler(this.frm_palavras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sorteio;
        private System.Windows.Forms.Label lbl_palavra;
        private System.Windows.Forms.Label lbl_qtde;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_partes;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btn_sair;
    }
}

