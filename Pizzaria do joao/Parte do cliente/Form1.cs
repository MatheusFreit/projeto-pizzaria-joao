using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Pizzaria_do_joao
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        private bool comboBox1Preenchido = false;
        private bool comboBox2Preenchido = false;
        private bool combobox_saborpreenchido = false;
        private bool comboBox4preenchido = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_sabor_Click(object sender, EventArgs e)
        {
            if (combobox_sabor.SelectedIndex >= 0 && comboBox4.SelectedIndex >= 0)
            {
                if (lblsabor.Text.Split('+').Length < 2)
                {
                    string saborSelecionado1 = combobox_sabor.SelectedItem.ToString();
                    string saborSelecionado2 = comboBox4.SelectedItem.ToString();

                    if (!string.IsNullOrEmpty(saborSelecionado1) && !string.IsNullOrEmpty(saborSelecionado2))
                    {
                        using (conexao = new MySqlConnection("datasource=127.0.0.1;username=root;password=;database=pizzaria"))
                        {
                            try
                            {
                                conexao.Open();

                                // Verifica se os sabores selecionados existem no banco de dados
                                string sql = "SELECT COUNT(*) FROM sabores WHERE nome IN (@sabor1, @sabor2)";
                                MySqlCommand comando = new MySqlCommand(sql, conexao);
                                comando.Parameters.AddWithValue("@sabor1", saborSelecionado1);
                                comando.Parameters.AddWithValue("@sabor2", saborSelecionado2);

                                int count = Convert.ToInt32(comando.ExecuteScalar());

                                if (count == 2)
                                {
                                    lblsabor.Text = saborSelecionado1 + " + " + saborSelecionado2;
                                }
                                else
                                {
                                    MessageBox.Show("Alguns dos sabores selecionados não estão disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter os sabores selecionados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Somente dois sabores podem ser adicionados.", "Sabores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione os dois sabores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // Adiciona os sabores na tela lblsabor

        private void Retirando_sabor_Click(object sender, EventArgs e) // Retira o sabor do pedido, antes de enviar para o banco
        {
            // Divide a string nos caracteres '+'
            string[] sabores = lblsabor.Text.Split('+');

            // Verifica se há pelo menos um sabor a ser removido
            if (sabores.Length > 0)
            {
                // Remove o último sabor
                Array.Resize(ref sabores, sabores.Length - 1);

                // Atualiza lblsabor.Text com os sabores restantes
                lblsabor.Text = string.Join(" + ", sabores);
            }
        }
               
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Seleciona a borda
        {
            if (!comboBox1Preenchido)
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                using (conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = "SELECT * FROM bordas";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["tipo"].ToString());
                            }

                            comboBox1Preenchido = true; // Indica que o ComboBox foi preenchido
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Seleciona a massa
        {

            if (!comboBox2Preenchido)
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                using (conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = "SELECT * FROM massas";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader["tipo"].ToString());
                            }

                            comboBox2Preenchido = true; // Indica que o ComboBox foi preenchido
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
                    }
                }
            }
        }

        private void combobox_sabor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!combobox_saborpreenchido)
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                using (conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = "SELECT * FROM sabores ";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                combobox_sabor.Items.Add(reader["nome"].ToString());
                            }

                            combobox_saborpreenchido = true; // Indica que o ComboBox foi preenchido
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
                    }
                }
            }

        } // Lista de sabores da primeira seleção

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox4preenchido)
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                using (conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = "SELECT * FROM sabores ";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox4.Items.Add(reader["nome"].ToString());
                            }

                            comboBox4preenchido = true; // Indica que o ComboBox foi preenchido
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
                    }
                }
            }

        } // Lista de sabores da segunda seleção

        private void Button1_Click(object sender, EventArgs e) // Envia o pedido para o banco de dados
        {
            try
            {
                
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                conexao = new MySqlConnection(data_source);

                conexao.Open();
                string sql1 = "INSERT INTO pizzas(borda_id,massas_id)" +
                    "VALUES ('" + comboBox1.SelectedIndex.ToString() + "'," + comboBox2.SelectedIndex.ToString() + ")";

                MySqlCommand comando = new MySqlCommand(sql1, conexao);

                comando.ExecuteNonQuery(); // Execute a inserção
                  int lastInsertID = (int)comando.LastInsertedId; // Obtenha o último ID inserido

                string sql2 = "INSERT INTO pizzas_sabor(pizzas_id, sabores_id)" +
                    " VALUES ('" + lastInsertID.ToString() + "','" + combobox_sabor.SelectedIndex.ToString() + "'), ('" + lastInsertID.ToString() + "','" + comboBox4.SelectedIndex.ToString() + "')";
              
                MySqlCommand comando2 = new MySqlCommand(sql2, conexao);
                comando2.ExecuteNonQuery(); // Execute a segunda inserção

                int status_id = 1; 
                string sql3 = "INSERT INTO pedidos(pizzas_id, status_id) VALUES ('" + lastInsertID.ToString() + "','" + status_id + "')";

                MySqlCommand comando3 = new MySqlCommand(sql3, conexao);
                comando3.ExecuteNonQuery();

                MessageBox.Show($"Pedido realizado com sucesso, numero do pedido {lastInsertID}", "Pedido realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comando.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }

        }

        private void Procurar_pedido_Click(object sender, EventArgs e) //Vai procurar o pedido no db
        {

            try
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                conexao = new MySqlConnection(data_source);
                conexao.Open();

                string numero = numeropedido.Text;
                string sql1 = "SELECT pedidos.*, pizzas.borda_id, pizzas_sabor.sabores_id, status_id as nome_status " +
                 "FROM pedidos " +
                 "INNER JOIN pizzas ON pedidos.pizzas_id = pizzas.id " +
                 "INNER JOIN pizzas_sabor ON pizzas.id = pizzas_sabor.pizzas_id " +
                 "INNER JOIN status ON pedidos.status_id = status.id " +
                 "WHERE pizzas.id = @numero";

                MySqlCommand command = new MySqlCommand(sql1, conexao);
                command.Parameters.AddWithValue("@numero", numero);

                MySqlDataReader reader = command.ExecuteReader();

                Dictionary<int, string> statusMap = new Dictionary<int, string>();
                statusMap.Add(1, "EM PRODUÇÃO");
                statusMap.Add(2, "EM ENTREGA");
                statusMap.Add(3, "CONCLUIDO");

                while (reader.Read())
                {
                    int idStatus = reader.GetInt32("status_id");

                    if (statusMap.ContainsKey(idStatus))
                    {
                        string nomeStatus = statusMap[idStatus];
                        statuspedido.Text = nomeStatus;
                    }
                    
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conexao.Close(); }

        }

        private void Sistema_Click(object sender, EventArgs e)
        {
            string nomeDoProcesso = "login.exe";

            Process[] processos = Process.GetProcessesByName(nomeDoProcesso);

            if (processos.Length > 0)
            {
                // O processo já está em execução
                MessageBox.Show("O processo já está em execução.");
            }
            else
            {
              string caminhoDoExe = @"E:\CURSO DE PROGRAMAÇÃO 2\C#\Projeto_Pessoal\windows forms\Pizzaria do joao\Pizzaria do joao\login e senha\login\bin\Debug\\login.exe";
                
                Process.Start(caminhoDoExe);
            }
            Thread.Sleep(5000);
        }
    }
}

