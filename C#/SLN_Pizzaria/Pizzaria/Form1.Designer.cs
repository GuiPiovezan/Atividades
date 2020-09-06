namespace Pizzaria
{
    partial class frm_pizzaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pizzaria));
            this.grp_tamanho = new System.Windows.Forms.GroupBox();
            this.rdb_brotinho = new System.Windows.Forms.RadioButton();
            this.rdb_pequena = new System.Windows.Forms.RadioButton();
            this.rdb_media = new System.Windows.Forms.RadioButton();
            this.rdb_grande = new System.Windows.Forms.RadioButton();
            this.gro_sabor = new System.Windows.Forms.GroupBox();
            this.rdb_portuguesa = new System.Windows.Forms.RadioButton();
            this.rdb_frango = new System.Windows.Forms.RadioButton();
            this.rdb_calabresa = new System.Windows.Forms.RadioButton();
            this.rdb_mucarela = new System.Windows.Forms.RadioButton();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.btn_npedido = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.chk_crememilho = new System.Windows.Forms.CheckBox();
            this.grp_complementos = new System.Windows.Forms.GroupBox();
            this.chk_goiabada = new System.Windows.Forms.CheckBox();
            this.chk_banana = new System.Windows.Forms.CheckBox();
            this.chk_picles = new System.Windows.Forms.CheckBox();
            this.chk_cheddar = new System.Windows.Forms.CheckBox();
            this.chk_cremeazeitona = new System.Windows.Forms.CheckBox();
            this.grp_tamanho.SuspendLayout();
            this.gro_sabor.SuspendLayout();
            this.grp_complementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tamanho
            // 
            this.grp_tamanho.BackColor = System.Drawing.Color.Transparent;
            this.grp_tamanho.Controls.Add(this.rdb_brotinho);
            this.grp_tamanho.Controls.Add(this.rdb_pequena);
            this.grp_tamanho.Controls.Add(this.rdb_media);
            this.grp_tamanho.Controls.Add(this.rdb_grande);
            this.grp_tamanho.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_tamanho.ForeColor = System.Drawing.Color.Lime;
            this.grp_tamanho.Location = new System.Drawing.Point(12, 21);
            this.grp_tamanho.Name = "grp_tamanho";
            this.grp_tamanho.Size = new System.Drawing.Size(156, 233);
            this.grp_tamanho.TabIndex = 1;
            this.grp_tamanho.TabStop = false;
            this.grp_tamanho.Text = "Opções";
            this.grp_tamanho.Enter += new System.EventHandler(this.grp_tamanho_Enter);
            // 
            // rdb_brotinho
            // 
            this.rdb_brotinho.AutoSize = true;
            this.rdb_brotinho.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_brotinho.ForeColor = System.Drawing.Color.Red;
            this.rdb_brotinho.Location = new System.Drawing.Point(19, 164);
            this.rdb_brotinho.Name = "rdb_brotinho";
            this.rdb_brotinho.Size = new System.Drawing.Size(131, 19);
            this.rdb_brotinho.TabIndex = 3;
            this.rdb_brotinho.TabStop = true;
            this.rdb_brotinho.Text = "Brotinho R$3,00";
            this.rdb_brotinho.UseVisualStyleBackColor = true;
            this.rdb_brotinho.CheckedChanged += new System.EventHandler(this.rdb_brotinho_CheckedChanged);
            // 
            // rdb_pequena
            // 
            this.rdb_pequena.AutoSize = true;
            this.rdb_pequena.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_pequena.ForeColor = System.Drawing.Color.Red;
            this.rdb_pequena.Location = new System.Drawing.Point(19, 121);
            this.rdb_pequena.Name = "rdb_pequena";
            this.rdb_pequena.Size = new System.Drawing.Size(129, 19);
            this.rdb_pequena.TabIndex = 2;
            this.rdb_pequena.TabStop = true;
            this.rdb_pequena.Text = "Pequena R$5,00";
            this.rdb_pequena.UseVisualStyleBackColor = true;
            this.rdb_pequena.CheckedChanged += new System.EventHandler(this.rdb_pequena_CheckedChanged);
            // 
            // rdb_media
            // 
            this.rdb_media.AutoSize = true;
            this.rdb_media.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_media.ForeColor = System.Drawing.Color.Red;
            this.rdb_media.Location = new System.Drawing.Point(19, 76);
            this.rdb_media.Name = "rdb_media";
            this.rdb_media.Size = new System.Drawing.Size(111, 19);
            this.rdb_media.TabIndex = 1;
            this.rdb_media.TabStop = true;
            this.rdb_media.Text = "Média R$7,00";
            this.rdb_media.UseVisualStyleBackColor = true;
            this.rdb_media.CheckedChanged += new System.EventHandler(this.rdb_media_CheckedChanged);
            // 
            // rdb_grande
            // 
            this.rdb_grande.AutoSize = true;
            this.rdb_grande.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_grande.ForeColor = System.Drawing.Color.Red;
            this.rdb_grande.Location = new System.Drawing.Point(19, 42);
            this.rdb_grande.Name = "rdb_grande";
            this.rdb_grande.Size = new System.Drawing.Size(130, 19);
            this.rdb_grande.TabIndex = 0;
            this.rdb_grande.TabStop = true;
            this.rdb_grande.Text = "Grande R$10,00";
            this.rdb_grande.UseVisualStyleBackColor = true;
            this.rdb_grande.CheckedChanged += new System.EventHandler(this.rdb_grande_CheckedChanged);
            // 
            // gro_sabor
            // 
            this.gro_sabor.BackColor = System.Drawing.Color.Transparent;
            this.gro_sabor.Controls.Add(this.rdb_portuguesa);
            this.gro_sabor.Controls.Add(this.rdb_frango);
            this.gro_sabor.Controls.Add(this.rdb_calabresa);
            this.gro_sabor.Controls.Add(this.rdb_mucarela);
            this.gro_sabor.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro_sabor.ForeColor = System.Drawing.Color.DarkBlue;
            this.gro_sabor.Location = new System.Drawing.Point(191, 21);
            this.gro_sabor.Name = "gro_sabor";
            this.gro_sabor.Size = new System.Drawing.Size(154, 233);
            this.gro_sabor.TabIndex = 2;
            this.gro_sabor.TabStop = false;
            this.gro_sabor.Text = "Sabores";
            // 
            // rdb_portuguesa
            // 
            this.rdb_portuguesa.AutoSize = true;
            this.rdb_portuguesa.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_portuguesa.ForeColor = System.Drawing.Color.White;
            this.rdb_portuguesa.Location = new System.Drawing.Point(5, 164);
            this.rdb_portuguesa.Name = "rdb_portuguesa";
            this.rdb_portuguesa.Size = new System.Drawing.Size(153, 19);
            this.rdb_portuguesa.TabIndex = 3;
            this.rdb_portuguesa.TabStop = true;
            this.rdb_portuguesa.Text = "Portuguesa R$7,00";
            this.rdb_portuguesa.UseVisualStyleBackColor = true;
            this.rdb_portuguesa.CheckedChanged += new System.EventHandler(this.rdb_portuguesa_CheckedChanged);
            // 
            // rdb_frango
            // 
            this.rdb_frango.AutoSize = true;
            this.rdb_frango.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_frango.ForeColor = System.Drawing.Color.White;
            this.rdb_frango.Location = new System.Drawing.Point(6, 118);
            this.rdb_frango.Name = "rdb_frango";
            this.rdb_frango.Size = new System.Drawing.Size(121, 19);
            this.rdb_frango.TabIndex = 2;
            this.rdb_frango.TabStop = true;
            this.rdb_frango.Text = "Frango R$5,00";
            this.rdb_frango.UseVisualStyleBackColor = true;
            this.rdb_frango.CheckedChanged += new System.EventHandler(this.rdb_frango_CheckedChanged);
            // 
            // rdb_calabresa
            // 
            this.rdb_calabresa.AutoSize = true;
            this.rdb_calabresa.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_calabresa.ForeColor = System.Drawing.Color.White;
            this.rdb_calabresa.Location = new System.Drawing.Point(5, 76);
            this.rdb_calabresa.Name = "rdb_calabresa";
            this.rdb_calabresa.Size = new System.Drawing.Size(147, 19);
            this.rdb_calabresa.TabIndex = 1;
            this.rdb_calabresa.TabStop = true;
            this.rdb_calabresa.Text = "Calabresa R$4,00";
            this.rdb_calabresa.UseVisualStyleBackColor = true;
            this.rdb_calabresa.CheckedChanged += new System.EventHandler(this.rdb_calabresa_CheckedChanged);
            // 
            // rdb_mucarela
            // 
            this.rdb_mucarela.AutoSize = true;
            this.rdb_mucarela.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mucarela.ForeColor = System.Drawing.Color.White;
            this.rdb_mucarela.Location = new System.Drawing.Point(6, 42);
            this.rdb_mucarela.Name = "rdb_mucarela";
            this.rdb_mucarela.Size = new System.Drawing.Size(140, 19);
            this.rdb_mucarela.TabIndex = 0;
            this.rdb_mucarela.TabStop = true;
            this.rdb_mucarela.Text = "Muçarela R$3,00";
            this.rdb_mucarela.UseVisualStyleBackColor = true;
            this.rdb_mucarela.CheckedChanged += new System.EventHandler(this.rdb_mucarela_CheckedChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.Blue;
            this.btn_confirmar.Location = new System.Drawing.Point(191, 298);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(126, 33);
            this.btn_confirmar.TabIndex = 0;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pedido.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_pedido.Location = new System.Drawing.Point(12, 356);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(513, 164);
            this.lbl_pedido.TabIndex = 4;
            this.lbl_pedido.Visible = false;
            // 
            // btn_npedido
            // 
            this.btn_npedido.BackColor = System.Drawing.Color.Transparent;
            this.btn_npedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_npedido.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_npedido.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_npedido.Location = new System.Drawing.Point(90, 551);
            this.btn_npedido.Name = "btn_npedido";
            this.btn_npedido.Size = new System.Drawing.Size(135, 23);
            this.btn_npedido.TabIndex = 3;
            this.btn_npedido.Text = "Novo Pedido";
            this.btn_npedido.UseVisualStyleBackColor = false;
            this.btn_npedido.Click += new System.EventHandler(this.btn_npedido_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.Red;
            this.btn_fechar.Location = new System.Drawing.Point(280, 541);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(109, 38);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // chk_crememilho
            // 
            this.chk_crememilho.AutoSize = true;
            this.chk_crememilho.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_crememilho.Location = new System.Drawing.Point(10, 42);
            this.chk_crememilho.Name = "chk_crememilho";
            this.chk_crememilho.Size = new System.Drawing.Size(127, 19);
            this.chk_crememilho.TabIndex = 5;
            this.chk_crememilho.Text = "Creme de Milho";
            this.chk_crememilho.UseVisualStyleBackColor = true;
            this.chk_crememilho.CheckedChanged += new System.EventHandler(this.chk_crememilho_CheckedChanged);
            // 
            // grp_complementos
            // 
            this.grp_complementos.BackColor = System.Drawing.Color.Transparent;
            this.grp_complementos.Controls.Add(this.chk_goiabada);
            this.grp_complementos.Controls.Add(this.chk_banana);
            this.grp_complementos.Controls.Add(this.chk_picles);
            this.grp_complementos.Controls.Add(this.chk_cheddar);
            this.grp_complementos.Controls.Add(this.chk_cremeazeitona);
            this.grp_complementos.Controls.Add(this.chk_crememilho);
            this.grp_complementos.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_complementos.ForeColor = System.Drawing.Color.DarkViolet;
            this.grp_complementos.Location = new System.Drawing.Point(361, 21);
            this.grp_complementos.Name = "grp_complementos";
            this.grp_complementos.Size = new System.Drawing.Size(161, 233);
            this.grp_complementos.TabIndex = 6;
            this.grp_complementos.TabStop = false;
            this.grp_complementos.Text = "Complementos R$2,00";
            this.grp_complementos.Enter += new System.EventHandler(this.grp_complementos_Enter);
            // 
            // chk_goiabada
            // 
            this.chk_goiabada.AutoSize = true;
            this.chk_goiabada.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_goiabada.Location = new System.Drawing.Point(10, 197);
            this.chk_goiabada.Name = "chk_goiabada";
            this.chk_goiabada.Size = new System.Drawing.Size(93, 19);
            this.chk_goiabada.TabIndex = 10;
            this.chk_goiabada.Text = "Goiabada";
            this.chk_goiabada.UseVisualStyleBackColor = true;
            this.chk_goiabada.CheckedChanged += new System.EventHandler(this.chk_goiabada_CheckedChanged);
            // 
            // chk_banana
            // 
            this.chk_banana.AutoSize = true;
            this.chk_banana.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_banana.Location = new System.Drawing.Point(10, 165);
            this.chk_banana.Name = "chk_banana";
            this.chk_banana.Size = new System.Drawing.Size(80, 19);
            this.chk_banana.TabIndex = 9;
            this.chk_banana.Text = "Banana";
            this.chk_banana.UseVisualStyleBackColor = true;
            this.chk_banana.CheckedChanged += new System.EventHandler(this.chk_banana_CheckedChanged);
            // 
            // chk_picles
            // 
            this.chk_picles.AutoSize = true;
            this.chk_picles.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_picles.Location = new System.Drawing.Point(10, 127);
            this.chk_picles.Name = "chk_picles";
            this.chk_picles.Size = new System.Drawing.Size(68, 19);
            this.chk_picles.TabIndex = 8;
            this.chk_picles.Text = "Picles";
            this.chk_picles.UseVisualStyleBackColor = true;
            this.chk_picles.CheckedChanged += new System.EventHandler(this.chk_picles_CheckedChanged);
            // 
            // chk_cheddar
            // 
            this.chk_cheddar.AutoSize = true;
            this.chk_cheddar.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_cheddar.Location = new System.Drawing.Point(10, 102);
            this.chk_cheddar.Name = "chk_cheddar";
            this.chk_cheddar.Size = new System.Drawing.Size(84, 19);
            this.chk_cheddar.TabIndex = 7;
            this.chk_cheddar.Text = "Cheddar";
            this.chk_cheddar.UseVisualStyleBackColor = true;
            this.chk_cheddar.CheckedChanged += new System.EventHandler(this.chk_cheddar_CheckedChanged);
            // 
            // chk_cremeazeitona
            // 
            this.chk_cremeazeitona.AutoSize = true;
            this.chk_cremeazeitona.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_cremeazeitona.Location = new System.Drawing.Point(10, 77);
            this.chk_cremeazeitona.Name = "chk_cremeazeitona";
            this.chk_cremeazeitona.Size = new System.Drawing.Size(154, 19);
            this.chk_cremeazeitona.TabIndex = 6;
            this.chk_cremeazeitona.Text = "Creme de Azeitona";
            this.chk_cremeazeitona.UseVisualStyleBackColor = true;
            this.chk_cremeazeitona.CheckedChanged += new System.EventHandler(this.chk_cremeazeitona_CheckedChanged);
            // 
            // frm_pizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 632);
            this.Controls.Add(this.grp_complementos);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_npedido);
            this.Controls.Add(this.lbl_pedido);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.gro_sabor);
            this.Controls.Add(this.grp_tamanho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_pizzaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria do Zé Galinha";
            this.grp_tamanho.ResumeLayout(false);
            this.grp_tamanho.PerformLayout();
            this.gro_sabor.ResumeLayout(false);
            this.gro_sabor.PerformLayout();
            this.grp_complementos.ResumeLayout(false);
            this.grp_complementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tamanho;
        private System.Windows.Forms.GroupBox gro_sabor;
        private System.Windows.Forms.RadioButton rdb_brotinho;
        private System.Windows.Forms.RadioButton rdb_pequena;
        private System.Windows.Forms.RadioButton rdb_media;
        private System.Windows.Forms.RadioButton rdb_grande;
        private System.Windows.Forms.RadioButton rdb_portuguesa;
        private System.Windows.Forms.RadioButton rdb_frango;
        private System.Windows.Forms.RadioButton rdb_calabresa;
        private System.Windows.Forms.RadioButton rdb_mucarela;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Button btn_npedido;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.CheckBox chk_crememilho;
        private System.Windows.Forms.GroupBox grp_complementos;
        private System.Windows.Forms.CheckBox chk_goiabada;
        private System.Windows.Forms.CheckBox chk_banana;
        private System.Windows.Forms.CheckBox chk_picles;
        private System.Windows.Forms.CheckBox chk_cheddar;
        private System.Windows.Forms.CheckBox chk_cremeazeitona;
        //  private System.Windows.Forms.CheckBox chk_cremedeAzeitona;
    }
}

