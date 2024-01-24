using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___CIRCLE_AREA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double r;
            const double pi = 3.14;

                if (double.TryParse(textBox1.Text, out r))
            {
                a = pi * Math.Pow(r,2);
                textBox2.Text= a.ToString();

            }
                else
            {
                MessageBox.Show("ENTER A  VALID NUMERIC VALUE ");

            }
        }
    }
}
