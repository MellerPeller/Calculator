using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{

    public partial class Form1 : Form
    {
        string mode = "";
        double number = 0;
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(label1.Text == "0")
            {
                label1.Text =btn.Text;
            }
            else
            {
                label1.Text = label1.Text + btn.Text;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button16_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);

            
            if (mode == "+")
            {
                label1.Text = (number + tmp).ToString();
            }
            else if (mode == "-")
            {
                label1.Text = (number - tmp).ToString();

            }
            else if (mode == "*")
            {
                label1.Text = (number * tmp).ToString();

            }
            else if (mode == "/")
            {
                label1.Text = (number / tmp).ToString();
            }
            else if (mode == "x^y")
            {
                label1.Text = Math.Pow(number,tmp).ToString();
            }
            else if (mode =="%")
            {
                label1.Text = (number * tmp / 100).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = (tmp *= -1).ToString();

        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);

            label1.Text = Math.Sqrt(tmp).ToString();
        }

        
  
        private void button24_Click(object sender, EventArgs e)
        {
           double ms = double.Parse(label1.Text);

            
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
              if (!label1.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                label1.Text = label1.Text + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            memory = double.Parse(label1.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = memory.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            memory = 0; 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }
    }
}