namespace Exercicio_2
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
            this.txt_teste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_teste
            // 
            this.txt_teste.Location = new System.Drawing.Point(74, 86);
            this.txt_teste.Name = "txt_teste";
            this.txt_teste.Size = new System.Drawing.Size(137, 20);
            this.txt_teste.TabIndex = 0;
            this.txt_teste.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_teste.Enter += new System.EventHandler(this.txt_teste_Enter);
            // 
            // frm_segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_teste);
            this.Name = "frm_segundo";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.frm_segundo_Activated);
            this.Deactivate += new System.EventHandler(this.frm_segundo_Deactivate);
            this.Load += new System.EventHandler(this.frm2_Load);
            this.Enter += new System.EventHandler(this.frm_segundo_Enter);
            this.Leave += new System.EventHandler(this.frm_segundo_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_teste;

        public System.EventHandler Form2_Load { get; set; }
    }
}