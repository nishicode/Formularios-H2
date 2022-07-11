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

        private void LimpadorDeNome(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox Variavel1 = (TextBox)sender;
            Variavel1.Text.Trim();
        }

        private void ValidadorDeCpf(object sender, EventArgs e)
        {
            Regex ValidarCpf = new Regex(@"^\d{11}");
            bool Validar_Cpf = ValidarCpf.IsMatch(cpfBox.Text);
            if (Validar_Cpf)
            {
                string n1 = cpfBox.Text.Substring(0, 3);
                string n2 = cpfBox.Text.Substring(3, 3);
                string n3 = cpfBox.Text.Substring(6, 3);
                string n4 = cpfBox.Text.Substring(9, 2);
                cpfBox.Text = String.Format("{0}.{1}.{2}-{3}", n1, n2, n3, n4);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "==============================\r\nTROCA DE ID\r\n";
            texto += "NOME: " + nomeBox.Text + "\r\n";
            texto += "CPF: " + cpfBox.Text + "\r\n\r\n";
            texto += "ID ANTIGO: " + comboBox1.Text + " - " + oldidBox.Text + "\r\n";
            texto += "ID NOVO: " + comboBox2.Text + " - " + newidBox.Text + "\r\n\r\n";
            texto += "ENVIAR FICHAS PARA NOVO ID\r\n==============================";

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
    }
}
