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
    public partial class Form_Worker_select : Form
    {
        public Form_Worker_select()
        {
            InitializeComponent();
        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 检查服务
        private void btn_check_sevice_Click(object sender, EventArgs e)
        {
            Form_Check_service f = new Form_Check_service();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }
        void f_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        // 检查房间
        private void btn_check_room_Click(object sender, EventArgs e)
        {
            Form_Room_state f = new Form_Room_state();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }

        // 排班
        private void btn_arrange_Click(object sender, EventArgs e)
        {
            Form_Arrange f = new Form_Arrange();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }

        // 统计资料
        private void btn_statistic_Click(object sender, EventArgs e)
        {
            Form_Statistic_view f = new Form_Statistic_view();
            f.FormClosing += new FormClosingEventHandler(f_FormClosing);
            f.Show();
            this.Hide();
        }
    }
}
