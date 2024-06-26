using EmployeeManagementSystem;
using SistemaDeRecursosHumanos;
using System;
using System.Windows.Forms;

namespace SistemaDeRecursosHumanos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            pontoForm1.Visible = false;
            escalaForm1.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Tem certeza que deseja deslogar?"
                , "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addFuncionario.Visible = false;
            salario.Visible = false;
            pontoForm1.Visible = false;
            escalaForm1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        private void btnAddFunc_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = true;
            salario.Visible = false;
            pontoForm1.Visible = false;
            escalaForm1.Visible = false;

            AddFuncionarioForm addEmForm = addFuncionario as AddFuncionarioForm;

            if(addEmForm != null)
            {
                addEmForm.RefreshData();
            }

        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = false;
            salario.Visible = true;
            pontoForm1.Visible = false;
            escalaForm1.Visible = false;
            SalarioForm salaryForm = salario as SalarioForm;

            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }
        private void btnFormPonto_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = false;
            salario.Visible = false;
            pontoForm1.Visible = true;
            escalaForm1.Visible = false;
            PontoForm salaryForm = pontoForm1 as PontoForm;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = false;
            salario.Visible = false;
            escalaForm1.Visible = false;
        }
        private void Ponto_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormEscala_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addFuncionario.Visible = false;
            salario.Visible = false;
            pontoForm1.Visible = false;
            escalaForm1.Visible = true;
            EscalaForm salaryForm = escalaForm1 as EscalaForm;

            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }

        }
    }
}