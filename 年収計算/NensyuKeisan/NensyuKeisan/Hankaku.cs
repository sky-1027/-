using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace NensyuKeisan
{
    class Hankaku
    {
        static string ZenakkuToHankaku(string s)
        {
            Regex re = new Regex("[０-９Ａ-Ｚａ-ｚ：－　]+");
            string output = re.Replace(s, myReplacer);

            return output;
        }
        static string myReplacer(Match m)
        {
            return "";
            //return Strings.StrConv(m.Value, VbStrConv.Narrow, 0);
        }
    }
}
