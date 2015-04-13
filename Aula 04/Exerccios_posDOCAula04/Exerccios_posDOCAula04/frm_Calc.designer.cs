namespace Exercicio_Calculadora
{
    partial class frm_Calc
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
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_seis = new System.Windows.Forms.Button();
            this.btn_cinco = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_nove = new System.Windows.Forms.Button();
            this.btn_oito = new System.Windows.Forms.Button();
            this.btn_sete = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(31, 12);
            this.txt_Valor.MaxLength = 6;
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(130, 26);
            this.txt_Valor.TabIndex = 0;
            // 
            // btn_um
            // 
            this.btn_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_um.Location = new System.Drawing.Point(31, 57);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(33, 30);
            this.btn_um.TabIndex = 1;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dois.Location = new System.Drawing.Point(79, 57);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(33, 30);
            this.btn_dois.TabIndex = 2;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(176, 57);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(33, 30);
            this.btn_soma.TabIndex = 4;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_tres
            // 
            this.btn_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.Location = new System.Drawing.Point(128, 57);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(33, 30);
            this.btn_tres.TabIndex = 3;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = true;
            this.btn_tres.Click += new System.EventHandler(this.btn_tres_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtracao.Location = new System.Drawing.Point(176, 102);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(33, 30);
            this.btn_subtracao.TabIndex = 8;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_seis
            // 
            this.btn_seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seis.Location = new System.Drawing.Point(128, 102);
            this.btn_seis.Name = "btn_seis";
            this.btn_seis.Size = new System.Drawing.Size(33, 30);
            this.btn_seis.TabIndex = 7;
            this.btn_seis.Text = "6";
            this.btn_seis.UseVisualStyleBackColor = true;
            this.btn_seis.Click += new System.EventHandler(this.btn_seis_Click);
            // 
            // btn_cinco
            // 
            this.btn_cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinco.Location = new System.Drawing.Point(79, 102);
            this.btn_cinco.Name = "btn_cinco";
            this.btn_cinco.Size = new System.Drawing.Size(33, 30);
            this.btn_cinco.TabIndex = 6;
            this.btn_cinco.Text = "5";
            this.btn_cinco.UseVisualStyleBackColor = true;
            this.btn_cinco.Click += new System.EventHandler(this.btn_cinco_Click);
            // 
            // btn_quatro
            // 
            this.btn_quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quatro.Location = new System.Drawing.Point(31, 102);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(33, 30);
            this.btn_quatro.TabIndex = 5;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = true;
            this.btn_quatro.Click += new System.EventHandler(this.btn_quatro_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicacao.Location = new System.Drawing.Point(176, 149);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(33, 30);
            this.btn_multiplicacao.TabIndex = 12;
            this.btn_multiplicacao.Text = "*";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_nove
            // 
            this.btn_nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nove.Location = new System.Drawing.Point(128, 149);
            this.btn_nove.Name = "btn_nove";
            this.btn_nove.Size = new System.Drawing.Size(33, 30);
            this.btn_nove.TabIndex = 11;
            this.btn_nove.Text = "9";
            this.btn_nove.UseVisualStyleBackColor = true;
            this.btn_nove.Click += new System.EventHandler(this.btn_nove_Click);
            // 
            // btn_oito
            // 
            this.btn_oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oito.Location = new System.Drawing.Point(79, 149);
            this.btn_oito.Name = "btn_oito";
            this.btn_oito.Size = new System.Drawing.Size(33, 30);
            this.btn_oito.TabIndex = 10;
            this.btn_oito.Text = "8";
            this.btn_oito.UseVisualStyleBackColor = true;
            this.btn_oito.Click += new System.EventHandler(this.btn_oito_Click);
            // 
            // btn_sete
            // 
            this.btn_sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sete.Location = new System.Drawing.Point(31, 149);
            this.btn_sete.Name = "btn_sete";
            this.btn_sete.Size = new System.Drawing.Size(33, 30);
            this.btn_sete.TabIndex = 9;
            this.btn_sete.Text = "7";
            this.btn_sete.UseVisualStyleBackColor = true;
            this.btn_sete.Click += new System.EventHandler(this.btn_sete_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisao.Location = new System.Drawing.Point(176, 195);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(33, 30);
            this.btn_divisao.TabIndex = 16;
            this.btn_divisao.Text = "/";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(79, 195);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(82, 30);
            this.btn_igual.TabIndex = 14;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(31, 195);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(33, 30);
            this.btn_zero.TabIndex = 13;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.BackColor = System.Drawing.Color.Red;
            this.lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(24, 237);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(184, 35);
            this.lbl_Resultado.TabIndex = 17;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(175, 12);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(33, 30);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // frm_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 281);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_nove);
            this.Controls.Add(this.btn_oito);
            this.Controls.Add(this.btn_sete);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_seis);
            this.Controls.Add(this.btn_cinco);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.txt_Valor);
            this.Name = "frm_Calc";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frm_Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_seis;
        private System.Windows.Forms.Button btn_cinco;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_nove;
        private System.Windows.Forms.Button btn_oito;
        private System.Windows.Forms.Button btn_sete;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_clear;
    }
}

