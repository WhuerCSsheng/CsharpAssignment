using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Window
{
    public partial class Form1 : Form
    {
        private TextBox activeTextBox; // 用于跟踪当前活动的文本框***
        public Form1()
        {
            InitializeComponent();

            // 订阅文本框的Enter事件***
            textBox1.Enter += TextBox_Enter;
            textBox2.Enter += TextBox_Enter;
        }

        // 跟踪当前活动的文本框 ***
        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) //等号,计算并输出结果
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;

                string op = comboBox1.SelectedItem.ToString();
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("除数不能为零"); //弹窗除零报错
                        break;
                    default:
                        MessageBox.Show("请选择运算符");
                        break;
                }
                textBox3.Text = result.ToString();
            }

            catch(FormatException) 
            {
                MessageBox.Show("请输入有效的数字");
            }

            catch (Exception ex)
            {
                MessageBox.Show("发生错误: " + ex.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e) //小数点.
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += ".";
            }
        }

        private void button1_Click(object sender, EventArgs e) //1
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "1"; 
            }
        }

        private void button2_Click(object sender, EventArgs e) //2
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e) //3
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e) //4
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e) //5
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e) //6
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e) //7
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e) //8
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e) //9
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e) //Delete
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e) //清空计算器的输入CE键
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
