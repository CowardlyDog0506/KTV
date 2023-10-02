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
    public partial class Form_ps : Form
    {
        string ps = "";
        public Form_ps()
        {
            InitializeComponent();
        }
        private void Form_ps_Load(object sender, EventArgs e)
        {

        }

        // 返回
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 额外要求
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                chk_en_send();
            }
            else
            {
                chk_en_send();
            }
        }

        // 送出按钮之Enable
        private void chk_en_send()
        {
            bool en = ((chk_clean.Checked == true || chk_add.Checked == true || chk_pay.Checked == true || textBox1.Text.Trim() != "") ? true : false);
            btn_send.Enabled = (en ? true : false);
        }


        private void chk_clean_CheckedChanged(object sender, EventArgs e)
        {
            chk_en_send();
        }

        private void chk_add_CheckedChanged(object sender, EventArgs e)
        {
            chk_en_send();
        }

        private void chk_pay_CheckedChanged(object sender, EventArgs e)
        {
            chk_en_send();
        }

        // 送出
        private void btn_send_Click(object sender, EventArgs e)
        {
            string ps = "";
            if(chk_add.Checked == true)
            {
                ps += "加時; ";
            }
            if (chk_clean.Checked == true)
            {
                ps += "清潔; ";
            }
            if (chk_pay.Checked == true)
            {
                ps += "結帳; ";
            }
            if(textBox1.Text.Trim() != "")
            {
                ps += "\n其他需求：\n" + textBox1.Text.Trim();
            }
            MessageBox.Show(ps);
            this.Close();
        }

        // 限制输入
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox1.Text.Length >= 300)
            {
                e.Handled = true;
            }
        }
    }
}
