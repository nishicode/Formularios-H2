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
            this.statusMSG2 = new System.Windows.Forms.Label();
            this.limparTROCAS = new System.Windows.Forms.Button();
            this.CopiarTROCAS = new System.Windows.Forms.Button();
            this.trocasCOLA = new System.Windows.Forms.TextBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusMSG3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trocasCOLA2 = new System.Windows.Forms.TextBox();
            this.valorBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.deID2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cpfBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.nomeBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.paraID2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cpfBox4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.nomeBox4 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.nickBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nickBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(246, 47);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(274, 20);
            this.nomeBox.TabIndex = 1;
            this.nomeBox.Tag = "Texter";
            this.nomeBox.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID ANTIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID NOVO:";
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(246, 76);
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(274, 20);
            this.cpfBox.TabIndex = 6;
            this.cpfBox.Tag = "";
            this.cpfBox.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // oldidBox
            // 
            this.oldidBox.Location = new System.Drawing.Point(246, 106);
            this.oldidBox.Name = "oldidBox";
            this.oldidBox.Size = new System.Drawing.Size(255, 20);
            this.oldidBox.TabIndex = 7;
            this.oldidBox.Tag = "Texter";
            // 
            // newidBox
            // 
            this.newidBox.Location = new System.Drawing.Point(246, 163);
            this.newidBox.Name = "newidBox";
            this.newidBox.Size = new System.Drawing.Size(255, 20);
            this.newidBox.TabIndex = 8;
            this.newidBox.Tag = "Texter";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(185, 236);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(316, 142);
            this.Resultado.TabIndex = 9;
            // 
            // statusMSG
            // 
            this.statusMSG.AutoSize = true;
            this.statusMSG.Location = new System.Drawing.Point(182, 399);
            this.statusMSG.Name = "statusMSG";
            this.statusMSG.Size = new System.Drawing.Size(61, 13);
            this.statusMSG.TabIndex = 10;
            this.statusMSG.Text = "Copiado!✔";
            this.statusMSG.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 384);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 529);
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
            this.tabPage1.Size = new System.Drawing.Size(673, 503);
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
            this.comboBox2.Location = new System.Drawing.Point(246, 194);
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
            this.comboBox1.Location = new System.Drawing.Point(246, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "CLUBE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 136);
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
            this.tabPage2.Size = new System.Drawing.Size(673, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Troca de fichas M";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusMSG2
            // 
            this.statusMSG2.AutoSize = true;
            this.statusMSG2.Location = new System.Drawing.Point(170, 393);
            this.statusMSG2.Name = "statusMSG2";
            this.statusMSG2.Size = new System.Drawing.Size(61, 13);
            this.statusMSG2.TabIndex = 25;
            this.statusMSG2.Text = "Copiado!✔";
            this.statusMSG2.Visible = false;
            // 
            // limparTROCAS
            // 
            this.limparTROCAS.Location = new System.Drawing.Point(372, 381);
            this.limparTROCAS.Name = "limparTROCAS";
            this.limparTROCAS.Size = new System.Drawing.Size(118, 36);
            this.limparTROCAS.TabIndex = 24;
            this.limparTROCAS.Text = "Limpar";
            this.limparTROCAS.UseVisualStyleBackColor = true;
            this.limparTROCAS.Click += new System.EventHandler(this.limparTROCAS_Click);
            // 
            // CopiarTROCAS
            // 
            this.CopiarTROCAS.Location = new System.Drawing.Point(244, 381);
            this.CopiarTROCAS.Name = "CopiarTROCAS";
            this.CopiarTROCAS.Size = new System.Drawing.Size(118, 36);
            this.CopiarTROCAS.TabIndex = 23;
            this.CopiarTROCAS.Text = "Copiar";
            this.CopiarTROCAS.UseVisualStyleBackColor = true;
            this.CopiarTROCAS.Click += new System.EventHandler(this.CopiarTROCAS_Click);
            // 
            // trocasCOLA
            // 
            this.trocasCOLA.Location = new System.Drawing.Point(183, 241);
            this.trocasCOLA.Multiline = true;
            this.trocasCOLA.Name = "trocasCOLA";
            this.trocasCOLA.Size = new System.Drawing.Size(307, 134);
            this.trocasCOLA.TabIndex = 22;
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(293, 205);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(100, 20);
            this.valorBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "VALOR:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "CLUBE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 129);
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
            this.comboBox4.Location = new System.Drawing.Point(341, 163);
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
            this.comboBox3.Location = new System.Drawing.Point(341, 126);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // paraID1
            // 
            this.paraID1.Location = new System.Drawing.Point(215, 163);
            this.paraID1.Name = "paraID1";
            this.paraID1.Size = new System.Drawing.Size(72, 20);
            this.paraID1.TabIndex = 11;
            // 
            // deID1
            // 
            this.deID1.Location = new System.Drawing.Point(215, 127);
            this.deID1.Name = "deID1";
            this.deID1.Size = new System.Drawing.Size(72, 20);
            this.deID1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "PARA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DE:";
            // 
            // cpfBox2
            // 
            this.cpfBox2.Location = new System.Drawing.Point(216, 94);
            this.cpfBox2.Name = "cpfBox2";
            this.cpfBox2.Size = new System.Drawing.Size(274, 20);
            this.cpfBox2.TabIndex = 7;
            this.cpfBox2.Tag = "";
            this.cpfBox2.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "CPF:";
            // 
            // nomeBox2
            // 
            this.nomeBox2.Location = new System.Drawing.Point(216, 61);
            this.nomeBox2.Name = "nomeBox2";
            this.nomeBox2.Size = new System.Drawing.Size(274, 20);
            this.nomeBox2.TabIndex = 4;
            this.nomeBox2.Tag = "Texter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "NOME:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nickBox1);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.nickBox2);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.comboBox8);
            this.tabPage3.Controls.Add(this.paraID2);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.cpfBox4);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.nomeBox4);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.statusMSG3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.trocasCOLA2);
            this.tabPage3.Controls.Add(this.valorBox2);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboBox6);
            this.tabPage3.Controls.Add(this.deID2);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.cpfBox3);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.nomeBox3);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Troca de fichas O";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusMSG3
            // 
            this.statusMSG3.AutoSize = true;
            this.statusMSG3.Location = new System.Drawing.Point(50, 461);
            this.statusMSG3.Name = "statusMSG3";
            this.statusMSG3.Size = new System.Drawing.Size(61, 13);
            this.statusMSG3.TabIndex = 43;
            this.statusMSG3.Text = "Copiado!✔";
            this.statusMSG3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 42;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 36);
            this.button4.TabIndex = 41;
            this.button4.Text = "Copiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trocasCOLA2
            // 
            this.trocasCOLA2.Location = new System.Drawing.Point(26, 182);
            this.trocasCOLA2.Multiline = true;
            this.trocasCOLA2.Name = "trocasCOLA2";
            this.trocasCOLA2.Size = new System.Drawing.Size(436, 261);
            this.trocasCOLA2.TabIndex = 40;
            // 
            // valorBox2
            // 
            this.valorBox2.Location = new System.Drawing.Point(541, 296);
            this.valorBox2.Name = "valorBox2";
            this.valorBox2.Size = new System.Drawing.Size(100, 20);
            this.valorBox2.TabIndex = 39;
            this.valorBox2.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(489, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "VALOR:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(131, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "CLUBE";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
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
            this.comboBox6.Location = new System.Drawing.Point(179, 105);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(149, 21);
            this.comboBox6.TabIndex = 34;
            // 
            // deID2
            // 
            this.deID2.Location = new System.Drawing.Point(53, 106);
            this.deID2.Name = "deID2";
            this.deID2.Size = new System.Drawing.Size(72, 20);
            this.deID2.TabIndex = 32;
            this.deID2.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "ID:";
            // 
            // cpfBox3
            // 
            this.cpfBox3.Location = new System.Drawing.Point(54, 73);
            this.cpfBox3.Name = "cpfBox3";
            this.cpfBox3.Size = new System.Drawing.Size(274, 20);
            this.cpfBox3.TabIndex = 29;
            this.cpfBox3.Tag = "";
            this.cpfBox3.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "CPF:";
            // 
            // nomeBox3
            // 
            this.nomeBox3.Location = new System.Drawing.Point(54, 40);
            this.nomeBox3.Name = "nomeBox3";
            this.nomeBox3.Size = new System.Drawing.Size(186, 20);
            this.nomeBox3.TabIndex = 27;
            this.nomeBox3.Tag = "Texter";
            this.nomeBox3.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "NOME:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "CONTA DE ORIGEM";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(440, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "CONTA DE DESTINO";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(470, 108);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "CLUBE";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
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
            this.comboBox8.Location = new System.Drawing.Point(518, 105);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(149, 21);
            this.comboBox8.TabIndex = 53;
            // 
            // paraID2
            // 
            this.paraID2.Location = new System.Drawing.Point(392, 106);
            this.paraID2.Name = "paraID2";
            this.paraID2.Size = new System.Drawing.Size(72, 20);
            this.paraID2.TabIndex = 51;
            this.paraID2.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(361, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "ID:";
            // 
            // cpfBox4
            // 
            this.cpfBox4.Location = new System.Drawing.Point(393, 73);
            this.cpfBox4.Name = "cpfBox4";
            this.cpfBox4.Size = new System.Drawing.Size(274, 20);
            this.cpfBox4.TabIndex = 48;
            this.cpfBox4.Tag = "";
            this.cpfBox4.Validated += new System.EventHandler(this.ValidadorDeCpf);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(357, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "CPF:";
            // 
            // nomeBox4
            // 
            this.nomeBox4.Location = new System.Drawing.Point(393, 40);
            this.nomeBox4.Name = "nomeBox4";
            this.nomeBox4.Size = new System.Drawing.Size(186, 20);
            this.nomeBox4.TabIndex = 46;
            this.nomeBox4.Tag = "Texter";
            this.nomeBox4.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(345, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 45;
            this.label29.Text = "NOME:";
            // 
            // nickBox2
            // 
            this.nickBox2.Location = new System.Drawing.Point(392, 136);
            this.nickBox2.Name = "nickBox2";
            this.nickBox2.Size = new System.Drawing.Size(129, 20);
            this.nickBox2.TabIndex = 59;
            this.nickBox2.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(347, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 58;
            this.label16.Text = "NICK:";
            // 
            // nickBox1
            // 
            this.nickBox1.Location = new System.Drawing.Point(53, 135);
            this.nickBox1.Name = "nickBox1";
            this.nickBox1.Size = new System.Drawing.Size(129, 20);
            this.nickBox1.TabIndex = 61;
            this.nickBox1.Validated += new System.EventHandler(this.LimpadorDeWhitespace);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 138);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "NICK:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.TextBox paraID2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox cpfBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox nomeBox4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label statusMSG3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox trocasCOLA2;
        private System.Windows.Forms.TextBox valorBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox deID2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cpfBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox nomeBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox nickBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox nickBox2;
        private System.Windows.Forms.Label label16;
    }
}

