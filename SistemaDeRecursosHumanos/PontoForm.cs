using SistemaDeRecursosHumanos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        }
    }
}
