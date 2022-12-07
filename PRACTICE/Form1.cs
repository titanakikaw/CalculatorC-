using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace PRACTICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void txtCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string initTextVal = "";
            //float initValue = 0;

            //string firstValue = textBox1.Text;
            //string secondValue = txtCalc.Text;

            //if (e.KeyChar == 43)
            //{
               
            //}
            //else if (e.KeyChar == 45 )
            //{
            //    MessageBox.Show("-");
            //}
            //else if (e.KeyChar == 47)
            //{
            //    MessageBox.Show("/");
            //}
            //else if (e.KeyChar == 42)
            //{
            //    MessageBox.Show("*");
            //}
            //else if (e.KeyChar == 13)
            //{
            //    MessageBox.Show("enter");
            //}
            //else
            //{
            //    textBox1.Text = txtCalc.Text;
            //}
         

            //txtCalc.Text = "";

            //txtHistory.Text = initTextVal;

        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCalc.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtHistory.Text != "")
            {
                txtCalc.Text = myMethod("+", txtCalc.Text, txtHistory.Text);
                txtHistory.Clear();
            }
            else
            {
                if (txtCalc.Text != "")
                {
                    txtHistory.Text = txtCalc.Text;
                    txtCalc.Clear();
                }
            }

            textBox1.Text = "+";
           
        }
        public string myMethod(string operation, string currentNumber, string secondNumber)
        {
            string finalresult = "";
            float result = 0;
            switch (operation) {
                case "+":
                    result = float.Parse(secondNumber) + float.Parse(currentNumber);
                    finalresult = result.ToString();
                    break;
                case "-":
                    result = float.Parse(secondNumber) - float.Parse(currentNumber);
                    finalresult = result.ToString();
                    break;
                case "*":
                    result = float.Parse(secondNumber) * float.Parse(currentNumber);
                    finalresult = result.ToString();
                    break;
                case "/":
                    result = float.Parse(secondNumber) / float.Parse(currentNumber);
                    finalresult = result.ToString();
                    break;
            }
            return finalresult;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtHistory.Text != "")
            {
                txtCalc.Text = myMethod("-", txtCalc.Text, txtHistory.Text);
                txtHistory.Clear();
            }
            else
            {
                if (txtCalc.Text != "")
                {
                    txtHistory.Text = txtCalc.Text;
                    txtCalc.Clear();
                }
            }

            textBox1.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtHistory.Text != "")
            {
                txtCalc.Text = myMethod("*", txtCalc.Text, txtHistory.Text);
                txtHistory.Clear();
            }
            else
            {
                if (txtCalc.Text != "")
                {
                    txtHistory.Text = txtCalc.Text;
                    txtCalc.Clear();
                }
            }

            textBox1.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtHistory.Text != "")
            {
                txtCalc.Text = myMethod("/", txtCalc.Text, txtHistory.Text);
                txtHistory.Clear();
            }
            else
            {
                if (txtCalc.Text != "")
                {
                    txtHistory.Text = txtCalc.Text;
                    txtCalc.Clear();
                }
            }

            textBox1.Text = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
            txtHistory.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtHistory.Text != "")
            {
                txtCalc.Text = myMethod(textBox1.Text, txtCalc.Text, txtHistory.Text);
                txtHistory.Clear();

            }
                
        }
    }
}