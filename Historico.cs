using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Tcc_senai
{
    public partial class Historico : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1; port=3306; database=tcc_senai; user=root; password=;");

        public Historico()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgvhistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvhistorico.Rows[e.RowIndex].Selected = true;
            }
        }

        private void cbxmes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            List<cssalario> li = new List<cssalario>();
            string query = "SELECT * FROM financeiro WHERE mes = @mes";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@mes", cbxmes.SelectedItem.ToString());

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cssalario salario = new cssalario();
                salario.salario = dr["salario"].ToString();
                salario.gasto = dr["gasto"].ToString();
                salario.sobra = dr["sobra"].ToString();
                salario.mes = dr["mes"].ToString();
                li.Add(salario);
            }
            dr.Close();
            dgvhistorico.DataSource = li;
            con.Close();
        }
    }
}
