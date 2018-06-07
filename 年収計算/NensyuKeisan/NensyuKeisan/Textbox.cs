using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NensyuKeisan
{
    class Textbox
    {
        private double gesyuu = 0;
        private double syouyo = 0;
        private double teate = 0;

        //コンストラクタ
        public Textbox()
        {
        }

        public double getTextBox1()
        {
            return gesyuu;
        }

        public void setTextBox1(double gesyuu)
        {
            this.gesyuu = gesyuu;
        }

        public double getTextBox2()
        {
            return syouyo;
        }

        public void setTextBox2(double syouyo)
        {
            this.syouyo = syouyo;
        }

        public double getTextBox3()
        {
            return teate;
        }

        public void setTextBox3(double teate)
        {
            this.teate = teate;
        }
    }
}
