namespace Exemplo_Aula02
{
    partial class frm_segundo
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
            this.btn_retornar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_retornar
            // 
            this.btn_retornar.Location = new System.Drawing.Point(68, 119);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(75, 23);
            this.btn_retornar.TabIndex = 0;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = true;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(85, 78);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(0, 13);
            this.lbl_Nome.TabIndex = 1;
            // 
            // frm_segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_retornar);
            this.Name = "frm_segundo";
            this.Text = "Exemplo – segunda tela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Label lbl_Nome;

    }
}