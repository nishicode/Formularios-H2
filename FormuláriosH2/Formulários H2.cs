using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FormuláriosH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpadorDeWhitespace(object sender, EventArgs e)
        {
            TextBox Variavel1 = (TextBox)sender;
            Variavel1.Text = Variavel1.Text.Trim();
        }

        private void ValidadorDeCpf(object sender, EventArgs e)
        {
            this.LimpadorDeWhitespace(sender, e);
            TextBox Variavel1 = (TextBox)sender;
            Regex ValidarCpf = new Regex(@"^\d{11}");
            bool Validar_Cpf = ValidarCpf.IsMatch(Variavel1.Text);
            if (Validar_Cpf)
            {
                string n1 = Variavel1.Text.Substring(0, 3);
                string n2 = Variavel1.Text.Substring(3, 3);
                string n3 = Variavel1.Text.Substring(6, 3);
                string n4 = Variavel1.Text.Substring(9, 2);
                Variavel1.Text = String.Format("{0}.{1}.{2}-{3}", n1, n2, n3, n4);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "==============================\r\n**TROCA DE ID**\r\n";
            texto += "**NOME:** " + nomeBox.Text + "\r\n";
            texto += "**CPF:** " + cpfBox.Text + "\r\n\r\n";
            texto += "**ID ANTIGO:** " + comboBox1.Text + " - " + oldidBox.Text + "\r\n";
            texto += "**ID NOVO:** " + comboBox2.Text + " - " + newidBox.Text + "\r\n\r\n";
            texto += "**ENVIAR FICHAS PARA NOVO ID**\r\n==============================";

            Resultado.Text = texto;
            Clipboard.SetText(texto);

            statusMSG.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomeBox.Text = "";
            cpfBox.Text = "";
            oldidBox.Text = "";
            newidBox.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            Resultado.Text = "";

            statusMSG.Visible = false;
        }


        private void CopiarTROCAS_Click(object sender, EventArgs e)
        {
            string texto1 = "==============================\r\n**TROCA FICHAS (MESMA TITULARIDADE)**\r\n\r\n";
            texto1 += "**NOME:** " + nomeBox2.Text + "\r\n";
            texto1 += "**CPF:** " + cpfBox2.Text + "\r\n\r\n";
            texto1 += "**DE:** " + comboBox3.Text + " - " + deID1.Text + "\r\n";
            texto1 += "**PARA:** " + comboBox4.Text + " - " + paraID1.Text + "\r\n\r\n";
            texto1 += "**VALOR:** " + valorBox.Text + " FICHAS\r\n==============================";

            trocasCOLA.Text = texto1;
            Clipboard.SetText(texto1);

            statusMSG2.Visible = true;
        }

        private void limparTROCAS_Click(object sender, EventArgs e)
        {
            nomeBox2.Text = "";
            cpfBox2.Text = "";
            deID1.Text = "";
            paraID1.Text = "";
            valorBox.Text = "";
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            trocasCOLA.Text = "";

            statusMSG2.Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto2 = "==============================\r\n**TROCA FICHAS**\r\n\r\n";
            texto2 += "**NOME:** " + nomeBox3.Text + "\r\n";
            texto2 += "**CPF:** " + cpfBox3.Text + "\r\n";
            texto2 += "**CONTA DE ORIGEM:** " + comboBox6.Text + " - " + deID2.Text + "\r\n";
            texto2 += "**NICK:** " + nickBox1.Text + "\r\n\r\n";

            texto2 += "**NOME:** " + nomeBox4.Text + "\r\n";
            texto2 += "**CPF:** " + cpfBox4.Text + "\r\n";
            texto2 += "**CONTA DE ORIGEM:** " + comboBox8.Text + " - " + paraID2.Text + "\r\n";
            texto2 += "**NICK:** " + nickBox2.Text + "\r\n\r\n";

            texto2 += "**VALOR:** " + valorBox2.Text + " FICHAS\r\n==============================";

            trocasCOLA2.Text = texto2;
            Clipboard.SetText(texto2);

            statusMSG3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nomeBox3.Text = "";
            cpfBox3.Text = "";
            deID2.Text = "";
            paraID2.Text = "";
            nickBox1.Text = "";
            nickBox2.Text = "";
            valorBox2.Text = "";
            comboBox6.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;

            trocasCOLA2.Text = "";

            statusMSG3.Visible = false;
        }
    }
}
