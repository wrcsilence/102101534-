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
using Button = System.Windows.Forms.Button;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double num1 = 0;//记录第一个数字
        string op;//记录符号
        public Form1()
        {
            InitializeComponent();
        }

        public void button13_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            string b = a.Text;
            if (b == "+" || b == "-" || b == "×" || b == "÷"||b=="x^y")
            {
                if(textBox1.Text== "π")
                {
                    num1 = Math.PI;
                }
                else if(textBox1.Text=="e")
                {
                    num1 = Math.E;
                }
                else  num1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                op = b;
            }
            else if (b == "=")
            {
                double num2 = double.Parse(textBox1.Text);//代表第二个数
                if (op == "+")
                {
                    double num3 = num1 + num2;
                    textBox1.Text = num3.ToString();
                }
                if (op == "-")
                {
                    double num3 = num1 - num2;
                    textBox1.Text = num3.ToString();
                }
                if (op == "×")
                {
                    double num3 = num1 * num2;
                    textBox1.Text = num3.ToString();
                }
                if (op == "÷")
                {
                    if (num2!=0)
                    {
                        double num3 = num1 / num2;
                        textBox1.Text = num3.ToString();
                    }      
                }
                if(op=="x^y")
                {
                    double sum = 1;
                    for(int i=1;i<=num2;i++)
                    {
                        sum = sum * num1;
                    }
                    textBox1.Text = sum.ToString();
                }
            }
            else if (b == "CE")
            {
                textBox1.Text = "0";
            }
            else if (b == "x^2")
            {
                string c = textBox1.Text;
                double num4 = double.Parse(c);
                double num5 = num4 * num4;
                textBox1.Text = num5.ToString();
            }
            else if (b == "C")
            {
                string c = textBox1.Text;
                c = c.Substring(0, c.Length - 1);
                textBox1.Text = c;
            }
            else if (b == "0" || b == "1" || b == "2" || b == "3" || b == "4" || b == "5" || b == "6" || b == "7" || b == "8" || b == "9"||b== "π"||b=="e")
            {
                if (textBox1.Text == "0") textBox1.Text = "";
                string c = textBox1.Text;
                c = c + b;
                textBox1.Text = c;
            }
            else if(b == ".")
            {
                string c = textBox1.Text;
                c = c + b;
                textBox1.Text = c;
            }
            else if(b=="sin")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if(textBox1.Text != "π"&& textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Sin(num6 * Math.PI / 180.0);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "cos")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Cos(num6 * Math.PI / 180.0);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "tan")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Tan(num6 * Math.PI / 180.0);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "asin")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Asin(num6);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "acos")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Acos(num6);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "atan")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Atan(num6);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if (b == "ln")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Log(num6);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
            else if(b=="sqrt")
            {
                double num6 = 0;
                if (textBox1.Text == "π")
                {
                    num6 = Math.PI;
                }
                if (textBox1.Text == "e")
                {
                    num6 = Math.E;
                }
                if (textBox1.Text != "π" && textBox1.Text != "e")
                {
                    string c = textBox1.Text;
                    num6 = double.Parse(c);
                }
                double num7 = Math.Sqrt(num6);
                double num8 = Math.Round(num7, 2);
                textBox1.Text = num8.ToString();
            }
        }

        public void button12_Click(object sender, EventArgs e)
        {

        }

        public void button10_Click(object sender, EventArgs e)
        {

        }

        public void button18_Click(object sender, EventArgs e)
        {

        }

        public void button14_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button13_Click);
            this.button2.Click += new System.EventHandler(this.button13_Click);
            this.button3.Click += new System.EventHandler(this.button13_Click);
            this.button4.Click += new System.EventHandler(this.button13_Click);
            this.button5.Click += new System.EventHandler(this.button13_Click);
            this.button6.Click += new System.EventHandler(this.button13_Click);
            this.button7.Click += new System.EventHandler(this.button13_Click);
            this.button8.Click += new System.EventHandler(this.button13_Click);
            this.button9.Click += new System.EventHandler(this.button13_Click);
            this.button10.Click += new System.EventHandler(this.button13_Click);
            this.button11.Click += new System.EventHandler(this.button13_Click);
            this.button12.Click += new System.EventHandler(this.button13_Click);
            this.button14.Click += new System.EventHandler(this.button13_Click);
            this.button15.Click += new System.EventHandler(this.button13_Click);
            this.button16.Click += new System.EventHandler(this.button13_Click);
            this.button17.Click += new System.EventHandler(this.button13_Click);
            this.button18.Click += new System.EventHandler(this.button13_Click);
            this.button19.Click += new System.EventHandler(this.button13_Click);
            this.button20.Click += new System.EventHandler(this.button13_Click);
            this.button21.Click += new System.EventHandler(this.button13_Click);
            this.button22.Click += new System.EventHandler(this.button13_Click);
            this.button23.Click += new System.EventHandler(this.button13_Click);
            this.button24.Click += new System.EventHandler(this.button13_Click);
            this.button25.Click += new System.EventHandler(this.button13_Click);
            this.button26.Click += new System.EventHandler(this.button13_Click);
            this.button27.Click += new System.EventHandler(this.button13_Click);
            this.button28.Click += new System.EventHandler(this.button13_Click);
            this.button29.Click += new System.EventHandler(this.button13_Click);
            this.button30.Click += new System.EventHandler(this.button13_Click);
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button21_Click(object sender, EventArgs e)
        {

        }

        public void button22_Click(object sender, EventArgs e)
        {

        }

        public void button24_Click(object sender, EventArgs e)
        {

        }

        public void button8_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
