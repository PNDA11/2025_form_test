using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_test
{
    public class TestButton : Button
    {
        // ボタンのon状態時の色
        private Color _onColor = Color.Beige;
        // ボタンのoff状態時の色
        private Color _offColor = Color.Brown;
        // 現在のボタン状態（on: true, off: false)
        // 現在　on か　off か  押すと色変わる
        private bool _enable;  
        private Form1 _form1;

        private int _x; //横位置
        private int _y; //縦位置
        // 外部からボタンの状態を読み取れるようにする
        public bool IsOn => _enable;
        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            _form1 = form1; //Form1の参照を保管
            _x = x;         //横位置を保管
            _y = y;         //縦位置を保管
            Location = new Point(x * size.Width, y * size.Height);   //ボタンの位置の設定
            Size = size;            //ボタンの大きさの設定
            Text = text;             //ボタン内のテキストの設定
            SetEnable(false);      // 初期状態はOFFとし、色も設定
            Click += ClickEvent;

        }
        /// <summary>
        /// 指定されたOn/Off状態にセットし、表示色を変更する
        /// </summary>
        /// <param name="on">On状態にするかどうか</param>
        public void SetEnable(bool on)
        {
            _enable = on;
            BackColor = on ?
            _onColor : _offColor;
        }


        public void Toggle()
        {
            SetEnable(!_enable);
        }

        public void Randomize(Random rnd)
        {
            SetEnable(rnd.Next(2) == 0);
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            int[][] toggleOffsets = new int[][]
            {
        new int[]{ 0, 0 },
        new int[]{ 1, 0 },
        new int[]{ -1, 0 },
        new int[]{ 0, 1 },
        new int[]{ 0, -1 }
            };

            for (int i = 0; i < toggleOffsets.Length; i++)
            {
                var offset = toggleOffsets[i];
                var button = _form1.GetTestButton(_x + offset[0], _y + offset[1]);
                if (button != null)
                {
                    button.Toggle();
                }
            }

            _form1.CheckAndClear();
        }

        //private void ClickEvent(object sender, EventArgs e)
        //{
        //    // 自分と上下左右のボタンをトグル
        //    int[][] toggleOffsets = new int[][]
        //    {
        //        new int[]{ 0, 0 },
        //        new int[]{ 1, 0 },
        //        new int[]{ -1, 0 },
        //        new int[]{ 0, 1 },
        //        new int[]{ 0, -1 }
        //    };

        //foreach (var offset in toggleOffsets)
        //{
        //    var button = _form1.GetTestButton(_x + offset[0], _y + offset[1]);
        //    if (button != null)
        //    {
        //        button.Toggle();
        //    }
        //}

        // 状態変化後にクリア判定、クリアなら盤面再ランダム化
        //    _form1.CheckAndClear();
        //    }
        //}

        //onとoffの設定
        //public void SetEnable(bool on)
        //{
        //    _enable = on;//追加
        //    if (on)
        //    {
        //        BackColor = _onColor;
        //    }
        //    else
        //    {
        //        BackColor = _offColor;
        //    }

        //}
        //public void Toggle()
        //{
        //    SetEnable(!_enable);
        //}


        ////自分で作成することも可能
        //private void ClickEvent(object sender, EventArgs e)
        //{
        //    //( )のなかにtrueを入れるとtrue の色だけに変わる
        //    //( )のなかにfalseを入れるとfalse の色だけに変わる

        //    //_form1.GetTestButton(_x, _y)?.Toggle();//ctrl R ２回
        //    //_form1.GetTestButton(_x + 1, _y)?.Toggle();
        //    //_form1.GetTestButton(_x - 1, _y)?.Toggle();
        //    //_form1.GetTestButton(_x, _y + 1)?.Toggle();
        //    //_form1.GetTestButton(_x, _y - 1)?.Toggle();
        //    //かっちょいい書き方
        //    for (int i = 0; i< _toggleData.Length; i++)
        //    {
        //        var data = _toggleData[i];
        //        var button = _form1.GetTestButton(_x + data[0], _y + data[1]);
        //        if (button != null)
        //        {
        //            button.Toggle();
        //        }
        //    }
        //    _form1.CheckAndClear();
        //}
        //private int[][] _toggleData =
        //{
        //     new int[] { 0, 0 },
        //    new int[] { 1, 0 },
        //    new int[] { -1, 0 },
        //    new int[] { 0, 1 },
        //    new int[] { 0, -1 },

        //};
        //}

    }
}


