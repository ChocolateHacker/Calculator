using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCalculator
{
    public partial class Calculator : Form
    {
        private float a, b, c;
        private int count;
        bool sign = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Show();
                label1.Text = a.ToString() + " *";
                sign = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                label1.Show();
                calculate();
                label1.Text = "";
            }
        }

        private void calculate()
        {
            switch(count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(textBox1.Text);
                    if (divider == 0.0)
                        MessageBox.Show("Attention! You can't divide by zero");
                    else
                    {
                        b = a / divider;
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 5:
                    if (textBox1.Text == null)
                    {
                        textBox1.Text = "";
                    }
                    else
                    {
                        b = a / 100;
                        textBox1.Text = b.ToString();
                    }
                    break;

                default:
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            else if (textBox1.Text.IndexOf('-') == 1)
            {
                textBox1.Text += "-";
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Show();
                label1.Text = a.ToString() + " -";
                sign = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Show();
                label1.Text = a.ToString() + " +";
                sign = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValueNumbericString(string textIn)
        {
            return textIn.All(char.IsDigit);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            if (textBox1.Text.Length != 0)
            {
                label1.Hide();
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Show();
            label1.Text = "Enter the number";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Show();
                label1.Text = a.ToString() + " /";
                sign = true;
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 5;
                label1.Show();
                var v = a / 100;
                label1.Text = v.ToString() + "%";
                sign = true;
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                if (sign == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    sign = false;
                }
                else if (sign == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    sign = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            var length = textBox1.Text.Length - 1;
            var text = textBox1.Text;
            textBox1.Clear();
            for (var i = 0; i < length; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,";
            }
            else if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
            }
        }
    }
}