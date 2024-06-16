using SistemaDeRecursosHumanos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class PontoForm : UserControl
    {

        public static string nomeArquivoBD = "BancoDeDado.mdf";

        // Caminho relativo para o arquivo do banco de dados
        public static string caminhoBD = $"{Environment.CurrentDirectory}\\BancoDeDado.mdf";
        public static string caminhoPastaDirectory = $"{Environment.CurrentDirectory}\\Directory";

        // String de conexão com AttachDbFilename
        public static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoBD};Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);

        private Dashboard dashboard;
        public PontoForm()
        {
            InitializeComponent();

            dashboard = new Dashboard();
            dashboard.ArredondarFunc(panel2, 10);
            dashboard.ArredondarFunc(panel1, 10);


        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntradaHorario_Click(object sender, EventArgs e)
        {
            btnReajuste.Show();
            btnSalvar.Show();
            DateTime currentTime = DateTime.Now;
            // Exibe o tempo atual no label
            labelHoraEntrada.Text = currentTime.ToString("HH:mm:ss");

            // Define o horário limite como 8:30
            TimeSpan limiteInicio = new TimeSpan(8, 20, 0);
            TimeSpan limiteFim = new TimeSpan(8, 40, 0);

            // Verifica se o horário atual é maior que 8:30
            if (currentTime.TimeOfDay > limiteInicio && currentTime.TimeOfDay < limiteFim)
            {
                squareEntrada.BackColor = System.Drawing.Color.Green; // Muda a cor do texto para vermelho

            }
            else
            {
                squareEntrada.BackColor = System.Drawing.Color.Red; // Muda a cor do texto para preto (ou a cor original)

            }
        }
        private void btnSaidaHorario_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            // Exibe o tempo atual no label
            labelHoraSaida.Text = currentTime.ToString("HH:mm:ss");

            // Define o horário limite como 18:00
            TimeSpan limiteInicio = new TimeSpan(17, 50, 0);
            TimeSpan limiteFim = new TimeSpan(18, 10, 0);

            if (currentTime.TimeOfDay > limiteInicio && currentTime.TimeOfDay < limiteFim)
            {
                squareSaida.BackColor = System.Drawing.Color.Green; // Muda a cor do texto para vermelho

            }
            else
            {
                squareSaida.BackColor = System.Drawing.Color.Red; // Muda a cor do texto para preto (ou a cor original)
            }
        }

        private void labelNome_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto digitado no labelNome
            string nomePesquisado = labelNome.Text;
            // Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(nomePesquisado))
            {
                btnSaidaHorario.Show();
                btnEntradaHorario.Show();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    connection.Open();

                    // Define a consulta SQL parametrizada
                    string sql = "SELECT funcionarioId, nomeFuncionario, cargo " +
                                 "FROM VPL_FUNCIONARIO " +
                                 "WHERE nomeFuncionario LIKE @labelNome";

                    // Cria um comando SQL parametrizado
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Adiciona o parâmetro @labelNome ao comando
                        command.Parameters.AddWithValue("@labelNome", "%" + nomePesquisado + "%");

                        // Executa o comando e obtém um leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verifica se há linhas retornadas
                            if (reader.Read())
                            {
                                // Atribui os valores das colunas diretamente às labels
                                codLabel.Text = reader["funcionarioId"].ToString();
                                funcLabel.Text = reader["nomeFuncionario"].ToString();
                                cargoLabel.Text = reader["cargo"].ToString();
                            }
                            else
                            {
                                // Caso não haja resultados, limpa o texto das labels
                                codLabel.Text = "";
                                funcLabel.Text = "";
                                cargoLabel.Text = "";

                                MessageBox.Show("Nenhum funcionário encontrado com esse nome.");
                            }
                        }
                    }

                    // Fecha a conexão
                    connection.Close();
                }
            }
            else
            {
                // Caso o texto esteja vazio, limpa o texto das labels
                btnSaidaHorario.Hide();
                btnEntradaHorario.Hide();
                labelHoraEntrada.Text = "";
                labelHoraSaida.Text = "";
                codLabel.Text = "";
                funcLabel.Text = "";
                cargoLabel.Text = "";
                btnReajuste.Hide();
                btnSalvar.Hide();
                squareEntrada.BackColor = System.Drawing.Color.White;
                squareSaida.BackColor = System.Drawing.Color.White;
            }
        }
        private void labelCodFunc_TextChanged(object sender, EventArgs e)
        {
            // Obtém o texto digitado no labelNome
            string codPesquisado = labelCodFunc.Text;
            // Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(codPesquisado))
            {
                btnSaidaHorario.Show();
                btnEntradaHorario.Show();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão
                    connection.Open();

                    // Define a consulta SQL parametrizada
                    string sql = "SELECT funcionarioId, nomeFuncionario, cargo " +
                                 "FROM VPL_FUNCIONARIO " +
                                 "WHERE funcionarioId LIKE @labelCodFunc";

                    // Cria um comando SQL parametrizado
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Adiciona o parâmetro @labelNome ao comando
                        command.Parameters.AddWithValue("@labelCodFunc", "%" + codPesquisado + "%");

                        // Executa o comando e obtém um leitor de dados
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verifica se há linhas retornadas
                            if (reader.Read())
                            {
                                // Atribui os valores das colunas diretamente às labels
                                codLabel.Text = reader["funcionarioId"].ToString();
                                funcLabel.Text = reader["nomeFuncionario"].ToString();
                                cargoLabel.Text = reader["cargo"].ToString();
                            }
                            else
                            {
                                // Caso não haja resultados, limpa o texto das labels
                                codLabel.Text = "";
                                funcLabel.Text = "";
                                cargoLabel.Text = "";

                                MessageBox.Show("Nenhum funcionário encontrado com esse código.");
                            }
                        }
                    }

                    // Fecha a conexão
                    connection.Close();
                }
            }
            else
            {
                // Caso o texto esteja vazio, limpa o texto das labels
                btnSaidaHorario.Hide();
                btnEntradaHorario.Hide();
                btnReajuste.Hide();
                btnSalvar.Hide();
                labelHoraEntrada.Text = "";
                labelHoraSaida.Text = "";
                codLabel.Text = "";
                funcLabel.Text = "";
                cargoLabel.Text = "";
                squareEntrada.BackColor = System.Drawing.Color.White;
                squareSaida.BackColor = System.Drawing.Color.White;
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private DataTable SearchDatabase(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            labelHoraEntrada.ReadOnly = false;
            labelHoraSaida.ReadOnly = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            labelHoraEntrada.ReadOnly = true;
            labelHoraSaida.ReadOnly = true;

            string entrada = labelHoraEntrada.Text;
            string saida = labelHoraSaida.Text;

            // Formato esperado para o horário (HH:mm:ss)
            string formatoHora = "HH:mm:ss";

            // Variáveis para armazenar os objetos DateTime
            DateTime entradaDateTime;
            DateTime saidaDateTime;

            // Tenta converter a string de entrada em DateTime
            if (DateTime.TryParseExact(entrada, formatoHora, CultureInfo.InvariantCulture, DateTimeStyles.None, out entradaDateTime))
            {
                // Define os limites de horário
                TimeSpan limiteInicio = new TimeSpan(8, 20, 0);
                TimeSpan limiteFim = new TimeSpan(8, 40, 0);

                // Verifica se o horário de entrada está dentro do intervalo
                if (entradaDateTime.TimeOfDay > limiteInicio && entradaDateTime.TimeOfDay < limiteFim)
                {
                    squareEntrada.BackColor = System.Drawing.Color.Green; // Muda a cor do fundo para verde
                }
                else
                {
                    squareEntrada.BackColor = System.Drawing.Color.Red; // Muda a cor do fundo para vermelho
                }
            }
            else
            {
                MessageBox.Show("Formato inválido para hora de entrada: " + entrada);
            }

            // Tenta converter a string de saída em DateTime
            if (DateTime.TryParseExact(saida, formatoHora, CultureInfo.InvariantCulture, DateTimeStyles.None, out saidaDateTime))
            {
                // Define os limites de horário
                TimeSpan limiteInicio = new TimeSpan(17, 50, 0);
                TimeSpan limiteFim = new TimeSpan(18, 10, 0);

                // Verifica se o horário de entrada está dentro do intervalo
                if (saidaDateTime.TimeOfDay > limiteInicio && saidaDateTime.TimeOfDay < limiteFim)
                {
                    squareSaida.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    squareSaida.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Formato inválido para hora de saída: " + saida);
            }
        }
    }
}
