using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTV
{
    class Guest
    {
        // 是否有人
        public bool en { get; set; }
        // 登记人姓名
        public string name { get; set; }
        // 登记人手机号
        public string phone { get; set; }
        // 登记人身份证号
        public string id { get; set; }
        // 房间号
        public string room { get; set; }
        // 租用时数
        public string hr { get; set; }
        // 到期时间
        public string time { get; set; }

        // constructor
        public Guest(bool en, string name, string id, string phone, string room, string hr, string time = "")
        {
            this.en = en;
            this.name = name;
            this.phone = phone;
            this.id = id;
            this.room = room;
            this.hr = hr;
            this.time = time;
        }

        // 取得登记人资讯
        public string get_info()
        {
            string str = string.Format("姓名: {0}\n身分證號: {1}\n電話號碼: {2}\n包間號: {3}\n租用時數: {4}\n到期時間: {5}", this.name, this.id, this.phone, this.room, this.hr, this.time);
            return str;
        }

        // 设置登记人资讯
        public void set_info(bool en, string name, string id, string phone, string room, string hr, string time)
        {
            this.en = en;
            this.name = name;
            this.phone = phone;
            this.id = id;
            this.room = room;
            this.hr = hr;
            this.time = time;
        }
    }
}
