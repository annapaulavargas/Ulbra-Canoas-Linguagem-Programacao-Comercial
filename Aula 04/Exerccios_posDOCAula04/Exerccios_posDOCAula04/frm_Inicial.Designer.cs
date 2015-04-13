namespace Exerccios_posDOCAula04
{
    partial class frm_Inicial
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
            this.btn_Calculadora = new System.Windows.Forms.Button();
            this.btn_Areas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Encerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calculadora
            // 
            this.btn_Calculadora.Location = new System.Drawing.Point(82, 23);
            this.btn_Calculadora.Name = "btn_Calculadora";
            this.btn_Calculadora.Size = new System.Drawing.Size(122, 38);
            this.btn_Calculadora.TabIndex = 0;
            this.btn_Calculadora.Text = "Calculadora";
            this.btn_Calculadora.UseVisualStyleBackColor = true;
            this.btn_Calculadora.Click += new System.EventHandler(this.btn_Calculadora_Click);
            // 
            // btn_Areas
            // 
            this.btn_Areas.Location = new System.Drawing.Point(82, 82);
            this.btn_Areas.Name = "btn_Areas";
            this.btn_Areas.Size = new System.Drawing.Size(122, 38);
            this.btn_Areas.TabIndex = 1;
            this.btn_Areas.Text = "Cálculo das Áreas";
            this.btn_Areas.UseVisualStyleBackColor = true;
            this.btn_Areas.Click += new System.EventHandler(this.btn_Areas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Matriz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Encerrar
            // 
            this.btn_Encerrar.Location = new System.Drawing.Point(82, 197);
            this.btn_Encerrar.Name = "btn_Encerrar";
            this.btn_Encerrar.Size = new System.Drawing.Size(122, 38);
            this.btn_Encerrar.TabIndex = 3;
            this.btn_Encerrar.Text = "Encerrar";
            this.btn_Encerrar.UseVisualStyleBackColor = true;
            this.btn_Encerrar.Click += new System.EventHandler(this.btn_Encerrar_Click);
            // 
            // frm_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Encerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Areas);
            this.Controls.Add(this.btn_Calculadora);
            this.Name = "frm_Inicial";
            this.Text = "Exerccios_pós-DOC_Aula04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculadora;
        private System.Windows.Forms.Button btn_Areas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Encerrar;
    }
}

