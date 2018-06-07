using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NensyuKeisan
{
    class Check
    {
        public Check()
        {
        }

        public bool Checktextbox(String g, String s, String t)
        {
            //数字以外の文字が入力されていないか
            if (Validation.IsNumeric(g) == false || Validation.IsNumeric(s) == false || Validation.IsNumeric(t) == false)
            {
                MessageBox.Show("数字を正しく入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
