using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        double Sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }


        double asin(double x)
        {
            return (Math.Cos(x) * 180 / Math.PI);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double F = Convert.ToDouble(TextBox1.Text)
        }
    }
}
