using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Root_calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Fill in the blanks.");
            }
            catch (Exception)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double cal = Math.Pow(b, 2) - 4 * a * c;
                if (cal == 0 || cal < 0)
                {
                    label5.Text = "ROOT NO";
                    label7.Hide(); label6.Hide();
                }
                else
                {
                    label5.Text = "ROOT YES";
                    double x1 = (-b + Math.Sqrt(cal)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(cal)) / (2 * a);
                    label7.Show(); label6.Show();
                    label6.Text = x1.ToString(); label7.Text = x2.ToString();
            } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " "; textBox2.Text = " "; textBox3.Text = " "; label5.Text = ""; label6.Text = ""; label7.Text = "";
        }
    }
}
