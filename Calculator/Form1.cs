using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            //textBox_Result.Focus();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                //button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void backSpace(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length != 0)
            {
                string currentText = textBox_Result.Text;
                currentText = currentText.Remove(currentText.Length - 1);
                textBox_Result.Text = currentText;
            }
        }

        private void keyboard_handler(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode + "");
            if (e.KeyCode.Equals(Keys.Back))
            {
                back.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Add))
            {
                button16.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Divide))
            {
                button3.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Multiply))
            {
                button6.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Subtract))
            {
                button11.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad0))
            {
                button19.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad1))
            {
                button14.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad2))
            {
                button13.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad3))
            {
                button12.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad4))
            {
                button9.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad5))
            {
                button8.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad6))
            {
                button7.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad7))
            {
                buttonOne.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad8))
            {
                button1.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad9))
            {
                button2.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Decimal))
            {
                button17.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Return))
            {
                button15.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Escape))
            {
                button5.PerformClick();
            }
        }
     
    }
}
