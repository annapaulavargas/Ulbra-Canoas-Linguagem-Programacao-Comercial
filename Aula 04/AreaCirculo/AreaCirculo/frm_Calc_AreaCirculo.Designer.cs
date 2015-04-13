namespace AreaCirculo
{
    partial class frm_Calc_AreaCirculo
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
            this.txt_Raio = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Raio
            // 
            this.txt_Raio.Location = new System.Drawing.Point(85, 14);
            this.txt_Raio.Name = "txt_Raio";
            this.txt_Raio.Size = new System.Drawing.Size(161, 20);
            this.txt_Raio.TabIndex = 0;
            this.txt_Raio.TextChanged += new System.EventHandler(this.txt_Raio_TextChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(85, 60);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(94, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(25, 107);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(17, 13);
            this.lbl_Resultado.TabIndex = 2;
            this.lbl_Resultado.Text = "xx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor do Raio:";
            // 
            // frm_Calc_AreaCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Raio);
            this.Name = "frm_Calc_AreaCirculo";
            this.Text = "Área do Círculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Raio;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label label2;
    }
}

