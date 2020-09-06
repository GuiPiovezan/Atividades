namespace Areas
{
    partial class frm_areas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_areas));
            this.grb_figuras = new System.Windows.Forms.GroupBox();
            this.rdb_circulo = new System.Windows.Forms.RadioButton();
            this.rdb_trpezio = new System.Windows.Forms.RadioButton();
            this.rdb_triangulo = new System.Windows.Forms.RadioButton();
            this.rdb_retangulo = new System.Windows.Forms.RadioButton();
            this.rdb_quadrado = new System.Windows.Forms.RadioButton();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_total_area = new System.Windows.Forms.Label();
            this.pct_quadrado = new System.Windows.Forms.PictureBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.pct_triangulo = new System.Windows.Forms.PictureBox();
            this.pct_retangulo = new System.Windows.Forms.PictureBox();
            this.pct_circulo = new System.Windows.Forms.PictureBox();
            this.pct_trapezio = new System.Windows.Forms.PictureBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_totalArea = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.grb_figuras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_quadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_retangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_circulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_trapezio)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_figuras
            // 
            this.grb_figuras.Controls.Add(this.rdb_circulo);
            this.grb_figuras.Controls.Add(this.rdb_trpezio);
            this.grb_figuras.Controls.Add(this.rdb_triangulo);
            this.grb_figuras.Controls.Add(this.rdb_retangulo);
            this.grb_figuras.Controls.Add(this.rdb_quadrado);
            this.grb_figuras.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_figuras.ForeColor = System.Drawing.Color.Gold;
            this.grb_figuras.Location = new System.Drawing.Point(15, 32);
            this.grb_figuras.Name = "grb_figuras";
            this.grb_figuras.Size = new System.Drawing.Size(142, 192);
            this.grb_figuras.TabIndex = 0;
            this.grb_figuras.TabStop = false;
            this.grb_figuras.Text = "Figuras";
            // 
            // rdb_circulo
            // 
            this.rdb_circulo.AutoSize = true;
            this.rdb_circulo.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_circulo.Location = new System.Drawing.Point(18, 149);
            this.rdb_circulo.Name = "rdb_circulo";
            this.rdb_circulo.Size = new System.Drawing.Size(88, 22);
            this.rdb_circulo.TabIndex = 5;
            this.rdb_circulo.TabStop = true;
            this.rdb_circulo.Text = "Círculo";
            this.rdb_circulo.UseVisualStyleBackColor = true;
            this.rdb_circulo.CheckedChanged += new System.EventHandler(this.rdb_circulo_CheckedChanged);
            // 
            // rdb_trpezio
            // 
            this.rdb_trpezio.AutoSize = true;
            this.rdb_trpezio.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_trpezio.Location = new System.Drawing.Point(18, 121);
            this.rdb_trpezio.Name = "rdb_trpezio";
            this.rdb_trpezio.Size = new System.Drawing.Size(101, 22);
            this.rdb_trpezio.TabIndex = 4;
            this.rdb_trpezio.TabStop = true;
            this.rdb_trpezio.Text = "Trapézio";
            this.rdb_trpezio.UseVisualStyleBackColor = true;
            this.rdb_trpezio.CheckedChanged += new System.EventHandler(this.rdb_trpezio_CheckedChanged);
            // 
            // rdb_triangulo
            // 
            this.rdb_triangulo.AutoSize = true;
            this.rdb_triangulo.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_triangulo.Location = new System.Drawing.Point(18, 93);
            this.rdb_triangulo.Name = "rdb_triangulo";
            this.rdb_triangulo.Size = new System.Drawing.Size(112, 22);
            this.rdb_triangulo.TabIndex = 3;
            this.rdb_triangulo.TabStop = true;
            this.rdb_triangulo.Text = "Triângulo";
            this.rdb_triangulo.UseVisualStyleBackColor = true;
            this.rdb_triangulo.CheckedChanged += new System.EventHandler(this.rdb_triangulo_CheckedChanged);
            // 
            // rdb_retangulo
            // 
            this.rdb_retangulo.AutoSize = true;
            this.rdb_retangulo.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_retangulo.Location = new System.Drawing.Point(18, 65);
            this.rdb_retangulo.Name = "rdb_retangulo";
            this.rdb_retangulo.Size = new System.Drawing.Size(117, 22);
            this.rdb_retangulo.TabIndex = 2;
            this.rdb_retangulo.TabStop = true;
            this.rdb_retangulo.Text = "Retângulo";
            this.rdb_retangulo.UseVisualStyleBackColor = true;
            this.rdb_retangulo.CheckedChanged += new System.EventHandler(this.rdb_retangulo_CheckedChanged);
            // 
            // rdb_quadrado
            // 
            this.rdb_quadrado.AutoSize = true;
            this.rdb_quadrado.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_quadrado.Location = new System.Drawing.Point(20, 37);
            this.rdb_quadrado.Name = "rdb_quadrado";
            this.rdb_quadrado.Size = new System.Drawing.Size(110, 22);
            this.rdb_quadrado.TabIndex = 1;
            this.rdb_quadrado.TabStop = true;
            this.rdb_quadrado.Text = "Quadrado";
            this.rdb_quadrado.UseVisualStyleBackColor = true;
            this.rdb_quadrado.CheckedChanged += new System.EventHandler(this.rdb_quadrado_CheckedChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Blue;
            this.btn_limpar.Location = new System.Drawing.Point(166, 288);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(382, 288);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.White;
            this.btn_calcular.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.Gold;
            this.btn_calcular.Location = new System.Drawing.Point(382, 202);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(89, 27);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_total_area
            // 
            this.lbl_total_area.AutoSize = true;
            this.lbl_total_area.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_area.ForeColor = System.Drawing.Color.Gold;
            this.lbl_total_area.Location = new System.Drawing.Point(163, 256);
            this.lbl_total_area.Name = "lbl_total_area";
            this.lbl_total_area.Size = new System.Drawing.Size(109, 18);
            this.lbl_total_area.TabIndex = 4;
            this.lbl_total_area.Text = "Total área:";
            // 
            // pct_quadrado
            // 
            this.pct_quadrado.Image = ((System.Drawing.Image)(resources.GetObject("pct_quadrado.Image")));
            this.pct_quadrado.Location = new System.Drawing.Point(233, 12);
            this.pct_quadrado.Name = "pct_quadrado";
            this.pct_quadrado.Size = new System.Drawing.Size(128, 122);
            this.pct_quadrado.TabIndex = 6;
            this.pct_quadrado.TabStop = false;
            this.pct_quadrado.Visible = false;
            this.pct_quadrado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.Gold;
            this.lbl_n1.Location = new System.Drawing.Point(163, 157);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(55, 15);
            this.lbl_n1.TabIndex = 7;
            this.lbl_n1.Text = "label1";
            this.lbl_n1.Visible = false;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.Gold;
            this.lbl_n2.Location = new System.Drawing.Point(163, 186);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(55, 15);
            this.lbl_n2.TabIndex = 8;
            this.lbl_n2.Text = "label2";
            this.lbl_n2.Visible = false;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.ForeColor = System.Drawing.Color.Gold;
            this.lbl_n3.Location = new System.Drawing.Point(163, 214);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(55, 15);
            this.lbl_n3.TabIndex = 9;
            this.lbl_n3.Text = "label3";
            this.lbl_n3.Visible = false;
            // 
            // pct_triangulo
            // 
            this.pct_triangulo.BackColor = System.Drawing.Color.White;
            this.pct_triangulo.Image = ((System.Drawing.Image)(resources.GetObject("pct_triangulo.Image")));
            this.pct_triangulo.Location = new System.Drawing.Point(233, 12);
            this.pct_triangulo.Name = "pct_triangulo";
            this.pct_triangulo.Size = new System.Drawing.Size(128, 122);
            this.pct_triangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_triangulo.TabIndex = 10;
            this.pct_triangulo.TabStop = false;
            this.pct_triangulo.Visible = false;
            // 
            // pct_retangulo
            // 
            this.pct_retangulo.Image = ((System.Drawing.Image)(resources.GetObject("pct_retangulo.Image")));
            this.pct_retangulo.Location = new System.Drawing.Point(214, 22);
            this.pct_retangulo.Name = "pct_retangulo";
            this.pct_retangulo.Size = new System.Drawing.Size(158, 97);
            this.pct_retangulo.TabIndex = 11;
            this.pct_retangulo.TabStop = false;
            this.pct_retangulo.Visible = false;
            // 
            // pct_circulo
            // 
            this.pct_circulo.Image = ((System.Drawing.Image)(resources.GetObject("pct_circulo.Image")));
            this.pct_circulo.Location = new System.Drawing.Point(233, 12);
            this.pct_circulo.Name = "pct_circulo";
            this.pct_circulo.Size = new System.Drawing.Size(113, 107);
            this.pct_circulo.TabIndex = 12;
            this.pct_circulo.TabStop = false;
            this.pct_circulo.Visible = false;
            // 
            // pct_trapezio
            // 
            this.pct_trapezio.Image = ((System.Drawing.Image)(resources.GetObject("pct_trapezio.Image")));
            this.pct_trapezio.Location = new System.Drawing.Point(224, 22);
            this.pct_trapezio.Name = "pct_trapezio";
            this.pct_trapezio.Size = new System.Drawing.Size(148, 97);
            this.pct_trapezio.TabIndex = 13;
            this.pct_trapezio.TabStop = false;
            this.pct_trapezio.Visible = false;
            // 
            // txt_n1
            // 
            this.txt_n1.ForeColor = System.Drawing.Color.Red;
            this.txt_n1.Location = new System.Drawing.Point(261, 155);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 14;
            this.txt_n1.Visible = false;
            // 
            // txt_n2
            // 
            this.txt_n2.ForeColor = System.Drawing.Color.Red;
            this.txt_n2.Location = new System.Drawing.Point(261, 181);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 15;
            this.txt_n2.Visible = false;
            // 
            // txt_n3
            // 
            this.txt_n3.ForeColor = System.Drawing.Color.Red;
            this.txt_n3.Location = new System.Drawing.Point(261, 209);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(100, 20);
            this.txt_n3.TabIndex = 16;
            this.txt_n3.Visible = false;
            // 
            // lbl_totalArea
            // 
            this.lbl_totalArea.BackColor = System.Drawing.Color.White;
            this.lbl_totalArea.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalArea.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalArea.Location = new System.Drawing.Point(278, 251);
            this.lbl_totalArea.Name = "lbl_totalArea";
            this.lbl_totalArea.Size = new System.Drawing.Size(83, 23);
            this.lbl_totalArea.TabIndex = 17;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Black;
            this.lbl2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Gold;
            this.lbl2.Location = new System.Drawing.Point(179, 229);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(167, 23);
            this.lbl2.TabIndex = 18;
            this.lbl2.Visible = false;
            // 
            // frm_areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(489, 335);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl_totalArea);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.pct_trapezio);
            this.Controls.Add(this.pct_circulo);
            this.Controls.Add(this.pct_retangulo);
            this.Controls.Add(this.pct_triangulo);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.pct_quadrado);
            this.Controls.Add(this.lbl_total_area);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.grb_figuras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_areas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de áreas de figuras geométricas";
            this.grb_figuras.ResumeLayout(false);
            this.grb_figuras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_quadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_retangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_circulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_trapezio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_figuras;
        private System.Windows.Forms.RadioButton rdb_circulo;
        private System.Windows.Forms.RadioButton rdb_trpezio;
        private System.Windows.Forms.RadioButton rdb_triangulo;
        private System.Windows.Forms.RadioButton rdb_retangulo;
        private System.Windows.Forms.RadioButton rdb_quadrado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_total_area;
        private System.Windows.Forms.PictureBox pct_quadrado;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.PictureBox pct_triangulo;
        private System.Windows.Forms.PictureBox pct_retangulo;
        private System.Windows.Forms.PictureBox pct_circulo;
        private System.Windows.Forms.PictureBox pct_trapezio;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_totalArea;
        private System.Windows.Forms.Label lbl2;
    }
}

