using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron_LogicGates
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Perceptron p)
        {
            perceptron = p;
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Start ni kay ma double click nako
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked || radioButton1.Checked )
            {
                radioButton2.Enabled = false;
                radioButton1.Enabled = false;

                if (radioButton2.Checked)
                {
                    perceptron.Train(1, 0, 1, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(0, 1, 1, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(1, 1, 1, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(0, 0, 0, Convert.ToInt32(textBox3.Text));
                }
                else if (radioButton1.Checked)
                {
                    perceptron.Train(1, 0, 0, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(0, 1, 0, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(1, 1, 1, Convert.ToInt32(textBox3.Text));
                    perceptron.Train(0, 0, 0, Convert.ToInt32(textBox3.Text));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);

            int output = perceptron.Activation(x1, x2);

            textBox4.Text = output.ToString();
        }
    }
        
}
