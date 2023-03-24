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
    public partial class Birds : Form
    {
        public Birds()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Birds colors = new Birds();
            colors.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 colors = new Form1();
            colors.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double marks = 0;
            if(radioButton1.Checked==true)
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
