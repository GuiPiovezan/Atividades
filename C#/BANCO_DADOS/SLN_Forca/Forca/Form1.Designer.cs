namespace Forca
{
    partial class frm_forca
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_palavra = new System.Windows.Forms.Label();
            this.txt_palavra = new System.Windows.Forms.TextBox();
            this.btn_ok_palavra = new System.Windows.Forms.Button();
            this.gpb_palavra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.lbl_vetor = new System.Windows.Forms.Label();
            this.lbl_qtd = new System.Windows.Forms.Label();
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_o = new System.Windows.Forms.Button();
            this.btn_n = new System.Windows.Forms.Button();
            this.btn_m = new System.Windows.Forms.Button();
            this.btn_l = new System.Windows.Forms.Button();
            this.btn_k = new System.Windows.Forms.Button();
            this.btn_j = new System.Windows.Forms.Button();
            this.btn_p = new System.Windows.Forms.Button();
            this.btn_h = new System.Windows.Forms.Button();
            this.btn_g = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_y = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_w = new System.Windows.Forms.Button();
            this.btn_v = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_t = new System.Windows.Forms.Button();
            this.btn_s = new System.Windows.Forms.Button();
            this.btn_q = new System.Windows.Forms.Button();
            this.btn_z = new System.Windows.Forms.Button();
            this.btn_r = new System.Windows.Forms.Button();
            this.btn_traco = new System.Windows.Forms.Button();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_f = new System.Windows.Forms.Button();
            this.gpb_teclado = new System.Windows.Forms.GroupBox();
            this.btn_nj = new System.Windows.Forms.Button();
            this.pct_lose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dica = new System.Windows.Forms.TextBox();
            this.lbl_dica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb_palavra.SuspendLayout();
            this.gpb_teclado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_lose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lbl_palavra
            // 
            this.lbl_palavra.AutoSize = true;
            this.lbl_palavra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_palavra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_palavra.ForeColor = System.Drawing.Color.Black;
            this.lbl_palavra.Location = new System.Drawing.Point(17, 25);
            this.lbl_palavra.Name = "lbl_palavra";
            this.lbl_palavra.Size = new System.Drawing.Size(190, 26);
            this.lbl_palavra.TabIndex = 1;
            this.lbl_palavra.Text = "Digite uma palavra:";
            // 
            // txt_palavra
            // 
            this.txt_palavra.CausesValidation = false;
            this.txt_palavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palavra.Location = new System.Drawing.Point(17, 70);
            this.txt_palavra.Name = "txt_palavra";
            this.txt_palavra.Size = new System.Drawing.Size(190, 26);
            this.txt_palavra.TabIndex = 2;
            this.txt_palavra.UseSystemPasswordChar = true;
            // 
            // btn_ok_palavra
            // 
            this.btn_ok_palavra.AutoSize = true;
            this.btn_ok_palavra.Location = new System.Drawing.Point(263, 84);
            this.btn_ok_palavra.Name = "btn_ok_palavra";
            this.btn_ok_palavra.Size = new System.Drawing.Size(49, 34);
            this.btn_ok_palavra.TabIndex = 3;
            this.btn_ok_palavra.Text = "OK";
            this.btn_ok_palavra.UseVisualStyleBackColor = true;
            this.btn_ok_palavra.Click += new System.EventHandler(this.btn_ok_palavra_Click);
            // 
            // gpb_palavra
            // 
            this.gpb_palavra.Controls.Add(this.txt_dica);
            this.gpb_palavra.Controls.Add(this.label2);
            this.gpb_palavra.Controls.Add(this.btn_ok_palavra);
            this.gpb_palavra.Controls.Add(this.txt_palavra);
            this.gpb_palavra.Controls.Add(this.lbl_palavra);
            this.gpb_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.gpb_palavra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gpb_palavra.Location = new System.Drawing.Point(440, 44);
            this.gpb_palavra.Name = "gpb_palavra";
            this.gpb_palavra.Size = new System.Drawing.Size(360, 175);
            this.gpb_palavra.TabIndex = 4;
            this.gpb_palavra.TabStop = false;
            this.gpb_palavra.Text = "Palavra";
            this.gpb_palavra.Visible = false;
            this.gpb_palavra.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(310, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "JOGO DA FORCA";
            // 
            // txt_letra
            // 
            this.txt_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra.Location = new System.Drawing.Point(843, 425);
            this.txt_letra.MaxLength = 1;
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(35, 26);
            this.txt_letra.TabIndex = 2;
            this.txt_letra.Visible = false;
            // 
            // lbl_vetor
            // 
            this.lbl_vetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_vetor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_vetor.Location = new System.Drawing.Point(553, 367);
            this.lbl_vetor.Name = "lbl_vetor";
            this.lbl_vetor.Size = new System.Drawing.Size(247, 30);
            this.lbl_vetor.TabIndex = 6;
            this.lbl_vetor.Visible = false;
            // 
            // lbl_qtd
            // 
            this.lbl_qtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_qtd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_qtd.Location = new System.Drawing.Point(440, 366);
            this.lbl_qtd.Name = "lbl_qtd";
            this.lbl_qtd.Size = new System.Drawing.Size(107, 30);
            this.lbl_qtd.TabIndex = 7;
            this.lbl_qtd.Visible = false;
            this.lbl_qtd.Click += new System.EventHandler(this.lbl_qtd_Click);
            // 
            // btn_a
            // 
            this.btn_a.AutoSize = true;
            this.btn_a.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a.Location = new System.Drawing.Point(6, 28);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(28, 30);
            this.btn_a.TabIndex = 8;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_b
            // 
            this.btn_b.AutoSize = true;
            this.btn_b.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b.Location = new System.Drawing.Point(40, 28);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(28, 30);
            this.btn_b.TabIndex = 9;
            this.btn_b.Text = "B";
            this.btn_b.UseVisualStyleBackColor = true;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            // 
            // btn_o
            // 
            this.btn_o.AutoSize = true;
            this.btn_o.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_o.Location = new System.Drawing.Point(213, 64);
            this.btn_o.Name = "btn_o";
            this.btn_o.Size = new System.Drawing.Size(29, 30);
            this.btn_o.TabIndex = 10;
            this.btn_o.Text = "O";
            this.btn_o.UseVisualStyleBackColor = true;
            this.btn_o.Click += new System.EventHandler(this.btn_o_Click);
            // 
            // btn_n
            // 
            this.btn_n.AutoSize = true;
            this.btn_n.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n.Location = new System.Drawing.Point(108, 64);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(28, 30);
            this.btn_n.TabIndex = 11;
            this.btn_n.Text = "N";
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.btn_n_Click);
            // 
            // btn_m
            // 
            this.btn_m.AutoSize = true;
            this.btn_m.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m.Location = new System.Drawing.Point(72, 64);
            this.btn_m.Name = "btn_m";
            this.btn_m.Size = new System.Drawing.Size(30, 30);
            this.btn_m.TabIndex = 12;
            this.btn_m.Text = "M";
            this.btn_m.UseVisualStyleBackColor = true;
            this.btn_m.Click += new System.EventHandler(this.btn_m_Click);
            // 
            // btn_l
            // 
            this.btn_l.AutoSize = true;
            this.btn_l.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_l.Location = new System.Drawing.Point(40, 64);
            this.btn_l.Name = "btn_l";
            this.btn_l.Size = new System.Drawing.Size(28, 30);
            this.btn_l.TabIndex = 13;
            this.btn_l.Text = "L";
            this.btn_l.UseVisualStyleBackColor = true;
            this.btn_l.Click += new System.EventHandler(this.btn_l_Click);
            // 
            // btn_k
            // 
            this.btn_k.AutoSize = true;
            this.btn_k.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_k.Location = new System.Drawing.Point(6, 64);
            this.btn_k.Name = "btn_k";
            this.btn_k.Size = new System.Drawing.Size(28, 30);
            this.btn_k.TabIndex = 14;
            this.btn_k.Text = "K";
            this.btn_k.UseVisualStyleBackColor = true;
            this.btn_k.Click += new System.EventHandler(this.btn_k_Click);
            // 
            // btn_j
            // 
            this.btn_j.AutoSize = true;
            this.btn_j.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_j.Location = new System.Drawing.Point(317, 28);
            this.btn_j.Name = "btn_j";
            this.btn_j.Size = new System.Drawing.Size(28, 30);
            this.btn_j.TabIndex = 15;
            this.btn_j.Text = "J";
            this.btn_j.UseVisualStyleBackColor = true;
            this.btn_j.Click += new System.EventHandler(this.btn_j_Click);
            // 
            // btn_p
            // 
            this.btn_p.AutoSize = true;
            this.btn_p.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_p.Location = new System.Drawing.Point(249, 64);
            this.btn_p.Name = "btn_p";
            this.btn_p.Size = new System.Drawing.Size(28, 30);
            this.btn_p.TabIndex = 16;
            this.btn_p.Text = "P";
            this.btn_p.UseVisualStyleBackColor = true;
            this.btn_p.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_h
            // 
            this.btn_h.AutoSize = true;
            this.btn_h.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_h.Location = new System.Drawing.Point(249, 28);
            this.btn_h.Name = "btn_h";
            this.btn_h.Size = new System.Drawing.Size(28, 30);
            this.btn_h.TabIndex = 17;
            this.btn_h.Text = "H";
            this.btn_h.UseVisualStyleBackColor = true;
            this.btn_h.Click += new System.EventHandler(this.btn_h_Click);
            // 
            // btn_g
            // 
            this.btn_g.AutoSize = true;
            this.btn_g.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_g.Location = new System.Drawing.Point(210, 28);
            this.btn_g.Name = "btn_g";
            this.btn_g.Size = new System.Drawing.Size(29, 30);
            this.btn_g.TabIndex = 18;
            this.btn_g.Text = "G";
            this.btn_g.UseVisualStyleBackColor = true;
            this.btn_g.Click += new System.EventHandler(this.btn_g_Click);
            // 
            // btn_e
            // 
            this.btn_e.AutoSize = true;
            this.btn_e.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_e.Location = new System.Drawing.Point(142, 28);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(28, 30);
            this.btn_e.TabIndex = 20;
            this.btn_e.Text = "E";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_d
            // 
            this.btn_d.AutoSize = true;
            this.btn_d.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.Location = new System.Drawing.Point(108, 28);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(28, 30);
            this.btn_d.TabIndex = 21;
            this.btn_d.Text = "D";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_c
            // 
            this.btn_c.AutoSize = true;
            this.btn_c.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(74, 28);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(28, 30);
            this.btn_c.TabIndex = 22;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_y
            // 
            this.btn_y.AutoSize = true;
            this.btn_y.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_y.Location = new System.Drawing.Point(284, 100);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(28, 30);
            this.btn_y.TabIndex = 23;
            this.btn_y.Text = "Y";
            this.btn_y.UseVisualStyleBackColor = true;
            this.btn_y.Click += new System.EventHandler(this.btn_y_Click);
            // 
            // btn_x
            // 
            this.btn_x.AutoSize = true;
            this.btn_x.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.Location = new System.Drawing.Point(249, 100);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(28, 30);
            this.btn_x.TabIndex = 24;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // btn_w
            // 
            this.btn_w.AutoSize = true;
            this.btn_w.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_w.Location = new System.Drawing.Point(213, 100);
            this.btn_w.Name = "btn_w";
            this.btn_w.Size = new System.Drawing.Size(30, 30);
            this.btn_w.TabIndex = 25;
            this.btn_w.Text = "W";
            this.btn_w.UseVisualStyleBackColor = true;
            this.btn_w.Click += new System.EventHandler(this.btn_w_Click);
            // 
            // btn_v
            // 
            this.btn_v.AutoSize = true;
            this.btn_v.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_v.Location = new System.Drawing.Point(108, 100);
            this.btn_v.Name = "btn_v";
            this.btn_v.Size = new System.Drawing.Size(28, 30);
            this.btn_v.TabIndex = 26;
            this.btn_v.Text = "V";
            this.btn_v.UseVisualStyleBackColor = true;
            this.btn_v.Click += new System.EventHandler(this.btn_v_Click);
            // 
            // btn_u
            // 
            this.btn_u.AutoSize = true;
            this.btn_u.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_u.Location = new System.Drawing.Point(71, 100);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(28, 30);
            this.btn_u.TabIndex = 27;
            this.btn_u.Text = "U";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_t
            // 
            this.btn_t.AutoSize = true;
            this.btn_t.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t.Location = new System.Drawing.Point(40, 100);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(28, 30);
            this.btn_t.TabIndex = 28;
            this.btn_t.Text = "T";
            this.btn_t.UseVisualStyleBackColor = true;
            this.btn_t.Click += new System.EventHandler(this.btn_t_Click);
            // 
            // btn_s
            // 
            this.btn_s.AutoSize = true;
            this.btn_s.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s.Location = new System.Drawing.Point(6, 100);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(28, 30);
            this.btn_s.TabIndex = 29;
            this.btn_s.Text = "S";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // btn_q
            // 
            this.btn_q.AutoSize = true;
            this.btn_q.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_q.Location = new System.Drawing.Point(283, 64);
            this.btn_q.Name = "btn_q";
            this.btn_q.Size = new System.Drawing.Size(29, 30);
            this.btn_q.TabIndex = 30;
            this.btn_q.Text = "Q";
            this.btn_q.UseVisualStyleBackColor = true;
            this.btn_q.Click += new System.EventHandler(this.btn_q_Click);
            // 
            // btn_z
            // 
            this.btn_z.AutoSize = true;
            this.btn_z.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_z.Location = new System.Drawing.Point(317, 100);
            this.btn_z.Name = "btn_z";
            this.btn_z.Size = new System.Drawing.Size(28, 30);
            this.btn_z.TabIndex = 31;
            this.btn_z.Text = "Z";
            this.btn_z.UseVisualStyleBackColor = true;
            this.btn_z.Click += new System.EventHandler(this.btn_z_Click);
            // 
            // btn_r
            // 
            this.btn_r.AutoSize = true;
            this.btn_r.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_r.Location = new System.Drawing.Point(317, 64);
            this.btn_r.Name = "btn_r";
            this.btn_r.Size = new System.Drawing.Size(28, 30);
            this.btn_r.TabIndex = 32;
            this.btn_r.Text = "R";
            this.btn_r.UseVisualStyleBackColor = true;
            this.btn_r.Click += new System.EventHandler(this.btn_r_Click);
            // 
            // btn_traco
            // 
            this.btn_traco.AutoSize = true;
            this.btn_traco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traco.Location = new System.Drawing.Point(142, 82);
            this.btn_traco.Name = "btn_traco";
            this.btn_traco.Size = new System.Drawing.Size(64, 30);
            this.btn_traco.TabIndex = 33;
            this.btn_traco.Text = "SPACE";
            this.btn_traco.UseVisualStyleBackColor = true;
            this.btn_traco.Click += new System.EventHandler(this.btn_traco_Click);
            // 
            // btn_i
            // 
            this.btn_i.AutoSize = true;
            this.btn_i.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_i.Location = new System.Drawing.Point(283, 28);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(28, 30);
            this.btn_i.TabIndex = 34;
            this.btn_i.Text = "I";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // btn_f
            // 
            this.btn_f.AutoSize = true;
            this.btn_f.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_f.Location = new System.Drawing.Point(176, 28);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(28, 30);
            this.btn_f.TabIndex = 35;
            this.btn_f.Text = "F";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // gpb_teclado
            // 
            this.gpb_teclado.Controls.Add(this.btn_c);
            this.gpb_teclado.Controls.Add(this.btn_f);
            this.gpb_teclado.Controls.Add(this.btn_a);
            this.gpb_teclado.Controls.Add(this.btn_i);
            this.gpb_teclado.Controls.Add(this.btn_b);
            this.gpb_teclado.Controls.Add(this.btn_traco);
            this.gpb_teclado.Controls.Add(this.btn_o);
            this.gpb_teclado.Controls.Add(this.btn_r);
            this.gpb_teclado.Controls.Add(this.btn_n);
            this.gpb_teclado.Controls.Add(this.btn_z);
            this.gpb_teclado.Controls.Add(this.btn_m);
            this.gpb_teclado.Controls.Add(this.btn_q);
            this.gpb_teclado.Controls.Add(this.btn_l);
            this.gpb_teclado.Controls.Add(this.btn_s);
            this.gpb_teclado.Controls.Add(this.btn_k);
            this.gpb_teclado.Controls.Add(this.btn_t);
            this.gpb_teclado.Controls.Add(this.btn_j);
            this.gpb_teclado.Controls.Add(this.btn_u);
            this.gpb_teclado.Controls.Add(this.btn_p);
            this.gpb_teclado.Controls.Add(this.btn_v);
            this.gpb_teclado.Controls.Add(this.btn_h);
            this.gpb_teclado.Controls.Add(this.btn_w);
            this.gpb_teclado.Controls.Add(this.btn_g);
            this.gpb_teclado.Controls.Add(this.btn_x);
            this.gpb_teclado.Controls.Add(this.btn_e);
            this.gpb_teclado.Controls.Add(this.btn_y);
            this.gpb_teclado.Controls.Add(this.btn_d);
            this.gpb_teclado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.gpb_teclado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gpb_teclado.Location = new System.Drawing.Point(440, 225);
            this.gpb_teclado.Name = "gpb_teclado";
            this.gpb_teclado.Size = new System.Drawing.Size(360, 139);
            this.gpb_teclado.TabIndex = 36;
            this.gpb_teclado.TabStop = false;
            this.gpb_teclado.Text = "TECLADO";
            this.gpb_teclado.Visible = false;
            this.gpb_teclado.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btn_nj
            // 
            this.btn_nj.AutoSize = true;
            this.btn_nj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btn_nj.Location = new System.Drawing.Point(352, 355);
            this.btn_nj.Name = "btn_nj";
            this.btn_nj.Size = new System.Drawing.Size(144, 34);
            this.btn_nj.TabIndex = 4;
            this.btn_nj.Text = "NOVO JOGO";
            this.btn_nj.UseVisualStyleBackColor = true;
            this.btn_nj.Click += new System.EventHandler(this.btn_nj_Click);
            // 
            // pct_lose
            // 
            this.pct_lose.BackgroundImage = global::Forca.Properties.Resources.cd_cover;
            this.pct_lose.Location = new System.Drawing.Point(8, 0);
            this.pct_lose.Name = "pct_lose";
            this.pct_lose.Size = new System.Drawing.Size(807, 396);
            this.pct_lose.TabIndex = 37;
            this.pct_lose.TabStop = false;
            this.pct_lose.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Dica:";
            // 
            // txt_dica
            // 
            this.txt_dica.CausesValidation = false;
            this.txt_dica.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_dica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dica.Location = new System.Drawing.Point(14, 143);
            this.txt_dica.Name = "txt_dica";
            this.txt_dica.Size = new System.Drawing.Size(190, 26);
            this.txt_dica.TabIndex = 39;
            // 
            // lbl_dica
            // 
            this.lbl_dica.BackColor = System.Drawing.Color.Red;
            this.lbl_dica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_dica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_dica.ForeColor = System.Drawing.Color.Black;
            this.lbl_dica.Location = new System.Drawing.Point(29, 355);
            this.lbl_dica.Name = "lbl_dica";
            this.lbl_dica.Size = new System.Drawing.Size(292, 26);
            this.lbl_dica.TabIndex = 40;
            this.lbl_dica.Visible = false;
            // 
            // frm_forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(811, 406);
            this.Controls.Add(this.lbl_dica);
            this.Controls.Add(this.btn_nj);
            this.Controls.Add(this.gpb_teclado);
            this.Controls.Add(this.txt_letra);
            this.Controls.Add(this.lbl_qtd);
            this.Controls.Add(this.lbl_vetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_palavra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pct_lose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORCA";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb_palavra.ResumeLayout(false);
            this.gpb_palavra.PerformLayout();
            this.gpb_teclado.ResumeLayout(false);
            this.gpb_teclado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_lose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_palavra;
        private System.Windows.Forms.TextBox txt_palavra;
        private System.Windows.Forms.Button btn_ok_palavra;
        private System.Windows.Forms.GroupBox gpb_palavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_letra;
        private System.Windows.Forms.Label lbl_vetor;
        private System.Windows.Forms.Label lbl_qtd;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_o;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Button btn_m;
        private System.Windows.Forms.Button btn_l;
        private System.Windows.Forms.Button btn_k;
        private System.Windows.Forms.Button btn_j;
        private System.Windows.Forms.Button btn_p;
        private System.Windows.Forms.Button btn_h;
        private System.Windows.Forms.Button btn_g;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_y;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_w;
        private System.Windows.Forms.Button btn_v;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Button btn_q;
        private System.Windows.Forms.Button btn_z;
        private System.Windows.Forms.Button btn_r;
        private System.Windows.Forms.Button btn_traco;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.GroupBox gpb_teclado;
        private System.Windows.Forms.Button btn_nj;
        private System.Windows.Forms.PictureBox pct_lose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dica;
        private System.Windows.Forms.Label lbl_dica;
    }
}

