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
                    Controls.Add(testbutton);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("C#の世界へようこそ!");
        }
    }
}
