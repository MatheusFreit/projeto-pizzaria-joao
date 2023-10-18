using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parte_do_Gerente
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        private bool comboBox2Preenchido=false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Atualizar_pedido_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                MySqlConnection conexao = new MySqlConnection(data_source);
                conexao.Open();

                string sql1 = "SELECT pizzas.*, pizzas.borda_id, pizzas_sabor.sabores_id, status_id as nome_status " +
                              "FROM pedidos " +
                              "INNER JOIN pizzas ON pedidos.pizzas_id = pizzas.id " +
                              "INNER JOIN pizzas_sabor ON pizzas.id = pizzas_sabor.pizzas_id " +
                              "INNER JOIN status ON pedidos.status_id = status.id " +
                              "ORDER BY pedidos.id DESC";

                MySqlCommand command = new MySqlCommand(sql1, conexao);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) // Usando um loop para obter todos os resultados
                {
                    string[] pedidoListas = new string[5];
                    pedidoListas[0] = reader["id"].ToString();
                    
                    Dictionary<string, string> bordas = new Dictionary<string, string>// Adicione mais mapeamentos conforme necessário
                            {
                                {"1", "Borda de Cheddar"},
                                {"2", "Borda de Catupiry"},
                                {"3", "Borda de Chocolate" }
                                
                            };
                    pedidoListas[1] = bordas[reader["borda_id"].ToString()];
                    
                    Dictionary<string, string> massas = new Dictionary<string, string>// Adicione mais mapeamentos conforme necessário
                            {
                                {"1", "Comun"},
                                {"2", "Integral"},
                                {"3", "Massa Temperada" }

                            };
                    pedidoListas[2] = massas[reader["massas_id"].ToString()];
                    
                    Dictionary<string, string> sabores = new Dictionary<string, string>// Adicione mais mapeamentos conforme necessário
                            {
                                    {"1","Frango com Catupiry"},
                                    { "2","4 Queijos"},
                                    { "3","Calabresa"},
                                    { "4","File com Cheddar"},
                                    { "5","Lombinho"},
                                    { "6","Portuguesa"},
                                    { "7","Margherita"},
                                    { "8","Mista"},

                            };
                    pedidoListas[3] = sabores[reader["sabores_id"].ToString()];
                    

                    Dictionary<string, string> status = new Dictionary<string, string>
                    {
                        { "1", "EM PRODUÇÃO" },
                        { "2", "EM ENTREGA" },
                        { "3", "CONCLUIDO"},
                    };
                    pedidoListas[4] = status[reader["nome_status"].ToString()];

                    ListViewItem item = new ListViewItem(pedidoListas);
                    listView1.Items.Add(item); // Adicionando o item à ListView
                }
              
                reader.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         

        }

        private void Excluirpedido_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                MySqlConnection conexao = new MySqlConnection(data_source);
                conexao.Open();

                if (listView1.SelectedItems.Count > 0)
                {
                    string idSelecionado = listView1.SelectedItems[0].SubItems[0].Text;

                    // Construir a string SQL com o parâmetro correto
                    string sqlDelete = "DELETE FROM pedidos WHERE pizzas_id = @selecao";

                    MySqlCommand commandDelete = new MySqlCommand(sqlDelete, conexao);
                    commandDelete.Parameters.AddWithValue("@selecao", idSelecionado);

                    int linhasAfetadas = commandDelete.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Registro removido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado ou erro ao remover o registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção
                MessageBox.Show(ex.Message);
            }
        }

        private void Statuspp2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox2Preenchido)
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                using (conexao = new MySqlConnection(data_source))
                {
                    try
                    {
                        conexao.Open();

                        string sql = "SELECT * FROM status";
                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        // Limpe os itens existentes no ComboBox
                        Statuspp2.Items.Clear();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                Statuspp2.Items.Add(reader["tipo"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                MySqlConnection conexao = new MySqlConnection(data_source);
                conexao.Open();

                if (listView1.SelectedItems.Count > 0)
                {
                    string selecao = listView1.SelectedItems[0].SubItems[0].Text;
                    textBox1.Text = selecao;

                    string statusSelecionado = listView1.SelectedItems[0].SubItems[4].Text;

                    textBox2.Text = statusSelecionado;
                    MessageBox.Show("Pedido encaminhado para alteração", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    string sql1 = "SELECT pizzas.*, pizzas.borda_id, pizzas_sabor.sabores_id, status_id as nome_status " +
                                      "FROM pedidos " +
                                      "INNER JOIN pizzas ON pedidos.pizzas_id = pizzas.id " +
                                      "INNER JOIN pizzas_sabor ON pizzas.id = pizzas_sabor.pizzas_id " +
                                      "INNER JOIN status ON pedidos.status_id = status.id " +
                                      "where pedidos.pizzas_id =@selecao";

                    MySqlCommand command = new MySqlCommand(sql1, conexao);
                    command.Parameters.AddWithValue("@selecao", selecao);
                    MySqlDataReader reader = command.ExecuteReader();

                    


                    while (reader.Read()) // Usando um loop para obter todos os resultados
                    {
                        string[] pedidoListas2 = new string[4];
                        pedidoListas2[0] = reader["id"].ToString();

                        Dictionary<string, string> bordas2 = new Dictionary<string, string>// Adicione mais mapeamentos conforme necessário
                            {
                                {"1", "Borda de Cheddar"},
                                {"2", "Borda de Catupiry"},
                                {"3", "Borda de Chocolate" }

                            };
                        pedidoListas2[1] = bordas2[reader["borda_id"].ToString()];

                        Dictionary<string, string> massas2 = new Dictionary<string, string>// Adicione mais mapeamentos conforme necessário
                            {
                                {"1", "Comun"},
                                {"2", "Integral"},
                                {"3", "Massa Temperada" }

                            };
                        pedidoListas2[2] = massas2[reader["massas_id"].ToString()];
                                                
                        Dictionary<string, string> status2 = new Dictionary<string, string>
                    {
                        { "1", "EM PRODUÇÃO" },
                        { "2", "EM ENTREGA" },
                        { "3", "CONCLUIDO"},
                    };
                        pedidoListas2[3] = status2[reader["nome_status"].ToString()];

                        

                        ListViewItem item2 = new ListViewItem(pedidoListas2);
                        listView2.Items.Add(item2);
                    }
                    reader.Close();
                    conexao.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
            }
        }

        private void atualizarpedido_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
                MySqlConnection conexao = new MySqlConnection(data_source);
                conexao.Open();

                if (textBox1.Text !=null)
                {
                    string selecao = textBox1.Text;
                    string novoStatus = Statuspp2.SelectedIndex.ToString();
                    int novoStatusInt = int.Parse(novoStatus)+1;

                    
                    string sql2 = "UPDATE pedidos SET status_id = @novoStatus WHERE pizzas_id= @selecao";
                    MySqlCommand command2 = new MySqlCommand(sql2, conexao);
                    command2.Parameters.AddWithValue("@novoStatus", novoStatusInt);
                    command2.Parameters.AddWithValue("@selecao", selecao);
                    command2.ExecuteNonQuery();

                    MessageBox.Show($"Pedido {selecao}, Atualizado ", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                conexao.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
            }


        }

        private void REGISTRAR_SABOR_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
            MySqlConnection conexao = new MySqlConnection(data_source);
            conexao.Open();
            try
            {
                if (textBox3.Text != null) //SABOR
                {
                    string sql = "SELECT * FROM sabores ";
                    string sqlinserir = "INSERT INTO sabores(nome) VALUES ('" + @textBox3.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sqlinserir, conexao);
                    comando.Parameters.AddWithValue("@nome", textBox3.Text);
                    comando.ExecuteNonQuery();
                                      
                    MessageBox.Show($"Sabor {textBox3.Text} de pizzas, foi adicionando com sucessos","Sabores novos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
            }
        }

        private void REGISTRO_BORDAS_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
            MySqlConnection conexao = new MySqlConnection(data_source);
            conexao.Open();
            try
            {
                if (textBox9.Text != null) //BORDAS
                {
                    string sql = "SELECT * FROM sabores ";
                    string sqlinserir = "INSERT INTO bordas(tipo) VALUES ('" + @textBox9.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sqlinserir, conexao);
                    comando.Parameters.AddWithValue("@nome", textBox9.Text);
                    comando.ExecuteNonQuery();

                    MessageBox.Show($"Nova borda de {textBox9.Text}, foi adicionando com sucessos", "Sabores novos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
            }
        }

        private void REGISTRO_MASSAS_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=127.0.0.1;username=root;password=;database=pizzaria";
            MySqlConnection conexao = new MySqlConnection(data_source);
            conexao.Open();
            try
            {
                if (textBox14.Text != null) //BORDAS
                {
                    string sql = "SELECT * FROM sabores ";
                    string sqlinserir = "INSERT INTO massas(tipo) VALUES ('" + @textBox14.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sqlinserir, conexao);
                    comando.Parameters.AddWithValue("@nome", textBox14.Text);
                    comando.ExecuteNonQuery();

                    MessageBox.Show($"Novo tipo de massa {textBox14.Text}, foi adicionando com sucessos", "Sabores novos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao servidor: " + ex.Message);
            }

        }
    }
}


