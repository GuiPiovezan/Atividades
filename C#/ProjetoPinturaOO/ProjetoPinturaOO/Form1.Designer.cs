namespace ProjetoPinturaOO
{
    partial class frm_projeto_pintura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_vLatas = new System.Windows.Forms.TextBox();
            this.txt_vMaodobra = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_1.Location = new System.Drawing.Point(-2, 41);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(79, 16);
            this.lbl_1.TabIndex = 5;
            this.lbl_1.Text = "Área total:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_2.Location = new System.Drawing.Point(-2, 76);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(178, 16);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "Valor da Lata de Tintas: ";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_3.Location = new System.Drawing.Point(-2, 116);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(169, 16);
            this.lbl_3.TabIndex = 7;
            this.lbl_3.Text = "Valor dia Mão-de-obra:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.Red;
            this.btn_calcular.Location = new System.Drawing.Point(179, 153);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(179, 37);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 1;
            // 
            // txt_vLatas
            // 
            this.txt_vLatas.Location = new System.Drawing.Point(179, 75);
            this.txt_vLatas.Name = "txt_vLatas";
            this.txt_vLatas.Size = new System.Drawing.Size(100, 20);
            this.txt_vLatas.TabIndex = 2;
            // 
            // txt_vMaodobra
            // 
            this.txt_vMaodobra.Location = new System.Drawing.Point(179, 112);
            this.txt_vMaodobra.Name = "txt_vMaodobra";
            this.txt_vMaodobra.Size = new System.Drawing.Size(100, 20);
            this.txt_vMaodobra.TabIndex = 3;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_resultado.Location = new System.Drawing.Point(12, 189);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(267, 133);
            this.lbl_resultado.TabIndex = 10;
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Red;
            this.btn_limpar.Location = new System.Drawing.Point(12, 334);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(162, 334);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 23);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_projeto_pintura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(291, 369);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_vMaodobra);
            this.Controls.Add(this.txt_vLatas);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_projeto_pintura";
            this.Text = "Projeto Pintura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_vLatas;
        private System.Windows.Forms.TextBox txt_vMaodobra;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

