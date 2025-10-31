using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_test
{
    internal class TestButton:Button
    {
        //onの時の色
        private Color _onColor=Color.Beige;
        //offの時の色
        private Color _offColor = Color.Brown;
        //現在　on か　off か
        //押すと色変わる
        private bool _enable;

        //onとoffの設定
        public void SetEnable(bool on)
        {
            _enable = on;  
            if(on)
            {
                BackColor=_onColor;
            }
            else
            {
                BackColor=_offColor;
            }
            
        }


        public TestButton(Point position,Size size,string text)
        {
            //ボタンの位置の設定
            Location = position;
            //ボタンの大きさの設定
            Size = size;
            //ボタン内のテキストの設定
            Text = text;

            SetEnable(false);
            Click += ClickEvent;

        }
        //自分で作成することも可能
          private void ClickEvent(object sender,EventArgs e)
        {
            //( )のなかにtrueを入れるとtrue の色だけに変わる
            //( )のなかにfalseを入れるとfalse の色だけに変わる

            SetEnable(!_enable);
        }


    }
}
