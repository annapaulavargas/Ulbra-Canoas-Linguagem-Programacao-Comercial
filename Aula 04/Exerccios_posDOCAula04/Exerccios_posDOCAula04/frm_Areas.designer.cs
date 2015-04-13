namespace Exercicio_CalculoAreas
{
    partial class frm_Areas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUD_A = new System.Windows.Forms.NumericUpDown();
            this.NUD_B = new System.Windows.Forms.NumericUpDown();
            this.NUD_C = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_calculoRealizado = new System.Windows.Forms.NumericUpDown();
            this.btn_MostraResultado = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_ListaArray = new System.Windows.Forms.Button();
            this.lst_Resultado = new System.Windows.Forms.ListBox();
            this.lbl_Resultado_Listar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Resultado_Listar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_C)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_calculoRealizado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor C:";
            // 
            // NUD_A
            // 
            this.NUD_A.Location = new System.Drawing.Point(107, 19);
            this.NUD_A.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_A.Name = "NUD_A";
            this.NUD_A.Size = new System.Drawing.Size(63, 20);
            this.NUD_A.TabIndex = 3;
            this.NUD_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_B
            // 
            this.NUD_B.Location = new System.Drawing.Point(107, 52);
            this.NUD_B.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_B.Name = "NUD_B";
            this.NUD_B.Size = new System.Drawing.Size(63, 20);
            this.NUD_B.TabIndex = 4;
            this.NUD_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_C
            // 
            this.NUD_C.Location = new System.Drawing.Point(107, 87);
            this.NUD_C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_C.Name = "NUD_C";
            this.NUD_C.Size = new System.Drawing.Size(63, 20);
            this.NUD_C.TabIndex = 5;
            this.NUD_C.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(200, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo da Área";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 115);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(175, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Superfície do Cubo (Aresta = C)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Retângulo (A, B)";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quadrado (B)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Círculo (raio = C)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Triângulo Retângulo (A, B)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(424, 27);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(161, 32);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.BackColor = System.Drawing.Color.Red;
            this.lbl_Resultado.Location = new System.Drawing.Point(44, 247);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(71, 13);
            this.lbl_Resultado.TabIndex = 8;
            this.lbl_Resultado.Text = "lbl_Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mostra cálculo realizado:";
            // 
            // NUD_calculoRealizado
            // 
            this.NUD_calculoRealizado.Location = new System.Drawing.Point(190, 173);
            this.NUD_calculoRealizado.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NUD_calculoRealizado.Name = "NUD_calculoRealizado";
            this.NUD_calculoRealizado.Size = new System.Drawing.Size(38, 20);
            this.NUD_calculoRealizado.TabIndex = 10;
            // 
            // btn_MostraResultado
            // 
            this.btn_MostraResultado.Location = new System.Drawing.Point(54, 199);
            this.btn_MostraResultado.Name = "btn_MostraResultado";
            this.btn_MostraResultado.Size = new System.Drawing.Size(161, 32);
            this.btn_MostraResultado.TabIndex = 11;
            this.btn_MostraResultado.Text = "Mostra Resultado";
            this.btn_MostraResultado.UseVisualStyleBackColor = true;
            this.btn_MostraResultado.Click += new System.EventHandler(this.btn_MostraResultado_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(235, 204);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(37, 26);
            this.btn_Del.TabIndex = 12;
            this.btn_Del.Text = "Del";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_ListaArray
            // 
            this.btn_ListaArray.Location = new System.Drawing.Point(66, 273);
            this.btn_ListaArray.Name = "btn_ListaArray";
            this.btn_ListaArray.Size = new System.Drawing.Size(123, 25);
            this.btn_ListaArray.TabIndex = 13;
            this.btn_ListaArray.Text = "Listar";
            this.btn_ListaArray.UseVisualStyleBackColor = true;
            this.btn_ListaArray.Click += new System.EventHandler(this.btn_ListaArray_Click);
            // 
            // lst_Resultado
            // 
            this.lst_Resultado.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Resultado.FormattingEnabled = true;
            this.lst_Resultado.ItemHeight = 14;
            this.lst_Resultado.Location = new System.Drawing.Point(25, 304);
            this.lst_Resultado.Name = "lst_Resultado";
            this.lst_Resultado.Size = new System.Drawing.Size(560, 102);
            this.lst_Resultado.TabIndex = 14;
            // 
            // lbl_Resultado_Listar
            // 
            this.lbl_Resultado_Listar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Resultado_Listar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Resultado_Listar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado_Listar.Location = new System.Drawing.Point(25, 453);
            this.lbl_Resultado_Listar.Name = "lbl_Resultado_Listar";
            this.lbl_Resultado_Listar.Size = new System.Drawing.Size(560, 100);
            this.lbl_Resultado_Listar.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "TextBox MultiLine";
            // 
            // txt_Resultado_Listar
            // 
            this.txt_Resultado_Listar.Location = new System.Drawing.Point(28, 592);
            this.txt_Resultado_Listar.Multiline = true;
            this.txt_Resultado_Listar.Name = "txt_Resultado_Listar";
            this.txt_Resultado_Listar.ReadOnly = true;
            this.txt_Resultado_Listar.Size = new System.Drawing.Size(557, 101);
            this.txt_Resultado_Listar.TabIndex = 18;
            // 
            // frm_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 695);
            this.Controls.Add(this.lbl_Resultado_Listar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Resultado_Listar);
            this.Controls.Add(this.lst_Resultado);
            this.Controls.Add(this.btn_ListaArray);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_MostraResultado);
            this.Controls.Add(this.NUD_calculoRealizado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUD_C);
            this.Controls.Add(this.NUD_B);
            this.Controls.Add(this.NUD_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Areas";
            this.Text = "Cálculo das áreas";
            this.Load += new System.EventHandler(this.frm_Areas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_C)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_calculoRealizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUD_A;
        private System.Windows.Forms.NumericUpDown NUD_B;
        private System.Windows.Forms.NumericUpDown NUD_C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_calculoRealizado;
        private System.Windows.Forms.Button btn_MostraResultado;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_ListaArray;
        private System.Windows.Forms.ListBox lst_Resultado;
        private System.Windows.Forms.Label lbl_Resultado_Listar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Resultado_Listar;
    }
}

