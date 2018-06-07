using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NensyuKeisan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.DataBindings["Text"].FormatString = "#,##0";

            // button1 を [承諾] ボタンに設定する
            this.AcceptButton = this.button1;
            textBox1.MaxLength = 7;
            textBox2.MaxLength = 7;
            textBox3.MaxLength = 7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check ck = new Check();
            if (ck.Checktextbox(textBox1.Text, textBox2.Text, textBox3.Text) == true)
            {
                Textbox tb = new Textbox();
                tb.setTextBox1(double.Parse(textBox1.Text));
                tb.setTextBox2(double.Parse(textBox2.Text));
                tb.setTextBox3(double.Parse(textBox3.Text));

                Keisan k = new Keisan();
                k.setKeisan(tb.getTextBox1(), tb.getTextBox2(), tb.getTextBox3());

                //カンマ表記{0:#,0}　最初の0=先頭から指定する対象パラメータ先, ","=3桁後の挿入文字
                //小数点で表示不可　カンマ表示可
                label1.Text = String.Format("{0:#,0}", k.getKeisan()) + "円";

                //小数点で表示可　カンマ表示不可
                //label1.Text = k.getKeisan() + "円";
            }
        }
    }
    //未実装項目
    //全角を半角変換
    //textBox.textの内容をカンマ区切り表示
    //label1のtextの長さを右を中心として整える
}
