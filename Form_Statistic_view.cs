using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace KTV
{
    public partial class Form_Statistic_view : Form
    {
        Connection con = new Connection();
        public Form_Statistic_view()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Statistic_view_Load(object sender, EventArgs e)
        {
            //進帳
            con.Open();
            dataGridView1.AllowUserToDeleteRows = true;
            string query = "SELECT h_id,total_price,r_expiration_time FROM history";
            MySqlDataReader row;
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    dataGridView1.Rows.Add(row["h_id"].ToString(),row["total_price"].ToString(),row["r_expiration_time"].ToString());
                }
            }
            con.Close();
            //人氣歌曲
            con.Open();
            query = "SELECT s_id,s_name,s_singer,s_company,s_play_time FROM song ORDER BY s_play_time DESC";
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    dataGridView2.Rows.Add(row["s_id"].ToString(), row["s_name"].ToString(), row["s_singer"].ToString(),
                        row["s_company"].ToString(), row["s_play_time"].ToString());
                }
            }
        }
    }
}
