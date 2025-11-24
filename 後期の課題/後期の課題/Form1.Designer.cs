namespace 後期の課題
{
    partial class Form1
    {
        
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.TextBox txtDisplay;
            private System.Windows.Forms.Button btn0;
            private System.Windows.Forms.Button btn1;
            private System.Windows.Forms.Button btn2;
            private System.Windows.Forms.Button btn3;
            private System.Windows.Forms.Button btn4;
            private System.Windows.Forms.Button btn5;
            private System.Windows.Forms.Button btn6;
            private System.Windows.Forms.Button btn7;
            private System.Windows.Forms.Button btn8;
            private System.Windows.Forms.Button btn9;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.Button btnSub;
            private System.Windows.Forms.Button btnMul;
            private System.Windows.Forms.Button btnDiv;
            private System.Windows.Forms.Button btnClear;
            private System.Windows.Forms.Button btnEqual;

            private void InitializeComponent()
            {
                this.txtDisplay = new System.Windows.Forms.TextBox();
                this.btn0 = new System.Windows.Forms.Button();
                this.btn1 = new System.Windows.Forms.Button();
                this.btn2 = new System.Windows.Forms.Button();
                this.btn3 = new System.Windows.Forms.Button();
                this.btn4 = new System.Windows.Forms.Button();
                this.btn5 = new System.Windows.Forms.Button();
                this.btn6 = new System.Windows.Forms.Button();
                this.btn7 = new System.Windows.Forms.Button();
                this.btn8 = new System.Windows.Forms.Button();
                this.btn9 = new System.Windows.Forms.Button();
                this.btnAdd = new System.Windows.Forms.Button();
                this.btnSub = new System.Windows.Forms.Button();
                this.btnMul = new System.Windows.Forms.Button();
                this.btnDiv = new System.Windows.Forms.Button();
                this.btnClear = new System.Windows.Forms.Button();
                this.btnEqual = new System.Windows.Forms.Button();

                // 
                // txtDisplay
                // 
                this.txtDisplay.Location = new System.Drawing.Point(12, 12);
                this.txtDisplay.ReadOnly = true;
                this.txtDisplay.Size = new System.Drawing.Size(260, 20);
                this.txtDisplay.TabIndex = 0;
                this.txtDisplay.Text = "0";
                this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

                // 
                // btn0
                // 
                this.btn0.Location = new System.Drawing.Point(12, 200);
                this.btn0.Size = new System.Drawing.Size(50, 40);
                this.btn0.Text = "0";
                this.btn0.Click += new System.EventHandler(this.btn0_Click);

                // 同様に1〜9のボタンと演算子ボタンも設定し、それぞれClickイベントを割り当てる

                // 以下、残りのボタン配置とFormプロパティ設定は省略

                // Form1
                this.ClientSize = new System.Drawing.Size(284, 261);
                this.Controls.Add(this.txtDisplay);
                this.Controls.Add(this.btn0);
                // 他のボタンもControlsに追加
                this.Text = "電卓アプリ";

            this.btn1 = new System.Windows.Forms.Button();
            this.btn1.Location = new System.Drawing.Point(68, 150);
            this.btn1.Size = new System.Drawing.Size(50, 40);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.Controls.Add(this.btn1);
        }
        }
    }
