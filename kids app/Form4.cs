using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 colors = new Form4();
            colors.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 colors = new Form4();
            colors.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 colors = new Form4();
            colors.Show(this);
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double marks = 0;
            if (radioButton8.Checked == true)
            {
                marks++;
            }
            if (radioButton5.Checked == true)
            {
                marks++;
            }
            if (radioButton9.Checked == true)
            {
                marks++;
            }
            score.Text = marks.ToString();

        }
    }
}
