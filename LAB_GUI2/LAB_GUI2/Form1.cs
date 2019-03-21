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

            dataGridView1.Rows.Add(text_radius.Text, text_Height.Text, round.Square(), 
                round.Length(), cylinder.Volume());
             
        }

        private void StartCalculating_Click(object sender, EventArgs e)
        {
            RichTextBoxResult.Text = GetResult();
        }

        public string Max_Square()
        {
            double max_square = 0;
            int number = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) > max_square)                        
                {
                    max_square = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    number = i;
                 }               
            }
            return "\nMax area of a circle = " + Convert.ToString(max_square);
        }

        public string Average_Volume()
        {
            double average_volume = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                average_volume += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            average_volume = average_volume / Convert.ToDouble((dataGridView1.RowCount- 1));

            return "\nAverage volume of a cylinder = " + Convert.ToString(average_volume);
        }

        public string GetResult()
        {
            return Max_Square() + Average_Volume();
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

        private void RichTextBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
