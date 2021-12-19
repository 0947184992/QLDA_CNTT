using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Du_An_Nhom1
{
    public class LibByPhongGio
    {
        public static bool TrangThaiDangNhap = false;
        public static string ConnectString = @"Data Source=DESKTOP-I06DIRL;Initial Catalog=QLDuAnCNTT;Integrated Security=True";
        public static bool CheckStringDacBiet(string str)
        {
            if(str.Length == 0)
            {
                return false;
            }
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    return false;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if ( str[i] < '0' || (str[i] > '9' && str[i] < 'A') || (str[i] > 'Z' && str[i] < 'a') || (str[i] > 'z'))
                {
                    return false;
                }
            }

            return true;
        }
    }
   
}
