using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                for (int j =0; j < 4; j++)
                {
                    テキストボタン testbutton = new テキストボタン();
                    testbutton.Location = new Point(i*100,j*50);
                    testbutton.Size = new Size(50, 50);
                    testbutton.Text = "あいうえお";
                    //buttonを押すとmessageBoxの中のやつが出る
                    //Click Event に　hogehogeClick関数を登録
                    testbutton.MouseHover += hogehogeClick;
                    //controlにbutton を追加
                    Controls.Add(testbutton);
                }
            }

        }
        private void hogehogeClick(object sender,EventArgs e)
        {
            MessageBox.Show("クリックされてしまいました");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ!");
        }
    }
}
