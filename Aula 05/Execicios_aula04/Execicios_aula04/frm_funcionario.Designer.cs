namespace Execicios_aula04
{
    partial class frm_funcionario
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
            this.id = new System.Windows.Forms.TextBox();
            this.vhoras = new System.Windows.Forms.TextBox();
            this.nhoras = new System.Windows.Forms.TextBox();
            this.nfilhos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(109, 59);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vhoras
            // 
            this.vhoras.Location = new System.Drawing.Point(109, 85);
            this.vhoras.Name = "vhoras";
            this.vhoras.Size = new System.Drawing.Size(100, 20);
            this.vhoras.TabIndex = 1;
            this.vhoras.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nhoras
            // 
            this.nhoras.Location = new System.Drawing.Point(109, 111);
            this.nhoras.Name = "nhoras";
            this.nhoras.Size = new System.Drawing.Size(100, 20);
            this.nhoras.TabIndex = 2;
            // 
            // nfilhos
            // 
            this.nfilhos.Location = new System.Drawing.Point(155, 140);
            this.nfilhos.Name = "nfilhos";
            this.nfilhos.Size = new System.Drawing.Size(54, 20);
            this.nfilhos.TabIndex = 3;
            this.nfilhos.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Funcionário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Hora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de Horas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número de filhos < 14 anos";
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(109, 236);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(71, 13);
            this.labelresult.TabIndex = 8;
            this.labelresult.Text = "lbl_Resultado";
            this.labelresult.Click += new System.EventHandler(this.labelresult_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(91, 190);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nfilhos);
            this.Controls.Add(this.nhoras);
            this.Controls.Add(this.vhoras);
            this.Controls.Add(this.id);
            this.Name = "frm_funcionario";
            this.Text = "Cálculo do Funcionário";
            this.Load += new System.EventHandler(this.frm_funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox vhoras;
        private System.Windows.Forms.TextBox nhoras;
        private System.Windows.Forms.TextBox nfilhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button calcular;
    }
}