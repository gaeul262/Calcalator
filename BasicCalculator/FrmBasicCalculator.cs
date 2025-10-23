using System;
using System.Windows.Forms;
using BasicCalculator;


namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2;
            float result = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    num1 = float.Parse(textBox1.Text);
                    num2 = float.Parse(textBox2.Text);
                    result = BasicComputation.Addition(num1, num2);
                    break;
                case 1:
                    num1 = float.Parse(textBox1.Text);
                    num2 = float.Parse(textBox2.Text);
                    result = BasicComputation.Subtraction(num1, num2);
                    break;
                case 2:
                    num1 = float.Parse(textBox1.Text);
                    num2 = float.Parse(textBox2.Text);
                    result = BasicComputation.Multiplication(num1, num2);
                    break;
                case 3:
                    num1 = float.Parse(textBox1.Text);
                    num2 = float.Parse(textBox2.Text);
                    result = BasicComputation.Division(num1, num2);
                    break;
            }
            label3.Text = result.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //Michael G



























        public class BasicComputation
        {
            public static float Addition(float num1, float num2)
            {
                return num1 + num2;
            }
            public static float Subtraction(float num1, float num2)
            {
                return num1 - num2;
            }
            public static float Multiplication(float num1, float num2)
            {
                return num1 * num2;
            }
            public static float Division(float num1, float num2)
            {
                return num1 / num2;
            }
        }
    }
}
