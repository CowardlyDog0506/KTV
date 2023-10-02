using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTV
{
    class Time
    {
        public static int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static string getTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        // 引入時間戳，返還加時後時戳
        public static string addTime(string time, int addhh)
        {
            int yyyy = Convert.ToInt32(time.Substring(0, 4));
            int MM = Convert.ToInt32(time.Substring(5, 2));
            int dd = Convert.ToInt32(time.Substring(8, 2));
            int HH = Convert.ToInt32(time.Substring(11, 2)) + addhh;
            int mm = Convert.ToInt32(time.Substring(14, 2));

            // 闰年
            if (chkYear(yyyy))
            {
                days[1] = 29;
            }
            else
            {
                days[1] = 28;
            }
            // 跨天
            if (HH > 23)
            {
                HH -= 24;
                dd++;
            }
            // 下个月
            if (dd > days[MM - 1])
            {
                dd -= days[MM - 1];
                mm++;
            }
            // 跨年
            if (MM > 12)
            {
                yyyy += 1;
                MM -= 12;
            }
            // 时戳
            time = string.Format("{0:0000}-{1:00}-{2:00} {3:00}-{4:00}", yyyy, MM, dd, HH, mm);
            return time;
        }

        // 检查是否闰年 ? true : false
        public static bool chkYear(int yyyy)
        {
            if ((yyyy % 4) == 0 && (yyyy % 100 != 0) || yyyy % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
