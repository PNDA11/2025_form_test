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
        
        private bool _enable;   //現在　on か　off か
                                //押すと色変わる
        private Form1 _form1;

        private int _x; //横位置
        private int _y; //縦位置
        public TestButton(Form1 form1,int x,int y,  Size size, string text)
        { 
            _form1 = form1; //Form1の参照を保管
            _x = x;         //横位置を保管
            _y = y;         //縦位置を保管


            Location = new Point(x * size.Width, y * size.Height);   //ボタンの位置の設定
            
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
        public void Toggle()
        {
            SetEnable(!_enable);
        }
        //自分で作成することも可能
          private void ClickEvent(object sender,EventArgs e)
        {
            //( )のなかにtrueを入れるとtrue の色だけに変わる
            //( )のなかにfalseを入れるとfalse の色だけに変わる

            _form1.GetTestButton(_x,_y).Toggle();//ctrl R ２回
        }


    }
}
