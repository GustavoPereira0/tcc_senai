using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc_senai
{
    public partial class cadastrodesign : Form
    {
        public cadastrodesign()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                if (cliente.RegistroRepetido2(txtcpf.Text, txtemail.Text) == true)
                {
                    MessageBox.Show("cadastro já existe!", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    cliente.Inserir(txtnome.Text, txtcpf.Text, txtemail.Text, txtSenha.Text);
                    MessageBox.Show("Cadastro feito com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
					List<Cliente> clientes = cliente.listacliente();
					this.Hide();
					salario salario = new salario();
					salario.Show();

				}
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastrodesign_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = Convert.ToString(txtcpf.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Atualizar(txtnome.Text, txtcpf.Text, txtemail.Text, txtSenha.Text);
                MessageBox.Show("Atualizado com sucesso", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = Convert.ToString(txtcpf.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Excluir(cpf);
                MessageBox.Show("Cadastro excluido!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                txtnome.Text = "";
                txtcpf.Text = "";
                txtemail.Text = "";
                txtSenha.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

		private void label7_Click(object sender, EventArgs e)
		{
            this.Hide();
            login login = new login();
            login.Show();
		}
	}
}
