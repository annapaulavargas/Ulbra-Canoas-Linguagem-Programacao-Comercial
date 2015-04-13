namespace Exemplo_Aula02
{
    partial class frm_primeiro
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(23, 21);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(64, 21);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Idade_KeyDown);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(74, 120);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Location = new System.Drawing.Point(26, 62);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_Idade.TabIndex = 3;
            this.lbl_Idade.Text = "Idade";
            this.lbl_Idade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(64, 62);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(100, 20);
            this.txt_Idade.TabIndex = 4;
            this.txt_Idade.TextChanged += new System.EventHandler(this.txt_Idade_TextChanged);
            this.txt_Idade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Idade_KeyDown);
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            this.txt_Idade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Idade_KeyDown);
            // 
            // frm_primeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_primeiro";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.TextBox txt_Idade;

    }
}

