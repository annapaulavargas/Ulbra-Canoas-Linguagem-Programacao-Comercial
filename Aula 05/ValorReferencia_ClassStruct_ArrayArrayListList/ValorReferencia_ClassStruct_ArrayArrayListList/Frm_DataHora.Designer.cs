namespace ValorReferencia_ClassStruct_ArrayArrayListList
{
    partial class Frm_DataHora
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
            this.DT_Long = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Short = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_Time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DT_Custom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_DiaSemana = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DT_Long
            // 
            this.DT_Long.Location = new System.Drawing.Point(151, 36);
            this.DT_Long.Name = "DT_Long";
            this.DT_Long.Size = new System.Drawing.Size(212, 20);
            this.DT_Long.TabIndex = 0;
            this.DT_Long.ValueChanged += new System.EventHandler(this.DT_Long_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // DT_Short
            // 
            this.DT_Short.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Short.Location = new System.Drawing.Point(151, 80);
            this.DT_Short.Name = "DT_Short";
            this.DT_Short.Size = new System.Drawing.Size(212, 20);
            this.DT_Short.TabIndex = 2;
            this.DT_Short.ValueChanged += new System.EventHandler(this.DT_Short_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // DT_Time
            // 
            this.DT_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DT_Time.Location = new System.Drawing.Point(151, 124);
            this.DT_Time.Name = "DT_Time";
            this.DT_Time.ShowUpDown = true;
            this.DT_Time.Size = new System.Drawing.Size(212, 20);
            this.DT_Time.TabIndex = 4;
            this.DT_Time.ValueChanged += new System.EventHandler(this.DT_Time_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data / Hora:";
            // 
            // DT_Custom
            // 
            this.DT_Custom.CustomFormat = "dd/MMM/yyyy - HH:mm:ss";
            this.DT_Custom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_Custom.Location = new System.Drawing.Point(151, 168);
            this.DT_Custom.Name = "DT_Custom";
            this.DT_Custom.ShowCheckBox = true;
            this.DT_Custom.ShowUpDown = true;
            this.DT_Custom.Size = new System.Drawing.Size(212, 20);
            this.DT_Custom.TabIndex = 6;
            this.DT_Custom.ValueChanged += new System.EventHandler(this.DT_Custom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prop. Format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Long";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Short";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Custom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Outras Prop. Alteradas";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(389, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 50);
            this.label11.TabIndex = 15;
            this.label11.Text = "CustomFormat (dd/MMM/yyyy - HH:mm:ss), ShowUpDown e ShowCheckBox";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "ShowUpDown";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(148, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Valor fica armazenado na prop Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Prop. Checked";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(198, 229);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(30, 13);
            this.lbl_Data.TabIndex = 18;
            this.lbl_Data.Text = "Data";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Data";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Dia da Semana";
            // 
            // lbl_DiaSemana
            // 
            this.lbl_DiaSemana.AutoSize = true;
            this.lbl_DiaSemana.Location = new System.Drawing.Point(198, 251);
            this.lbl_DiaSemana.Name = "lbl_DiaSemana";
            this.lbl_DiaSemana.Size = new System.Drawing.Size(80, 13);
            this.lbl_DiaSemana.TabIndex = 20;
            this.lbl_DiaSemana.Text = "Dia da Semana";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(99, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Hora";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(198, 274);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(30, 13);
            this.lbl_Hora.TabIndex = 22;
            this.lbl_Hora.Text = "Hora";
            // 
            // Frm_DataHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 363);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_DiaSemana);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DT_Custom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DT_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DT_Short);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_Long);
            this.Name = "Frm_DataHora";
            this.Text = "Frm_DataHora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_Long;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_Short;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DT_Custom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_DiaSemana;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_Hora;
    }
}