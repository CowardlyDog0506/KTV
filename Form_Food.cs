using System;
using MySql.Data.MySqlClient;
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
    public partial class Form_Food : Form
    {
        public Form_Food()
        {
            InitializeComponent();
        }
        private void Food_Load(object sender, EventArgs e)
        {
            cb_food.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_room.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_list.Text = "餐點：\n炸雞 $80 : 0\n漢堡 $65 : 0\n薯條 $40 : 0\n紅茶 $30 : 0\n可樂 $30 : 0";
        }

        //返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 更新已点菜单
        private void food_update()
        {
            lb_list.Text = String.Format("餐點：\n炸雞 $80 : {0}\n漢堡 $65 : {1}\n薯條 $40 : {2}\n紅茶 $30 : {3}\n可樂 $30 : {4}", chiken, ham, fries, blacktea, cola);
            lb_price.Text = String.Format("價錢：{0}", chiken * 80 + ham * 65 + fries * 40 + blacktea * 30 + cola * 30);
        }

        //送出訂單
        //db
        private void btn_order_Click(object sender, EventArgs e)
        {
            if(ham+chiken+fries+blacktea+cola > 0)
            {
                total_price = chiken * 80 + ham * 65 + fries * 40 + blacktea * 30 + cola * 30;
                //db
                sendSQL();

                MessageBox.Show("點餐成功");
                ham = chiken = fries = blacktea = cola = 0;        
                food_update();
                total_price = 0;
                sv_id += 1;
            }
            else
            {
                MessageBox.Show("未選擇完成，點餐失敗");
            }
        }

        //加點
        private int ham = 0;
        private int fries = 0;
        private int chiken = 0;
        private int blacktea = 0;
        private int cola = 0;
        private int sv_id = 1;
        private int total_price = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_room.Text != "" && cb_food.Text != "")
            {
                switch (cb_food.Text)
                {
                    case ("漢堡 $65"):
                        ham += Convert.ToInt32(tb_num.Text);
                        break;
                    case ("炸雞 $80"):
                        chiken += Convert.ToInt32(tb_num.Text);
                        break;
                    case ("薯條 $40"):
                        fries += Convert.ToInt32(tb_num.Text);
                        break;
                    case ("紅茶 $30"):
                        blacktea += Convert.ToInt32(tb_num.Text);
                        break;
                    case ("可樂 $30"):
                        cola += Convert.ToInt32(tb_num.Text);
                        break;
                }
                food_update();
                
            }
            else
            {
                MessageBox.Show("未選擇完成，點餐失敗");
            }
        }

        //限制輸入
        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            chiken = 0;
            food_update();
        }

        private void btn_cancel2_Click(object sender, EventArgs e)
        {
            ham = 0;
            food_update();
        }

        private void btn_cancel3_Click(object sender, EventArgs e)
        {
            fries = 0;
            food_update();
        }

        private void btn_cancel4_Click(object sender, EventArgs e)
        {
            blacktea = 0;
            food_update();
        }

        private void btn_cancel5_Click(object sender, EventArgs e)
        {
            cola = 0;
            food_update();
        }

//===============================================================================================
        //connectSQL
        private void sendSQL()
        {
            Connection con = new Connection();
            con.Open();
            MySqlDataReader row;
            string query = String.Format("select sv_id from service where sv_id >= {0}", sv_id);
            //string query = String.Format("insert into service values({0}, \"{1}\", {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", sv_id, cb_room.Text, 0, chiken, ham, fries, blacktea, cola, 0, total_price);
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    sv_id = Int32.Parse(row["sv_id"].ToString()) + 1;
                }


            }
            con.Close();
            con.Open();
            query = String.Format("insert into service values({0}, \"{1}\", {2}, {3}, {4}, {5}, {6}, {7}, {8}, \"{9}\")", sv_id, cb_room.Text, 0, chiken, ham, fries, blacktea, cola, total_price, tb_ps.Text);
            row = con.ExecuteReader(query);
        }
    }
}
