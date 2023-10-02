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
    public partial class Form_new : Form
    {
        // 传入父表单与房号
        private readonly Form_Room_state _parent;
        private string _room;

        public Form_new(Form_Room_state parent, string room)
        {
            InitializeComponent();
            _parent = parent;
            _room = room;
            btn_back.DialogResult = DialogResult.Cancel;
        }

        // 初始化
        private void Form_new_Load(object sender, EventArgs e)
        {
            tb_room.Text = _room;
        }

        // 上一页
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 订单资讯记录变量
        public string info_name;
        public string info_id;
        public string info_phone;
        public string info_room;
        public string info_hr;
        public string info_time;

        // 确定与送出资料 （上传到资料库）
        private void btn_save_Click(object sender, EventArgs e)
        {
            // 空栏防呆
            if (tb_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name is empty");
                return;
            }
            else if (tb_id.Text.Trim().Length == 0)
            {
                MessageBox.Show("Id is empty");
                return;
            }
            else if (tb_phone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phone number is empty");
                return;
            }
            else if (tb_room.Text.Trim().Length == 0)
            {
                MessageBox.Show("Room is empty");
                return;
            }
            else if (tb_hr.Text.Trim().Length == 0)
            {
                MessageBox.Show("Time is empty");
                return;
            }
            else
            {
                // 订单实体
                Guest g = new Guest(true, tb_name.Text, tb_id.Text, tb_phone.Text, tb_room.Text, tb_hr.Text);
                info_name = tb_name.Text;
                info_id = tb_id.Text;
                info_phone = tb_phone.Text;
                info_room = tb_room.Text;
                info_hr = tb_hr.Text;

                // 原件表现控制
                btn_save.DialogResult = DialogResult.OK;
                btn_save.Text = "OK";
                tb_name.Enabled = false;
                tb_id.Enabled = false;
                tb_phone.Enabled = false;
                tb_room.Enabled = false;
                tb_hr.Enabled = false;

                // 产生退房时戳
                string time = Time.getTime();
                time = Time.addTime(time, Convert.ToInt32(tb_hr.Text));
                info_time = time;
                // db 上传时戳
            }
        }

        // 使用者输入限制
        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        // 使用者输入限制
        private void tb_hr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
