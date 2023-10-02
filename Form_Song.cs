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
    public partial class Form_Song : Form
    {
        Connection con = new Connection();
        public Form_Song()
        {
            InitializeComponent();
        }
        private void Form_Song_Load(object sender, EventArgs e)
        {
            // db
            con.Open();
            dataGridView1.AllowUserToDeleteRows = true;
            string query = "SELECT s_id,s_name,s_singer,s_url FROM song";
            MySqlDataReader row;
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    dataGridView1.Rows.Add(row["s_id"].ToString(), row["s_name"].ToString(), 
                        row["s_singer"].ToString(), row["s_url"].ToString());
                }
            }
            //DataGridViewRow r1 = dataGridView1.Rows[2];
            //dataGridView1.Rows.Remove(r1);
            
        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void deleteButton(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow row_delete = dataGridView1.Rows[e.RowIndex];
                    if (MessageBox.Show("Play?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string url;
                        int play_time = 0;
                        //可用歌曲效果示範
                        //url = "https://www.youtube.com/watch?v=-yUD_4LA688";
                        url = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                        con.Open();
                        string query = String.Format("SELECT s_play_time FROM song WHERE s_url = \"{0}\"", url);
                        MySqlDataReader row;
                        row = con.ExecuteReader(query);
                        if(row.HasRows)
                        {
                            while(row.Read())
                            {
                                play_time = int.Parse(row["s_play_time"].ToString()) + 1;
                            }
                        }
                        con.Close();
                        con.Open();
                        query = String.Format("UPDATE song SET s_play_time = {0} WHERE s_url = \"{1}\"", play_time, url);
                        row = con.ExecuteReader(query);
                        //
                        Form_play f = new Form_play(url);
                        f.FormClosing += new FormClosingEventHandler(f_FormClosing);
                        f.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                return;
            }
            
        }
        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}

