namespace Combolist
{
    partial class frm_Combolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Combolist));
            this.cbo_lista = new System.Windows.Forms.ComboBox();
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.btn_insere = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_contador = new System.Windows.Forms.Label();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_insere = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.lbl_remove = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_cbo = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_lista
            // 
            this.cbo_lista.FormattingEnabled = true;
            this.cbo_lista.Location = new System.Drawing.Point(23, 38);
            this.cbo_lista.Name = "cbo_lista";
            this.cbo_lista.Size = new System.Drawing.Size(183, 21);
            this.cbo_lista.TabIndex = 0;
            this.cbo_lista.SelectedIndexChanged += new System.EventHandler(this.cbo_lista_SelectedIndexChanged);
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(23, 104);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(183, 173);
            this.lst_lista.TabIndex = 1;
            // 
            // btn_insere
            // 
            this.btn_insere.Location = new System.Drawing.Point(313, 65);
            this.btn_insere.Name = "btn_insere";
            this.btn_insere.Size = new System.Drawing.Size(75, 23);
            this.btn_insere.TabIndex = 2;
            this.btn_insere.Text = "Inserir item";
            this.btn_insere.UseVisualStyleBackColor = true;
            this.btn_insere.Click += new System.EventHandler(this.btn_insere_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(356, 94);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(75, 23);
            this.btn_limpa.TabIndex = 3;
            this.btn_limpa.Text = "Limpar";
            this.btn_limpa.UseVisualStyleBackColor = true;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(394, 65);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(475, 65);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(73, 52);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contador.Location = new System.Drawing.Point(310, 132);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(79, 20);
            this.lbl_contador.TabIndex = 6;
            this.lbl_contador.Text = "Contador:";
            // 
            // lbl_conta
            // 
            this.lbl_conta.BackColor = System.Drawing.Color.White;
            this.lbl_conta.Location = new System.Drawing.Point(395, 132);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(74, 23);
            this.lbl_conta.TabIndex = 7;
            // 
            // lbl_insere
            // 
            this.lbl_insere.AutoSize = true;
            this.lbl_insere.Location = new System.Drawing.Point(212, 184);
            this.lbl_insere.Name = "lbl_insere";
            this.lbl_insere.Size = new System.Drawing.Size(213, 13);
            this.lbl_insere.TabIndex = 8;
            this.lbl_insere.Text = "Digite os itens a serem inseridos e tecle OK:";
            this.lbl_insere.Visible = false;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(431, 181);
            this.txt_item.MaxLength = 25;
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(177, 20);
            this.txt_item.TabIndex = 9;
            this.txt_item.Visible = false;
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Location = new System.Drawing.Point(280, 215);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(240, 13);
            this.lbl_remove.TabIndex = 10;
            this.lbl_remove.Text = "Selecione os itens a serem removidos e tecle OK!";
            this.lbl_remove.Visible = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(212, 264);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(117, 16);
            this.lbl_1.TabIndex = 11;
            this.lbl_1.Text = "Estou removendo:";
            this.lbl_1.Visible = false;
            // 
            // lbl_cbo
            // 
            this.lbl_cbo.BackColor = System.Drawing.Color.White;
            this.lbl_cbo.Location = new System.Drawing.Point(331, 264);
            this.lbl_cbo.Name = "lbl_cbo";
            this.lbl_cbo.Size = new System.Drawing.Size(100, 16);
            this.lbl_cbo.TabIndex = 12;
            this.lbl_cbo.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(438, 266);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(13, 13);
            this.lbl_2.TabIndex = 13;
            this.lbl_2.Text = "e";
            this.lbl_2.Visible = false;
            // 
            // lbl_list
            // 
            this.lbl_list.BackColor = System.Drawing.Color.White;
            this.lbl_list.Location = new System.Drawing.Point(457, 264);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(100, 16);
            this.lbl_list.TabIndex = 14;
            this.lbl_list.Visible = false;
            // 
            // frm_Combolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Combolist.Properties.Resources.imagem_teste;
            this.ClientSize = new System.Drawing.Size(620, 326);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_cbo);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_remove);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.lbl_insere);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.lbl_contador);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_insere);
            this.Controls.Add(this.lst_lista);
            this.Controls.Add(this.cbo_lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Combolist";
            this.Text = "Exercício de combox e ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_lista;
        private System.Windows.Forms.ListBox lst_lista;
        private System.Windows.Forms.Button btn_insere;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_contador;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_insere;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_cbo;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_list;
    }
}

