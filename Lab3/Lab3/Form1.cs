using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Vector a;
        Vector b;
        Vector c;
        public Form1()
        {
            InitializeComponent();
            a = new Vector();
            b = new Vector();
            c = new Vector();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.X = Convert.ToDouble(textBoxX.Text == "" ? "0" : textBoxX.Text);
            a.Y = Convert.ToDouble(textBoxY.Text == "" ? "0" : textBoxY.Text);
            a.Z = Convert.ToDouble(textBoxZ.Text == "" ? "0" : textBoxZ.Text);
            dataGridView1.Rows.Add(textBoxX.Text, textBoxY.Text, textBoxZ.Text, a.GetLength());            
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            b.X = Convert.ToDouble(textBoxX.Text == "" ? "0" : textBoxX.Text);
            b.Y = Convert.ToDouble(textBoxY.Text == "" ? "0" : textBoxY.Text);
            b.Z = Convert.ToDouble(textBoxZ.Text == "" ? "0" : textBoxZ.Text);
            dataGridView1.Rows.Add(textBoxX.Text, textBoxY.Text, textBoxZ.Text, b.GetLength());
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            c.X = Convert.ToDouble(textBoxX.Text == "" ? "0" : textBoxX.Text);
            c.Y = Convert.ToDouble(textBoxY.Text == "" ? "0" : textBoxY.Text);
            c.Z = Convert.ToDouble(textBoxZ.Text == "" ? "0" : textBoxZ.Text);
            dataGridView1.Rows.Add(textBoxX.Text, textBoxY.Text, textBoxZ.Text, c.GetLength());
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            richTextBox.Text = GetResult();
        }

        public string GetResult()
        {
            Vector r = (a + b) * c;
            Vector t = (a + c);
            double t_scalar = t % c;

            return "Length vector r = " + r.GetLength() + "\n(a+b)xc:" + r.ToString() +
                "\n(a+c)*c = " + t_scalar + "\nLength vector a = " + a.GetLength() +
                "\nLength vector b = " + b.GetLength() + "\nLength vector c = " + c.GetLength();            
        }

    }
}
