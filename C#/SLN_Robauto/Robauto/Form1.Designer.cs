namespace Robauto
{
    partial class frm_robauto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_robauto));
            this.cbo_marca = new System.Windows.Forms.ComboBox();
            this.cbo_nome = new System.Windows.Forms.ComboBox();
            this.cbo_modelo = new System.Windows.Forms.ComboBox();
            this.lst_acessorios = new System.Windows.Forms.ListBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_acessorio = new System.Windows.Forms.Label();
            this.lst_ano = new System.Windows.Forms.ListBox();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_novo_pedido = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_apresentacao = new System.Windows.Forms.Label();
            this.lbl_apresentacao1 = new System.Windows.Forms.Label();
            this.lbl_nomeformulario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_marca
            // 
            this.cbo_marca.BackColor = System.Drawing.Color.Black;
            this.cbo_marca.ForeColor = System.Drawing.Color.Blue;
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Items.AddRange(new object[] {
            "HYUNDAI",
            "CITROEN",
            "HONDA"});
            this.cbo_marca.Location = new System.Drawing.Point(12, 95);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(121, 21);
            this.cbo_marca.TabIndex = 0;
            this.cbo_marca.Text = "-----SELECIONE------";
            this.cbo_marca.SelectedIndexChanged += new System.EventHandler(this.cbo_marca_SelectedIndexChanged);
            // 
            // cbo_nome
            // 
            this.cbo_nome.BackColor = System.Drawing.Color.Black;
            this.cbo_nome.ForeColor = System.Drawing.Color.Blue;
            this.cbo_nome.FormattingEnabled = true;
            this.cbo_nome.Location = new System.Drawing.Point(12, 150);
            this.cbo_nome.Name = "cbo_nome";
            this.cbo_nome.Size = new System.Drawing.Size(121, 21);
            this.cbo_nome.TabIndex = 1;
            this.cbo_nome.Text = "-----SELECIONE-------";
            this.cbo_nome.SelectedIndexChanged += new System.EventHandler(this.cbo_nome_SelectedIndexChanged);
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.BackColor = System.Drawing.Color.Black;
            this.cbo_modelo.ForeColor = System.Drawing.Color.Blue;
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(12, 210);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(121, 21);
            this.cbo_modelo.TabIndex = 2;
            this.cbo_modelo.Text = "------SELECIONE------";
            this.cbo_modelo.SelectedIndexChanged += new System.EventHandler(this.cbo_modelo_SelectedIndexChanged);
            // 
            // lst_acessorios
            // 
            this.lst_acessorios.BackColor = System.Drawing.Color.Black;
            this.lst_acessorios.ForeColor = System.Drawing.Color.Lime;
            this.lst_acessorios.FormattingEnabled = true;
            this.lst_acessorios.Items.AddRange(new object[] {
            "CENTRAL MULTIDIA",
            "AR-CONDICIONADO",
            "TRAVAS ELETRICAS",
            "VIDRO ELETRICO",
            "AIRBERG",
            "BANCO DE COURO",
            "RODAS DE LIGA LEVE",
            "COMPUTADOR DE BORDO",
            "GPS",
            "FAROL DE MILHA"});
            this.lst_acessorios.Location = new System.Drawing.Point(348, 101);
            this.lst_acessorios.Name = "lst_acessorios";
            this.lst_acessorios.Size = new System.Drawing.Size(151, 95);
            this.lst_acessorios.TabIndex = 4;
            this.lst_acessorios.SelectedIndexChanged += new System.EventHandler(this.lst_acessorios_SelectedIndexChanged);
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_marca.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_marca.Location = new System.Drawing.Point(48, 76);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(45, 13);
            this.lbl_marca.TabIndex = 5;
            this.lbl_marca.Text = "MARCA";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_nome.Location = new System.Drawing.Point(48, 134);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(39, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "NOME";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modelo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_modelo.Location = new System.Drawing.Point(40, 183);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(53, 13);
            this.lbl_modelo.TabIndex = 7;
            this.lbl_modelo.Text = "MODELO";
            // 
            // lbl_acessorio
            // 
            this.lbl_acessorio.AutoSize = true;
            this.lbl_acessorio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acessorio.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_acessorio.Location = new System.Drawing.Point(385, 76);
            this.lbl_acessorio.Name = "lbl_acessorio";
            this.lbl_acessorio.Size = new System.Drawing.Size(76, 13);
            this.lbl_acessorio.TabIndex = 9;
            this.lbl_acessorio.Text = "ACESSÓRIOS";
            // 
            // lst_ano
            // 
            this.lst_ano.BackColor = System.Drawing.Color.Black;
            this.lst_ano.ForeColor = System.Drawing.Color.Red;
            this.lst_ano.FormattingEnabled = true;
            this.lst_ano.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.lst_ano.Location = new System.Drawing.Point(180, 95);
            this.lst_ano.Name = "lst_ano";
            this.lst_ano.Size = new System.Drawing.Size(121, 95);
            this.lst_ano.TabIndex = 3;
            this.lst_ano.SelectedIndexChanged += new System.EventHandler(this.lst_ano_SelectedIndexChanged);
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ano.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_ano.Location = new System.Drawing.Point(218, 76);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(30, 13);
            this.lbl_ano.TabIndex = 11;
            this.lbl_ano.Text = "ANO";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.ForeColor = System.Drawing.Color.Gold;
            this.btn_confirmar.Location = new System.Drawing.Point(23, 251);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(85, 23);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_novo_pedido
            // 
            this.btn_novo_pedido.BackColor = System.Drawing.Color.Black;
            this.btn_novo_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_pedido.ForeColor = System.Drawing.Color.Gold;
            this.btn_novo_pedido.Location = new System.Drawing.Point(372, 210);
            this.btn_novo_pedido.Name = "btn_novo_pedido";
            this.btn_novo_pedido.Size = new System.Drawing.Size(100, 23);
            this.btn_novo_pedido.TabIndex = 6;
            this.btn_novo_pedido.Text = "Novo Pedido";
            this.btn_novo_pedido.UseVisualStyleBackColor = false;
            this.btn_novo_pedido.Click += new System.EventHandler(this.btn_novo_pedido_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.Red;
            this.btn_sair.Location = new System.Drawing.Point(408, 481);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_apresentacao
            // 
            this.lbl_apresentacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apresentacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_apresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apresentacao.ForeColor = System.Drawing.Color.Gold;
            this.lbl_apresentacao.Location = new System.Drawing.Point(23, 306);
            this.lbl_apresentacao.Name = "lbl_apresentacao";
            this.lbl_apresentacao.Size = new System.Drawing.Size(490, 150);
            this.lbl_apresentacao.TabIndex = 15;
            this.lbl_apresentacao.Click += new System.EventHandler(this.lbl_apresentacao_Click);
            // 
            // lbl_apresentacao1
            // 
            this.lbl_apresentacao1.AutoSize = true;
            this.lbl_apresentacao1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apresentacao1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apresentacao1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_apresentacao1.Location = new System.Drawing.Point(150, 282);
            this.lbl_apresentacao1.Name = "lbl_apresentacao1";
            this.lbl_apresentacao1.Size = new System.Drawing.Size(191, 24);
            this.lbl_apresentacao1.TabIndex = 16;
            this.lbl_apresentacao1.Text = "Você selecionou:";
            this.lbl_apresentacao1.Visible = false;
            // 
            // lbl_nomeformulario
            // 
            this.lbl_nomeformulario.AutoSize = true;
            this.lbl_nomeformulario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomeformulario.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeformulario.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nomeformulario.Location = new System.Drawing.Point(197, 18);
            this.lbl_nomeformulario.Name = "lbl_nomeformulario";
            this.lbl_nomeformulario.Size = new System.Drawing.Size(104, 24);
            this.lbl_nomeformulario.TabIndex = 17;
            this.lbl_nomeformulario.Text = "Robauto";
            // 
            // frm_robauto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Robauto.Properties.Resources.plano_de_fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(535, 528);
            this.Controls.Add(this.lbl_nomeformulario);
            this.Controls.Add(this.lbl_apresentacao1);
            this.Controls.Add(this.lbl_apresentacao);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novo_pedido);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lst_ano);
            this.Controls.Add(this.lbl_acessorio);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lst_acessorios);
            this.Controls.Add(this.cbo_modelo);
            this.Controls.Add(this.cbo_nome);
            this.Controls.Add(this.cbo_marca);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_robauto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Garagem ROBAUTO S/A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_marca;
        private System.Windows.Forms.ComboBox cbo_nome;
        private System.Windows.Forms.ComboBox cbo_modelo;
        private System.Windows.Forms.ListBox lst_acessorios;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_acessorio;
        private System.Windows.Forms.ListBox lst_ano;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_novo_pedido;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_apresentacao;
        private System.Windows.Forms.Label lbl_apresentacao1;
        private System.Windows.Forms.Label lbl_nomeformulario;
    }
}

