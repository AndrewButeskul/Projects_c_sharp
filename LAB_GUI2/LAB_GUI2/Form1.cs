using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_GUI2
{
    public partial class Form1 : Form
    {
        Round round;
        Cylinder cylinder;
        public Form1()
        {
            InitializeComponent();
            round = new Round();
            cylinder = new Cylinder();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            round.Radius = Convert.ToDouble(text_radius.Text == "" ? "0" : text_radius.Text);
            richTextBoxRound.Text = round.ToString();

            cylinder.Height = Convert.ToDouble(text_Height.Text == "" ? "0" : text_Height.Text);
            cylinder.Radius = Convert.ToDouble(text_radius.Text == "" ? "0" : text_radius.Text);
            richTextBoxCylinder.Text = cylinder.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
