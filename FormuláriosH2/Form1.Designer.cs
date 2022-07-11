namespace FormuláriosH2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpfBox = new System.Windows.Forms.TextBox();
            this.oldidBox = new System.Windows.Forms.TextBox();
            this.newidBox = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.statusMSG = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(55, 6);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(274, 20);
            this.nomeBox.TabIndex = 1;
            this.nomeBox.Tag = "Texter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID ANTIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID NOVO:";
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(55, 35);
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(274, 20);
            this.cpfBox.TabIndex = 6;
            this.cpfBox.Tag = "";
            this.cpfBox.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // oldidBox
            // 
            this.oldidBox.Location = new System.Drawing.Point(74, 61);
            this.oldidBox.Name = "oldidBox";
            this.oldidBox.Size = new System.Drawing.Size(255, 20);
            this.oldidBox.TabIndex = 7;
            this.oldidBox.Tag = "Texter";
            // 
            // newidBox
            // 
            this.newidBox.Location = new System.Drawing.Point(74, 118);
            this.newidBox.Name = "newidBox";
            this.newidBox.Size = new System.Drawing.Size(255, 20);
            this.newidBox.TabIndex = 8;
            this.newidBox.Tag = "Texter";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(13, 191);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(316, 142);
            this.Resultado.TabIndex = 9;
            // 
            // statusMSG
            // 
            this.statusMSG.AutoSize = true;
            this.statusMSG.Location = new System.Drawing.Point(10, 354);
            this.statusMSG.Name = "statusMSG";
            this.statusMSG.Size = new System.Drawing.Size(61, 13);
            this.statusMSG.TabIndex = 10;
            this.statusMSG.Text = "Copiado!✔";
            this.statusMSG.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 407);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.nomeBox);
            this.tabPage1.Controls.Add(this.statusMSG);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Resultado);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.newidBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.oldidBox);
            this.tabPage1.Controls.Add(this.cpfBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Troca de ID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CLUBE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CLUBE:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UPOKER 1",
            "UPOKER 2",
            "UPOKER 3",
            "UPOKER 4",
            "UPOKER 5",
            "UPOKER 6",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER CURITIBA 2",
            "SUPREMA 1",
            "SUPREMA 2",
            "SUPREMA 3",
            "SUPREMA 5",
            "SUPREMA CURITIBA",
            "SUPREMA SÃO PAULO",
            "SUPREMA NORDESTE",
            "LIGA REAL CLUBE 4"});
            this.comboBox1.Location = new System.Drawing.Point(74, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "UPOKER 1",
            "UPOKER 2",
            "UPOKER 3",
            "UPOKER 4",
            "UPOKER 5",
            "UPOKER 6",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER CURITIBA 2",
            "SUPREMA 1",
            "SUPREMA 2",
            "SUPREMA 3",
            "SUPREMA 5",
            "SUPREMA CURITIBA",
            "SUPREMA SÃO PAULO",
            "SUPREMA NORDESTE",
            "LIGA REAL CLUBE 4"});
            this.comboBox2.Location = new System.Drawing.Point(74, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(353, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cpfBox;
        private System.Windows.Forms.TextBox oldidBox;
        private System.Windows.Forms.TextBox newidBox;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label statusMSG;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

