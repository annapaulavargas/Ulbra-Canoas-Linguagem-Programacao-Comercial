namespace Exercicio_2
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
            this.btn_proximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(95, 91);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_proximo.TabIndex = 0;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_primeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_proximo);
            this.Name = "frm_primeiro";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frm_primeiro_Activated);
            this.Deactivate += new System.EventHandler(this.frm_primeiro_Deactivate);
            this.Load += new System.EventHandler(this.frm_primeiro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_proximo;
    }
}

