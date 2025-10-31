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
        //constをつけると初期化時にのみ値の変更が可能になる
        //ボタンの横幅
        const int BUTTON_SIZE_X = 100;
        //ボタンの縦
        const int BUTTON_SIZE_Y = 100;
        //ボタンの横に何個並ぶか
        const int BOARD_SIZE_X = 3;
        //ボタンの縦に何個並ぶか
        const int BOARD_SIZE_Y = 3;

        private TestButton[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();
            //buttonArayの初期化
            _buttonArray=new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j =0; j < BOARD_SIZE_Y; j++)
                {//
                    TestButton testButton = 
                        new TestButton(new Point(BUTTON_SIZE_X*i, BUTTON_SIZE_Y*j),
                                       new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"あいうえお");
                    //配列にボタンの参照を追加
                    _buttonArray[j,i]=testButton;
                    //buttonを押すとmessageBoxの中のやつが出る
                    //Click Event に　hogehogeClick関数を登録
                    //click ＝押すときに字がでる
                    //Ｍｏｕｓｅｏｖｅｒ＝mouseをのせるだけで映す
                    //controlにbutton
                    Controls.Add(testButton);
                }
            }
            _buttonArray[1,0 ].SetEnable(true);
           

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ!");
        }
    }
}
