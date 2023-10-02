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
    public partial class Form_Guest_select : Form
    {
        public Form_Guest_select()
        {
            InitializeComponent();
        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点歌
        private void btn_song_Click(object sender, EventArgs e)
        {
            Form_Song f = new Form_Song();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }

        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        // 点餐
        private void btn_order_Click(object sender, EventArgs e)
        {
            Form_Food f = new Form_Food();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }

        // 服务
        private void btn_service_Click(object sender, EventArgs e)
        {
            Form_ps f = new Form_ps();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }
    }
}
