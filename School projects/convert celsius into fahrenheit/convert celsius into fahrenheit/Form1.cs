using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert_celsius_into_fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = 0, fahrenheit = 0;
            if (label1.Text == "Celsius:")
            {
                celsius = int.Parse(textBox1.Text);
                fahrenheit = celsius * 9 / 5 + 32;
                textBox2.Text = fahrenheit.ToString();
            }
            else
            {
                fahrenheit = int.Parse(textBox1.Text);
                celsius = (fahrenheit - 32) * 5 / 9;
                textBox2.Text = celsius.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "fahrenheit:";
            label2.Text = "Celsius:";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
