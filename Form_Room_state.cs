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
    public partial class Form_Room_state : Form
    {
        Guest[] room_state = new Guest[8];
        public Form_Room_state()
        {
            InitializeComponent();

        }

        // 初始化
        private void Form_Room_state_Load(object sender, EventArgs e)
        {

            loadSQL();
            for (int i = 0; i < 8; i++)
            {
                change_color(i, room_state[i].en);
            }
        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 检查信号源
        // 房间状态按钮
        private int check_sder(object sender)
        {
            int idx = 0;
            Button sder = (Button)sender;
            if (sder == btn_ra) idx = 0;
            else if (sder == btn_rb) idx = 1;
            else if (sder == btn_rc) idx = 2;
            else if (sder == btn_rd) idx = 3;
            else if (sder == btn_re) idx = 4;
            else if (sder == btn_rf) idx = 5;
            else if (sder == btn_rg) idx = 6;
            else if (sder == btn_rh) idx = 7;
            
            return idx;
        }

        // 检查信号源
        // 退房按钮
        private int check_xsder(object sender)
        {
            int idx = 0;
            Button sder = (Button)sender;
            if (sder == btn_xa) idx = 0;
            else if (sder == btn_xb) idx = 1;
            else if (sder == btn_xc) idx = 2;
            else if (sder == btn_xd) idx = 3;
            else if (sder == btn_xe) idx = 4;
            else if (sder == btn_xf) idx = 5;
            else if (sder == btn_xg) idx = 6;
            else if (sder == btn_xh) idx = 7;

            return idx;
        }

        // 检查信号源
        // 加时按钮
        private int[] check_asder(object sender)
        {
            int idx = 0;
            int hr = 0;
            Button sder = (Button)sender;
            if (sder == btn_addA)
            {
                idx = 0;
                try 
                {
                    hr = Convert.ToInt32(tb_a.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_a.Clear();
            }
            else if (sder == btn_addB)
            {
                idx = 1;
                try
                {
                    hr = Convert.ToInt32(tb_b.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_b.Clear();
            }
            else if (sder == btn_addC)
            {
                idx = 2;
                try
                {
                    hr = Convert.ToInt32(tb_c.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_c.Clear();
            }
            else if (sder == btn_addD)
            {
                idx = 3;
                try
                {
                    hr = Convert.ToInt32(tb_d.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_d.Clear();
            }
            else if (sder == btn_addE)
            {
                idx = 4;
                try
                {
                    hr = Convert.ToInt32(tb_e.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_e.Clear();
            }
            else if (sder == btn_addF)
            {
                idx = 5;
                try
                {
                    hr = Convert.ToInt32(tb_f.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_f.Clear();
            }
            else if (sder == btn_addG)
            {
                idx = 6;
                try
                {
                    hr = Convert.ToInt32(tb_g.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_g.Clear();
            }
            else if (sder == btn_addH)
            {
                idx = 7;
                try
                {
                    hr = Convert.ToInt32(tb_h.Text);
                }
                catch
                {
                    hr = 0;
                }
                tb_h.Clear();
            }
            int[] arr = new int[2] { idx, hr };
            return arr;
        }

        // 切换元件显示模式（state == 1 为有人）
        //--------------------------
        // 有人 ： 黄色, 显示租用期限
        // 无人 ： 灰色, 仅显示房名
        //--------------------------
        private void change_color(int idx, bool state)
        {
            string time = get_expiration_date(idx.ToString());
            // 字体定义
            Font fTrue = new Font("微軟正黑體", 12, FontStyle.Bold);
            Font fFalse = new Font("微軟正黑體", 18, FontStyle.Bold);

            //state == 1 => 有人
            switch (idx)
            {
                case 0:
                    btn_ra.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_ra.Text = (state == true ? ("Room A\n" + time) : ("Room A"));
                    btn_ra.Font = (state == true ? fTrue : fFalse);
                    break;
                case 1:
                    btn_rb.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rb.Text = (state == true ? ("Room B\n" + time) : ("Room B"));
                    btn_rb.Font = (state == true ? fTrue : fFalse);
                    break;
                case 2:
                    btn_rc.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rc.Text = (state == true ? ("Room C\n" + time) : ("Room C"));
                    btn_rc.Font = (state == true ? fTrue : fFalse);
                    break;
                case 3:
                    btn_rd.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rd.Text = (state == true ? ("Room D\n" + time) : ("Room D"));
                    btn_rd.Font = (state == true ? fTrue : fFalse);
                    break;
                case 4:
                    btn_re.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_re.Text = (state == true ? ("Room E\n" + time) : ("Room E"));
                    btn_re.Font = (state == true ? fTrue : fFalse);
                    break;
                case 5:
                    btn_rf.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rf.Text = (state == true ? ("Room F\n" + time) : ("Room F"));
                    btn_rf.Font = (state == true ? fTrue : fFalse);
                    break;
                case 6:
                    btn_rg.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rg.Text = (state == true ? ("Room G\n" + time) : ("Room G"));
                    btn_rg.Font = (state == true ? fTrue : fFalse);
                    break;
                case 7:
                    btn_rh.BackColor = (state == true ? Color.Yellow : Color.Gray);
                    btn_rh.Text = (state == true ? ("Room H\n" + time) : ("Room H"));
                    btn_rh.Font = (state == true ? fTrue : fFalse);
                    break;
            }
        }

        // 无人时进登记页面
        // 有人时显示登记人资讯
        // A-H 接呼叫此方法
        private void btn_ra_Click(object sender, EventArgs e)
        {
            // 检查呼叫者与产生时戳
            int idx = check_sder(sender);
            string _room = "";
            string time = Time.getTime();
            
            if (room_state[idx].en != false)
            {
                int total_price = cal_total_price(idx.ToString());
                MessageBox.Show(room_state[idx].get_info() + "\n總金額: " + total_price);
                return;
            }
            switch (idx)
            {
                case 0:
                    _room = "A";
                    break;
                case 1:
                    _room = "B";
                    break;
                case 2:
                    _room = "C";
                    break;
                case 3:
                    _room = "D";
                    break;
                case 4:
                    _room = "E";
                    break;
                case 5:
                    _room = "F";
                    break;
                case 6:
                    _room = "G";
                    break;
                case 7:
                    _room = "H";
                    break;
            }

            // 登记租用
            Form_new f = new Form_new(this, _room);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("登記失敗");
                return;
            }
            room_state[idx].set_info(true, f.info_name, f.info_id, f.info_phone, f.info_room, f.info_hr, f.info_time);
            
            // 连线资料库
            set_room_to_SQL(idx.ToString(), Int32.Parse(f.info_hr)*30, 1, Int32.Parse(f.info_hr), f.info_time, f.info_id, f.info_phone, f.info_name);
            change_color(idx, true);
        }

        // 退房
        private void btn_xa_Click(object sender, EventArgs e)
        {
            int idx = check_xsder(sender);
            if (MessageBox.Show("Checkout?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                room_state[idx].en = false;
                change_color(idx, false);
                del_room_to_SQL(idx.ToString());
            }
        }

        // 加时间
        private void btn_addA_Click(object sender, EventArgs e)
        {
            int[] tmp = check_asder(sender);
            int idx = tmp[0];
            int hr = tmp[1];
            if (room_state[idx].en == true)
            {
                if (hr > 0)
                {
                    room_state[idx].hr = Convert.ToString(Convert.ToInt32(room_state[idx].hr) + hr);
                    MessageBox.Show("加時成功");
                    string time = get_expiration_date(idx.ToString());
                    time = Time.addTime(time, hr);
                    Connection con = new Connection();
                    con.Open();
                    MySqlDataReader row;
                    string query = String.Format("UPDATE room SET r_expiration_date = \"{0}\"WHERE r_number = \"{1}\"", time, idx.ToString());
                    row = con.ExecuteReader(query);
                    con.Close();
                    change_color(idx, true);
                }
                else
                {
                    MessageBox.Show("未輸入時間");
                }

            }
            else
            {
                MessageBox.Show("包廂未開啟");
            }
        }

        // 限制输入
        private void tb_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


// ====================================================================================
// mySQL 连线相关
// ====================================================================================

        private void loadSQL()
        {
            Connection con = new Connection();

            MySqlDataReader row;

            for (int i = 0; i < 8; i++)
            {
                con.Open();
                string query = String.Format("select * from room natural join guest where r_number = {0}", i);
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (Int32.Parse(row["r_state"].ToString()) == 1)
                        {
                            room_state[i] = new Guest(true, row["g_name"].ToString(), row["g_ssn"].ToString(), row["g_phone"].ToString(), row["r_number"].ToString(), row["r_time"].ToString(), row["r_expiration_date"].ToString());
                        }
                        else
                        {
                            room_state[i] = new Guest(false, row["g_name"].ToString(), row["g_ssn"].ToString(), row["g_phone"].ToString(), row["r_number"].ToString(), row["r_time"].ToString(), row["r_expiration_date"].ToString());
                        }
                    }
                    //true, f.info_name, f.info_id, f.info_phone, f.info_room, f.info_hr

                }
                else
                {
                    room_state[i] = new Guest(false, "", "", "", "", "");
                }
            }
            con.Close();

        }

        // 上传至资料库
        private void set_room_to_SQL(String room, int price, int state, int total_time, String expiration_date, String ssn, String phone, String name)
        {

            Connection con = new Connection();
            con.Open();
            MySqlDataReader row;
            string query = String.Format("insert into guest values(\"{0}\", \"{1}\", \"{2}\")", ssn, phone, name);
            row = con.ExecuteReader(query);
            con.Close();
            con.Open();
            query = String.Format("UPDATE room SET r_price = {0}, r_state = {1}, r_time = {2}, r_expiration_date = \"{3}\", g_ssn = \"{4}\" WHERE r_number = \"{5}\"", price, state, total_time, expiration_date, ssn, room);
            row = con.ExecuteReader(query);
            con.Close();
        }

        // 删除资料库资讯
        private void del_room_to_SQL(String room)
        {
            String[] room_name = new String[8];
            room_name[0] = "Room A";
            room_name[1] = "Room B";
            room_name[2] = "Room C";
            room_name[3] = "Room D";
            room_name[4] = "Room E";
            room_name[5] = "Room F";
            room_name[6] = "Room G";
            room_name[7] = "Room H";
            cal_total_price(room);
            Connection con = new Connection();
            con.Open();
            MySqlDataReader row;
            String query = String.Format("DELETE FROM guest WHERE g_ssn = (SELECT g_ssn FROM room WHERE r_number = \"{0}\")", room);
            row = con.ExecuteReader(query);
            con.Close();
            con.Open();
            query = String.Format("UPDATE room SET r_price = null, r_state = {0}, r_time = null, r_expiration_date = null, g_ssn = null WHERE r_number = \"{1}\"", 0, room);
            row = con.ExecuteReader(query);
            con.Close();
            con.Open();
            query = String.Format("DELETE FROM service WHERE r_number = \"{0}\"", room_name[int.Parse(room)]);
            row = con.ExecuteReader(query);
            con.Close();
        }

        // 结账
        private int cal_total_price(String room)
        {
            String[] room_name = new String[8];
            int[] total_price = new int[8];
            room_name[0] = "Room A";
            room_name[1] = "Room B";
            room_name[2] = "Room C";
            room_name[3] = "Room D";
            room_name[4] = "Room E";
            room_name[5] = "Room F";
            room_name[6] = "Room G";
            room_name[7] = "Room H";
            Connection con = new Connection();
            con.Open();
            MySqlDataReader row;
            String query = String.Format("SELECT s_price FROM service WHERE r_number = \"{0}\"",room_name[int.Parse(room)]);
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while(row.Read())
                {
                    total_price[int.Parse(room)] += int.Parse(row["s_price"].ToString());
                }
            }
            con.Close();
            con.Open();
            query = String.Format("SELECT r_price FROM room WHERE r_number = \"{0}\"", room);
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    total_price[int.Parse(room)] += int.Parse(row["r_price"].ToString());
                }
            }
            con.Close();
            con.Open();
            int h_id = 1;
            query = String.Format("SELECT h_id FROM history");
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    h_id += 1;
                }
            }
            con.Close();
            con.Open();
            query = String.Format("INSERT INTO history VALUES({0},{1},\"{2}\")", h_id,total_price[int.Parse(room)],Time.getTime());
            row = con.ExecuteReader(query);
            return total_price[int.Parse(room)];
        }

        private String get_expiration_date(String room)
        {
            String expiration_date = "";
            Connection con = new Connection();
            con.Open();
            MySqlDataReader row;
            String query = String.Format("SELECT r_expiration_date FROM room WHERE r_number = \"{0}\"", room);
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    expiration_date = row["r_expiration_date"].ToString();
                }
            }
            return expiration_date;
        }



    }
}
