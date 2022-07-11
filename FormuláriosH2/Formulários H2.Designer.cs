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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.paraID1 = new System.Windows.Forms.TextBox();
            this.deID1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpfBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nomeBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trocasCOLA = new System.Windows.Forms.TextBox();
            this.CopiarTROCAS = new System.Windows.Forms.Button();
            this.limparTROCAS = new System.Windows.Forms.Button();
            this.statusMSG2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.nomeBox.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
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
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "UPOKER São Paulo 1",
            "UPOKER 2",
            "UPOKER 5",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER NORDESTE",
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
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UPOKER São Paulo 1",
            "UPOKER 2",
            "UPOKER 5",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER NORDESTE",
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
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 15;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CLUBE:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusMSG2);
            this.tabPage2.Controls.Add(this.limparTROCAS);
            this.tabPage2.Controls.Add(this.CopiarTROCAS);
            this.tabPage2.Controls.Add(this.trocasCOLA);
            this.tabPage2.Controls.Add(this.valorBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.paraID1);
            this.tabPage2.Controls.Add(this.deID1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cpfBox2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.nomeBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Troca de fichas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(131, 153);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "VALOR:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "CLUBE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "CLUBE";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "UPOKER São Paulo 1",
            "UPOKER 2",
            "UPOKER 5",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER NORDESTE",
            "SUPREMA 1",
            "SUPREMA 2",
            "SUPREMA 3",
            "SUPREMA 5",
            "SUPREMA CURITIBA",
            "SUPREMA SÃO PAULO",
            "SUPREMA NORDESTE",
            "LIGA REAL CLUBE 4"});
            this.comboBox4.Location = new System.Drawing.Point(179, 111);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(149, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "UPOKER São Paulo 1",
            "UPOKER 2",
            "UPOKER 5",
            "UPOKER 7",
            "UPOKER CAMPINAS",
            "UPOKER CAMPINAS 2",
            "UPOKER CURITIBA",
            "UPOKER NORDESTE",
            "SUPREMA 1",
            "SUPREMA 2",
            "SUPREMA 3",
            "SUPREMA 5",
            "SUPREMA CURITIBA",
            "SUPREMA SÃO PAULO",
            "SUPREMA NORDESTE",
            "LIGA REAL CLUBE 4"});
            this.comboBox3.Location = new System.Drawing.Point(179, 74);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // paraID1
            // 
            this.paraID1.Location = new System.Drawing.Point(53, 111);
            this.paraID1.Name = "paraID1";
            this.paraID1.Size = new System.Drawing.Size(72, 20);
            this.paraID1.TabIndex = 11;
            // 
            // deID1
            // 
            this.deID1.Location = new System.Drawing.Point(53, 75);
            this.deID1.Name = "deID1";
            this.deID1.Size = new System.Drawing.Size(72, 20);
            this.deID1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "PARA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DE:";
            // 
            // cpfBox2
            // 
            this.cpfBox2.Location = new System.Drawing.Point(54, 42);
            this.cpfBox2.Name = "cpfBox2";
            this.cpfBox2.Size = new System.Drawing.Size(274, 20);
            this.cpfBox2.TabIndex = 7;
            this.cpfBox2.Tag = "";
            this.cpfBox2.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "CPF:";
            // 
            // nomeBox2
            // 
            this.nomeBox2.Location = new System.Drawing.Point(54, 9);
            this.nomeBox2.Name = "nomeBox2";
            this.nomeBox2.Size = new System.Drawing.Size(274, 20);
            this.nomeBox2.TabIndex = 4;
            this.nomeBox2.Tag = "Texter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "NOME:";
            // 
            // trocasCOLA
            // 
            this.trocasCOLA.Location = new System.Drawing.Point(21, 189);
            this.trocasCOLA.Multiline = true;
            this.trocasCOLA.Name = "trocasCOLA";
            this.trocasCOLA.Size = new System.Drawing.Size(307, 134);
            this.trocasCOLA.TabIndex = 22;
            // 
            // CopiarTROCAS
            // 
            this.CopiarTROCAS.Location = new System.Drawing.Point(82, 329);
            this.CopiarTROCAS.Name = "CopiarTROCAS";
            this.CopiarTROCAS.Size = new System.Drawing.Size(118, 36);
            this.CopiarTROCAS.TabIndex = 23;
            this.CopiarTROCAS.Text = "Copiar";
            this.CopiarTROCAS.UseVisualStyleBackColor = true;
            this.CopiarTROCAS.Click += new System.EventHandler(this.CopiarTROCAS_Click);
            // 
            // limparTROCAS
            // 
            this.limparTROCAS.Location = new System.Drawing.Point(210, 329);
            this.limparTROCAS.Name = "limparTROCAS";
            this.limparTROCAS.Size = new System.Drawing.Size(118, 36);
            this.limparTROCAS.TabIndex = 24;
            this.limparTROCAS.Text = "Limpar";
            this.limparTROCAS.UseVisualStyleBackColor = true;
            this.limparTROCAS.Click += new System.EventHandler(this.limparTROCAS_Click);
            // 
            // statusMSG2
            // 
            this.statusMSG2.AutoSize = true;
            this.statusMSG2.Location = new System.Drawing.Point(8, 341);
            this.statusMSG2.Name = "statusMSG2";
            this.statusMSG2.Size = new System.Drawing.Size(61, 13);
            this.statusMSG2.TabIndex = 25;
            this.statusMSG2.Text = "Copiado!✔";
            this.statusMSG2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 445);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Formulários H2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpfBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomeBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox paraID1;
        private System.Windows.Forms.TextBox deID1;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label statusMSG2;
        private System.Windows.Forms.Button limparTROCAS;
        private System.Windows.Forms.Button CopiarTROCAS;
        private System.Windows.Forms.TextBox trocasCOLA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

