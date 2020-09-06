namespace ProjetoConexao
{
    partial class frmTelaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.pct_professor = new System.Windows.Forms.PictureBox();
            this.pct_aluno = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct_professor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Você se enquadra em qual opção?";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(312, 396);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 14;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // pct_professor
            // 
            this.pct_professor.BackColor = System.Drawing.Color.Transparent;
            this.pct_professor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pct_professor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct_professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_professor.Image = global::ProjetoConexao.Properties.Resources.professor;
            this.pct_professor.Location = new System.Drawing.Point(277, 92);
            this.pct_professor.Name = "pct_professor";
            this.pct_professor.Size = new System.Drawing.Size(180, 270);
            this.pct_professor.TabIndex = 16;
            this.pct_professor.TabStop = false;
            this.pct_professor.Click += new System.EventHandler(this.pct_professor_Click);
            // 
            // pct_aluno
            // 
            this.pct_aluno.BackColor = System.Drawing.Color.Transparent;
            this.pct_aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pct_aluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_aluno.Image = global::ProjetoConexao.Properties.Resources.aluno;
            this.pct_aluno.Location = new System.Drawing.Point(19, 92);
            this.pct_aluno.Name = "pct_aluno";
            this.pct_aluno.Size = new System.Drawing.Size(180, 270);
            this.pct_aluno.TabIndex = 15;
            this.pct_aluno.TabStop = false;
            this.pct_aluno.Click += new System.EventHandler(this.pct_aluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teste de conexão com o servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Professor";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(402, 396);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 24);
            this.btn_sair.TabIndex = 20;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(511, 429);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pct_professor);
            this.Controls.Add(this.pct_aluno);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pct_professor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.PictureBox pct_aluno;
        private System.Windows.Forms.PictureBox pct_professor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sair;
    }
}

