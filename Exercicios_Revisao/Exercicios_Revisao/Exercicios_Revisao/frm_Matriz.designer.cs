namespace Operacoes_com_Matrizes
{
    partial class frm_Matriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Matriz));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.NUD_Lin = new System.Windows.Forms.NumericUpDown();
            this.NUD_Col = new System.Windows.Forms.NumericUpDown();
            this.opt_7 = new System.Windows.Forms.RadioButton();
            this.opt_6 = new System.Windows.Forms.RadioButton();
            this.opt_5 = new System.Windows.Forms.RadioButton();
            this.opt_4 = new System.Windows.Forms.RadioButton();
            this.opt_3 = new System.Windows.Forms.RadioButton();
            this.opt_2 = new System.Windows.Forms.RadioButton();
            this.opt_1 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.lsb_Matriz = new System.Windows.Forms.ListBox();
            this.NUD_5 = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.NUD_4 = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.NUD_3 = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.NUD_2 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.NUD_1 = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Lin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Col)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.NUD_Lin);
            this.GroupBox2.Controls.Add(this.NUD_Col);
            this.GroupBox2.Controls.Add(this.opt_7);
            this.GroupBox2.Controls.Add(this.opt_6);
            this.GroupBox2.Controls.Add(this.opt_5);
            this.GroupBox2.Controls.Add(this.opt_4);
            this.GroupBox2.Controls.Add(this.opt_3);
            this.GroupBox2.Controls.Add(this.opt_2);
            this.GroupBox2.Controls.Add(this.opt_1);
            this.GroupBox2.Location = new System.Drawing.Point(313, 14);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(336, 216);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Operações";
            // 
            // NUD_Lin
            // 
            this.NUD_Lin.Location = new System.Drawing.Point(237, 60);
            this.NUD_Lin.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUD_Lin.Name = "NUD_Lin";
            this.NUD_Lin.Size = new System.Drawing.Size(56, 20);
            this.NUD_Lin.TabIndex = 8;
            // 
            // NUD_Col
            // 
            this.NUD_Col.Location = new System.Drawing.Point(237, 32);
            this.NUD_Col.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUD_Col.Name = "NUD_Col";
            this.NUD_Col.Size = new System.Drawing.Size(56, 20);
            this.NUD_Col.TabIndex = 7;
            // 
            // opt_7
            // 
            this.opt_7.Location = new System.Drawing.Point(24, 176);
            this.opt_7.Name = "opt_7";
            this.opt_7.Size = new System.Drawing.Size(269, 24);
            this.opt_7.TabIndex = 6;
            this.opt_7.Text = "Soma dos valores da parte inferior:";
            // 
            // opt_6
            // 
            this.opt_6.Location = new System.Drawing.Point(24, 152);
            this.opt_6.Name = "opt_6";
            this.opt_6.Size = new System.Drawing.Size(240, 24);
            this.opt_6.TabIndex = 5;
            this.opt_6.Text = "Soma dos valores da área lateral esquerda:";
            // 
            // opt_5
            // 
            this.opt_5.Location = new System.Drawing.Point(24, 128);
            this.opt_5.Name = "opt_5";
            this.opt_5.Size = new System.Drawing.Size(224, 24);
            this.opt_5.TabIndex = 4;
            this.opt_5.Text = "Soma dos valores da parte superior";
            // 
            // opt_4
            // 
            this.opt_4.Location = new System.Drawing.Point(24, 104);
            this.opt_4.Name = "opt_4";
            this.opt_4.Size = new System.Drawing.Size(240, 24);
            this.opt_4.TabIndex = 3;
            this.opt_4.Text = "Soma dos valores da diagonal secundária";
            // 
            // opt_3
            // 
            this.opt_3.Location = new System.Drawing.Point(24, 80);
            this.opt_3.Name = "opt_3";
            this.opt_3.Size = new System.Drawing.Size(224, 24);
            this.opt_3.TabIndex = 2;
            this.opt_3.Text = "Soma dos valores da diagonal principal: ";
            // 
            // opt_2
            // 
            this.opt_2.Location = new System.Drawing.Point(24, 56);
            this.opt_2.Name = "opt_2";
            this.opt_2.Size = new System.Drawing.Size(182, 24);
            this.opt_2.TabIndex = 1;
            this.opt_2.Text = "Soma dos valores de uma linha: ";
            // 
            // opt_1
            // 
            this.opt_1.Location = new System.Drawing.Point(24, 32);
            this.opt_1.Name = "opt_1";
            this.opt_1.Size = new System.Drawing.Size(240, 24);
            this.opt_1.TabIndex = 0;
            this.opt_1.Text = "Soma dos valores de uma coluna: ";
            this.opt_1.CheckedChanged += new System.EventHandler(this.opt_1_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btn_Incluir);
            this.GroupBox1.Controls.Add(this.lsb_Matriz);
            this.GroupBox1.Controls.Add(this.NUD_5);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.NUD_4);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.NUD_3);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.NUD_2);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.NUD_1);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(288, 216);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Insere Matriz";
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(168, 32);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(72, 24);
            this.btn_Incluir.TabIndex = 13;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // lsb_Matriz
            // 
            this.lsb_Matriz.Location = new System.Drawing.Point(152, 80);
            this.lsb_Matriz.Name = "lsb_Matriz";
            this.lsb_Matriz.Size = new System.Drawing.Size(120, 108);
            this.lsb_Matriz.TabIndex = 12;
            // 
            // NUD_5
            // 
            this.NUD_5.Location = new System.Drawing.Point(80, 160);
            this.NUD_5.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_5.Name = "NUD_5";
            this.NUD_5.Size = new System.Drawing.Size(56, 20);
            this.NUD_5.TabIndex = 11;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 160);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Elemento5:";
            // 
            // NUD_4
            // 
            this.NUD_4.Location = new System.Drawing.Point(80, 128);
            this.NUD_4.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_4.Name = "NUD_4";
            this.NUD_4.Size = new System.Drawing.Size(56, 20);
            this.NUD_4.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Elemento4:";
            // 
            // NUD_3
            // 
            this.NUD_3.Location = new System.Drawing.Point(80, 96);
            this.NUD_3.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_3.Name = "NUD_3";
            this.NUD_3.Size = new System.Drawing.Size(56, 20);
            this.NUD_3.TabIndex = 7;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Elemento3:";
            // 
            // NUD_2
            // 
            this.NUD_2.Location = new System.Drawing.Point(80, 64);
            this.NUD_2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_2.Name = "NUD_2";
            this.NUD_2.Size = new System.Drawing.Size(56, 20);
            this.NUD_2.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Elemento2:";
            // 
            // NUD_1
            // 
            this.NUD_1.Location = new System.Drawing.Point(80, 32);
            this.NUD_1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_1.Name = "NUD_1";
            this.NUD_1.Size = new System.Drawing.Size(56, 20);
            this.NUD_1.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Elemento1:";
            // 
            // Button1
            // 
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Location = new System.Drawing.Point(57, 264);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(96, 32);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Soma";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Resultado.Location = new System.Drawing.Point(185, 264);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(359, 40);
            this.lbl_Resultado.TabIndex = 9;
            this.lbl_Resultado.Click += new System.EventHandler(this.lbl_Resultado_Click);
            // 
            // frm_Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 321);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frm_Matriz";
            this.Text = "Operações com Matrizes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Lin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Col)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown NUD_Lin;
        internal System.Windows.Forms.NumericUpDown NUD_Col;
        internal System.Windows.Forms.RadioButton opt_7;
        internal System.Windows.Forms.RadioButton opt_6;
        internal System.Windows.Forms.RadioButton opt_5;
        internal System.Windows.Forms.RadioButton opt_4;
        internal System.Windows.Forms.RadioButton opt_3;
        internal System.Windows.Forms.RadioButton opt_2;
        internal System.Windows.Forms.RadioButton opt_1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btn_Incluir;
        internal System.Windows.Forms.ListBox lsb_Matriz;
        internal System.Windows.Forms.NumericUpDown NUD_5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown NUD_4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.NumericUpDown NUD_3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown NUD_2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.NumericUpDown NUD_1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label lbl_Resultado;
    }
}

