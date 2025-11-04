using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_test
{
    public  class TestButton:Button
    {
        //onの時の色
        private Color _onColor=Color.Beige;
        //offの時の色
        private Color _offColor = Color.Brown;
        //現在　on か　off か
        //押すと色変わる
        private bool _enable;

        private Form1 _form1;
        public TestButton(Form1 form1, Point position, Size size, string text)
        {
            //Form1の参照を保管
            _form1 = form1;

            
            Location = position;    //ボタンの位置の設定
            
            Size = size;            //ボタンの大きさの設定
           
            Text = text;             //ボタン内のテキストの設定

            SetEnable(false);
            Click += ClickEvent;

        }

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
        //自分で作成することも可能
          private void ClickEvent(object sender,EventArgs e)
        {
            //( )のなかにtrueを入れるとtrue の色だけに変わる
            //( )のなかにfalseを入れるとfalse の色だけに変わる

            _form1.GetTestButton(1, 1).SetEnable(true);//ctrl R ２回
        }


    }
}
