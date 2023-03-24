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
    public partial class Animals : Form
    {



        public Animals()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 animals = new Form1();
            animals.Show(this);
            Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double marks = 0;
            if (radioButton4.Checked == true)
            {
                marks++;
            }
            if (radioButton6.Checked == true)
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
