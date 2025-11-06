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

        //TestButton の二次元配列

        private TestButton[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();
            //buttonArayの初期化
            _buttonArray=new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j =0; j < BOARD_SIZE_Y; j++)
                {       //インスタンス作成
                    TestButton testButton = new TestButton
                       (this,i,j,
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y)," ");
                    
                    _buttonArray[j,i]=testButton;//配列にボタンの参照を追加

                    Controls.Add(testButton); //buttonを押すとmessageBoxの中のやつが出る
                 
                }
            }
            // フォーム初期化時にランダム盤面作成
            RandomizeBoard();

        }
        public TestButton GetTestButton(int x,int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >=BOARD_SIZE_Y) return null;
            return _buttonArray[y,x];
        }
        // TestButtonクラスに追加
        

        // Form1クラスに盤面ランダム化用メソッド
        public void RandomizeBoard()
        {
            Random Rnd = new Random();
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    _buttonArray[j, i].Randomize(Rnd);
                }
            }
        }
        public bool IsClear()
        {
            bool first = _buttonArray[0, 0].IsOn;
            foreach (var btn in _buttonArray)
            {
                if (btn.IsOn != first)
                    return false;
            }
            return true;
        }
        public void CheckAndClear()
        {
            if (IsClear())
            {
                MessageBox.Show("クリア！再スタートします！");
                RandomizeBoard();
            }
        }
    }
}
