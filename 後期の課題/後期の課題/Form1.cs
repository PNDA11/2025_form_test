using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 後期の課題
{
    public partial class Form1 : Form
    {
        private string input = "";
        private string operand1 = "";
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void AddText(string value)
        {
            if (input=="0"||string.IsNullOrEmpty(input))
            input =value;
          else
                input += value;
            txtDisplay.Text = input;
        }

        private void btn0_Click(object sender, EventArgs e) => AddText("0");
        private void btn1_Click(object sender, EventArgs e) => AddText("1");
        private void btn2_Click(object sender, EventArgs e) => AddText("2");
        private void btn3_Click(object sender, EventArgs e) => AddText("3");
        private void btn4_Click(object sender, EventArgs e) => AddText("4");
        private void btn5_Click(object sender, EventArgs e) => AddText("5");
        private void btn6_Click(object sender, EventArgs e) => AddText("6");
        private void btn7_Click(object sender, EventArgs e) => AddText("7");
        private void btn8_Click(object sender, EventArgs e) => AddText("8");
        private void btn9_Click(object sender, EventArgs e) => AddText("9");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "+";
            input = "";
            txtDisplay.Text = input;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "-";
            input = "";
            txtDisplay.Text = input;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "*";
            input = "";
            txtDisplay.Text = input;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "/";
            input = "";
            txtDisplay.Text = input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            input = "";
            operand1 = "";
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(operand1);
                decimal num2 = Convert.ToDecimal(input);
                decimal result = 0;

                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("0で割ることはできません", "エラー");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }
                txtDisplay.Text = result.ToString();
                input = result.ToString();
                operand1 = "";
                operation = "";
            }
            catch
            {
                MessageBox.Show("計算エラーが発生しました", "エラー");
                btnClear_Click(sender, e);
            }
        }

    }
}
      
        
        
    


    
