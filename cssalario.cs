using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc_senai
{
    public class cssalario
    {
        public int id_financeiro { get; set; }
        public string salario { get; set; }
        public string gasto { get; set; }
        public string sobra { get; set; }
        public string mes { get; set; }
        

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; port=3306; database=tcc_senai; user=root; password=; charset=uft8");
        public List<cssalario> listacssalario()
        {
            List<cssalario> li = new List<cssalario>();
            string mysql = "SELECT * FROM financeiro";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cssalario sa = new cssalario();
                sa.id_financeiro = Convert.ToInt32(dr["id_financeiro"]);
                sa.salario = Convert.ToString(dr["salario"]);
                sa.gasto = Convert.ToString(dr["gasto"]);
                sa.sobra = Convert.ToString(dr["sobra"]);
                sa.mes = Convert.ToString(dr["mes"]);
                li.Add(sa);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Atualizar(string salario, string gasto, string mes)
        {
            string mysql = "UPDATE financeiro SET salario='" + salario + "', gasto='" + gasto + "', '" + mes +"'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Inserir(string salario, string gasto, string sobra, string mes)
        {
            string mysql = "INSERT INTO financeiro(salario,gasto,sobra,mes) VALUES ('" + salario + "', '" + gasto + "', '" + sobra + "', '" + mes + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
