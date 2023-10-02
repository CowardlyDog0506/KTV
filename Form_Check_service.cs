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
    public partial class Form_Check_service : Form
    {
        Connection con = new Connection();
        public Form_Check_service()
        {
            InitializeComponent();
        }
        //test
        private void Form_Check_service_Load(object sender, EventArgs e)
        {
            //db
            con.Open();
            dataGridView1.AllowUserToDeleteRows = true;
            string query = "SELECT sv_id,r_number, ps FROM service WHERE sv_done<>1";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
  
                    dataGridView1.Rows.Add("", row["sv_id"].ToString(),
                        row["r_number"].ToString(),"" , row["ps"].ToString());
                }
            }
        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            try
            {
                //Delete
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row_delete = dataGridView1.Rows[e.RowIndex];
                    if (MessageBox.Show("Delete?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                        // db
                        con.Open();
                        MySqlDataReader row;
                        dataGridView1.AllowUserToDeleteRows = true;
                        string query = "UPDATE service SET sv_done = 1 WHERE sv_id = '" + row_delete.Cells[1].Value.ToString() + "'";
                        row = con.ExecuteReader(query);
                    }
                }
                //show content
                else if (e.ColumnIndex == 3)
                {
                    string sv_id = "", r_number = "", fried_chicken = "", burger = "", fries = "", black_tea = "", cola = "", ps = "", s_price = "";
                    DataGridViewRow row_content = dataGridView1.Rows[e.RowIndex];

                    // db
                    con.Open();
                    MySqlDataReader row;
                    dataGridView1.AllowUserToDeleteRows = true;
                    string query = "SELECT * FROM service WHERE sv_id = '" + row_content.Cells[1].Value.ToString() + "'";
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            sv_id = row["sv_id"].ToString();
                            r_number = row["r_number"].ToString();
                            fried_chicken = row["fried_chicken"].ToString();
                            burger = row["burger"].ToString();
                            fries = row["fries"].ToString();
                            black_tea = row["black_tea"].ToString();
                            cola = row["cola"].ToString();
                            s_price = row["s_price"].ToString();
                            ps = row["ps"].ToString();
                        }
                        MessageBox.Show("服務編號:" + sv_id + "\n\n房號:" + r_number +
                            "\n\n炸雞:" + fried_chicken + "\n\n漢堡:" + burger + "\n\n薯條:" + fries +
                            "\n\n紅茶:" + black_tea + "\n\n可樂:" + cola + "\n\n總金額:" + s_price);

                    }
                    return;
                }
            }
            catch
            {
                return;
            }
            
        }

    }  
}