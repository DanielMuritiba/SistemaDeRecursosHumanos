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
    public partial class EscalaForm : UserControl
    {
        public static string nomeArquivoBD = "BancoDeDado.mdf";

        // Caminho relativo para o arquivo do banco de dados
        public static string caminhoBD = $"{Environment.CurrentDirectory}\\{nomeArquivoBD}";

        // String de conexão com AttachDbFilename
        public static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoBD};Integrated Security=True";
        SqlConnection connect = new SqlConnection(connectionString);
        private Dashboard dashboard;
        public EscalaForm()
        {
            InitializeComponent();

            dashboard = new Dashboard();
            dashboard.ArredondarFunc(panel1, 20);
            dashboard.ArredondarFunc(panel2, 20);

            mostraFuncionarios();
            desabilitaCampos();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            mostraFuncionarios();
            desabilitaCampos();
        }

        public void desabilitaCampos()
        {
            labelCodFunc.Enabled = false;
            labelNome.Enabled = false;
            labelCargo.Enabled = false;
        }

        public void mostraFuncionarios()
        {
            SalarioInfo ed = new SalarioInfo();
            List<SalarioInfo> listData = ed.listaInfoSalario();

            dataGridView1.DataSource = listData;
        }

        private void btnAtualizaSalarioClick(object sender, EventArgs e)
        {
            if (labelCodFunc.Text == ""
                || labelNome.Text == ""
                || labelCargo.Text == ""
                || labelEscala.Text == "")
            {
                MessageBox.Show("Por favor, preencha os espaços em branco", "Mensagem de erro"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Tem certeza que deseja atualiza o funcionário: "
                    + labelNome.Text.Trim() + "?", "Mensagem de confirmação"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE VPL_FUNCIONARIO SET escala = @escala" +
                                ", atualizarData = @updateData WHERE funcionarioId = @funcionarioID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@escala", labelEscala.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@funcionarioID", labelCodFunc.Text.Trim());

                                cmd.ExecuteNonQuery();

                                mostraFuncionarios();

                                MessageBox.Show("Atualizado com sucesso!"
                                    , "Mensagem informativa", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                limpaCampos();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex, "Mensagem de erro"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelado", "Mensagem informativa"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void limpaCampos()
        {
            labelCodFunc.Text = "";
            labelNome.Text = "";
            labelCargo.Text = "";
            labelEscala.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                labelCodFunc.Text = row.Cells[0].Value.ToString();
                labelNome.Text = row.Cells[1].Value.ToString();
                labelCargo.Text = row.Cells[4].Value.ToString();
                labelEscala.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnLimpaSalario_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
