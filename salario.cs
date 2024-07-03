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
	public partial class salario : Form
	{
		public salario()
		{
			InitializeComponent();
		}

		public void btnInserir_Click(object sender, EventArgs e)
		{
			cssalario cssalario = new cssalario();
			int salario = Convert.ToInt32(txtsalario.Text);
			int gasto = Convert.ToInt32(txtgasto.Text);
			int sobra = salario - gasto;
			string mes = Convert.ToString(cbxmes.Text);
			lblsobra.Text = sobra.ToString();
			cssalario.Inserir(txtsalario.Text, txtgasto.Text, lblsobra.Text,cbxmes.Text);
			MessageBox.Show("salario inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
			List<cssalario> cssalarios = cssalario.listacssalario();
			dgvsalario.DataSource = cssalarios;
		}
		private void dgvsalario_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgvsalario.Rows[e.RowIndex];
				this.dgvsalario.Rows[e.RowIndex].Selected = true;
				txtsalario.Text = row.Cells[0].Value.ToString();
				txtgasto.Text = row.Cells[1].Value.ToString();
				cbxmes.Text = row.Cells[2].Value.ToString();
			}
		}

		public void salario_Load(object sender, EventArgs e)
		{
			cssalario cssalario = new cssalario();
			List<cssalario> cssalarios = cssalario.listacssalario();
			dgvsalario.DataSource = cssalarios;
		}

		private void cbxmes_SelectedIndexChanged(object sender, EventArgs e)
		{
			string mes = cbxmes.SelectedValue.ToString();
		}

		private void btnhistorico_Click(object sender, EventArgs e)
		{
			this.Hide();
			Historico historico = new Historico();
			historico.Show();
		}
	}
	}
