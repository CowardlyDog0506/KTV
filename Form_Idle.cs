using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KTV
{
    public partial class IDLE : Form
    {
        public IDLE()
        {
            InitializeComponent();
        }


        int disp_mode = 0;
        private void btn_Worker_Click(object sender, EventArgs e)
        {
            if (disp_mode == 0)
            {
                btn_Guest.Visible = false;
                label_account.Visible = true;
                label_password.Visible = true;
                tb_account.Visible = true;
                tb_pw.Visible = true;
                btn_wlogin.Visible = true;
                btn_Worker.Text = "Back";
                disp_mode = 1;
            }
            else
            {
                btn_Guest.Visible = true;
                label_account.Visible = false;
                label_password.Visible = false;
                tb_account.Visible = false;
                tb_pw.Visible = false;
                btn_wlogin.Visible = false;
                btn_Worker.Text = "Worker";
                disp_mode = 0;
            }
        }

        // 员工登录
        private void btn_wlogin_Click(object sender, EventArgs e)
        {
            // db
            Connection con = new Connection();
            con.Open();
            string query = "select w_id,w_pw " +
                           "from worker " +
                           "WHERE w_id='" + tb_account.Text + "'AND w_pw ='" + tb_pw.Text + "'";
            MySqlDataReader row;
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                Form_Worker_select f = new Form_Worker_select();
                f.FormClosing += new FormClosingEventHandler(f_FormClosing);
                f.Show();
                this.Hide();
                //this.Visible = false;
            }
            else
            {
                MessageBox.Show("wrong");
            }
        }

        
        private void btn_Guest_Click(object sender, EventArgs e)
        {
            Form_Guest_select f = new Form_Guest_select();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
            //this.Visible = false;
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
