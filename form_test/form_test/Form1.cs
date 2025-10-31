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
            for (int i = 0; i < 3; i++)
            {
                for (int j =0; j < 3; j++)
                {//
                    TestButton testButton = new TestButton(new Point(i * 100, j * 50),new Size(50, 50),"あいうえお");
                    //ボタンの位置を設定
                   // testbutton.Location = new Point(i*100,j*50);
                    //ボタンの大きさを設定
                    //testbutton.Size = ;
                    //testbutton.Text = ;
                    //buttonを押すとmessageBoxの中のやつが出る
                    //Click Event に　hogehogeClick関数を登録
                    //click ＝押すときに字がでる
                    //Ｍｏｕｓｅｏｖｅｒ＝mouseをのせるだけで映す
                    
                    Controls.Add(testButton);
                }
            }

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ!");
        }
    }
}
