using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite o nome do usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Digite a senha do usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "admin" || maskedTextBox1.Text == "112233")
            {
                string nomeDoProcesso = "Parte do Gerente.exe";

                Process[] processos = Process.GetProcessesByName(nomeDoProcesso);
                if (processos.Length > 0)
                {
                    // O processo já está em execução
                    MessageBox.Show("O processo já está em execução.");
                }
                else {
                    string caminhoDoExe = @"E:\CURSO DE PROGRAMAÇÃO 2\C#\Projeto_Pessoal\windows forms\Pizzaria do joao\Pizzaria do joao\Parte do Gerente\Parte do Gerente\bin\Debug\Parte do Gerente.exe";
                    Process.Start(caminhoDoExe);
                    
                }
                this.Hide();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Usuario e senha, nao estão certo!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                maskedTextBox1.Text = "";
            }
        }
    }
}
