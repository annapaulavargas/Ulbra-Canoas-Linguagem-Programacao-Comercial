namespace ValorReferencia_ClassStruct_ArrayArrayListList
{
    partial class Array_ArrayList_List
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
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.bt_Armazena = new System.Windows.Forms.Button();
            this.bt_Mostra = new System.Windows.Forms.Button();
            this.bt_Limpa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lst_Array_static = new System.Windows.Forms.ListBox();
            this.lst_ArrayList_static = new System.Windows.Forms.ListBox();
            this.lst_List_static = new System.Windows.Forms.ListBox();
            this.lst_List_public = new System.Windows.Forms.ListBox();
            this.lst_ArrayList_public = new System.Windows.Forms.ListBox();
            this.lst_Array_public = new System.Windows.Forms.ListBox();
            this.lst_List_private = new System.Windows.Forms.ListBox();
            this.lst_ArrayList_private = new System.Windows.Forms.ListBox();
            this.lst_Array_private = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(78, 14);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 1;
            // 
            // bt_Armazena
            // 
            this.bt_Armazena.AutoSize = true;
            this.bt_Armazena.Location = new System.Drawing.Point(24, 51);
            this.bt_Armazena.Name = "bt_Armazena";
            this.bt_Armazena.Size = new System.Drawing.Size(86, 23);
            this.bt_Armazena.TabIndex = 2;
            this.bt_Armazena.Text = "Armazena";
            this.bt_Armazena.UseVisualStyleBackColor = true;
            this.bt_Armazena.Click += new System.EventHandler(this.bt_Armazena_Click);
            // 
            // bt_Mostra
            // 
            this.bt_Mostra.AutoSize = true;
            this.bt_Mostra.Location = new System.Drawing.Point(149, 51);
            this.bt_Mostra.Name = "bt_Mostra";
            this.bt_Mostra.Size = new System.Drawing.Size(93, 23);
            this.bt_Mostra.TabIndex = 3;
            this.bt_Mostra.Text = "Mostra nas Lists";
            this.bt_Mostra.UseVisualStyleBackColor = true;
            this.bt_Mostra.Click += new System.EventHandler(this.bt_Mostra_Click);
            // 
            // bt_Limpa
            // 
            this.bt_Limpa.AutoSize = true;
            this.bt_Limpa.Location = new System.Drawing.Point(273, 51);
            this.bt_Limpa.Name = "bt_Limpa";
            this.bt_Limpa.Size = new System.Drawing.Size(86, 23);
            this.bt_Limpa.TabIndex = 4;
            this.bt_Limpa.Text = "Limpa";
            this.bt_Limpa.UseVisualStyleBackColor = true;
            this.bt_Limpa.Click += new System.EventHandler(this.bt_Limpa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Static";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Private";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Array";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ArrayList";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "List";
            // 
            // lst_Array_static
            // 
            this.lst_Array_static.FormattingEnabled = true;
            this.lst_Array_static.Location = new System.Drawing.Point(78, 108);
            this.lst_Array_static.Name = "lst_Array_static";
            this.lst_Array_static.Size = new System.Drawing.Size(85, 82);
            this.lst_Array_static.TabIndex = 11;
            // 
            // lst_ArrayList_static
            // 
            this.lst_ArrayList_static.FormattingEnabled = true;
            this.lst_ArrayList_static.Location = new System.Drawing.Point(203, 108);
            this.lst_ArrayList_static.Name = "lst_ArrayList_static";
            this.lst_ArrayList_static.Size = new System.Drawing.Size(85, 82);
            this.lst_ArrayList_static.TabIndex = 12;
            // 
            // lst_List_static
            // 
            this.lst_List_static.FormattingEnabled = true;
            this.lst_List_static.Location = new System.Drawing.Point(328, 108);
            this.lst_List_static.Name = "lst_List_static";
            this.lst_List_static.Size = new System.Drawing.Size(85, 82);
            this.lst_List_static.TabIndex = 13;
            // 
            // lst_List_public
            // 
            this.lst_List_public.FormattingEnabled = true;
            this.lst_List_public.Location = new System.Drawing.Point(328, 214);
            this.lst_List_public.Name = "lst_List_public";
            this.lst_List_public.Size = new System.Drawing.Size(85, 82);
            this.lst_List_public.TabIndex = 16;
            // 
            // lst_ArrayList_public
            // 
            this.lst_ArrayList_public.FormattingEnabled = true;
            this.lst_ArrayList_public.Location = new System.Drawing.Point(203, 214);
            this.lst_ArrayList_public.Name = "lst_ArrayList_public";
            this.lst_ArrayList_public.Size = new System.Drawing.Size(85, 82);
            this.lst_ArrayList_public.TabIndex = 15;
            // 
            // lst_Array_public
            // 
            this.lst_Array_public.FormattingEnabled = true;
            this.lst_Array_public.Location = new System.Drawing.Point(78, 214);
            this.lst_Array_public.Name = "lst_Array_public";
            this.lst_Array_public.Size = new System.Drawing.Size(85, 82);
            this.lst_Array_public.TabIndex = 14;
            // 
            // lst_List_private
            // 
            this.lst_List_private.FormattingEnabled = true;
            this.lst_List_private.Location = new System.Drawing.Point(328, 320);
            this.lst_List_private.Name = "lst_List_private";
            this.lst_List_private.Size = new System.Drawing.Size(85, 82);
            this.lst_List_private.TabIndex = 19;
            // 
            // lst_ArrayList_private
            // 
            this.lst_ArrayList_private.FormattingEnabled = true;
            this.lst_ArrayList_private.Location = new System.Drawing.Point(203, 320);
            this.lst_ArrayList_private.Name = "lst_ArrayList_private";
            this.lst_ArrayList_private.Size = new System.Drawing.Size(85, 82);
            this.lst_ArrayList_private.TabIndex = 18;
            // 
            // lst_Array_private
            // 
            this.lst_Array_private.FormattingEnabled = true;
            this.lst_Array_private.Location = new System.Drawing.Point(78, 320);
            this.lst_Array_private.Name = "lst_Array_private";
            this.lst_Array_private.Size = new System.Drawing.Size(85, 82);
            this.lst_Array_private.TabIndex = 17;
            // 
            // Array_ArrayList_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 427);
            this.Controls.Add(this.lst_List_private);
            this.Controls.Add(this.lst_ArrayList_private);
            this.Controls.Add(this.lst_Array_private);
            this.Controls.Add(this.lst_List_public);
            this.Controls.Add(this.lst_ArrayList_public);
            this.Controls.Add(this.lst_Array_public);
            this.Controls.Add(this.lst_List_static);
            this.Controls.Add(this.lst_ArrayList_static);
            this.Controls.Add(this.lst_Array_static);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Limpa);
            this.Controls.Add(this.bt_Mostra);
            this.Controls.Add(this.bt_Armazena);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Name = "Array_ArrayList_List";
            this.Text = "Array_ArrayList_List";
            this.Load += new System.EventHandler(this.Array_ArrayList_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button bt_Armazena;
        private System.Windows.Forms.Button bt_Mostra;
        private System.Windows.Forms.Button bt_Limpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lst_Array_static;
        private System.Windows.Forms.ListBox lst_ArrayList_static;
        private System.Windows.Forms.ListBox lst_List_static;
        private System.Windows.Forms.ListBox lst_List_public;
        private System.Windows.Forms.ListBox lst_ArrayList_public;
        private System.Windows.Forms.ListBox lst_Array_public;
        private System.Windows.Forms.ListBox lst_List_private;
        private System.Windows.Forms.ListBox lst_ArrayList_private;
        private System.Windows.Forms.ListBox lst_Array_private;
    }
}