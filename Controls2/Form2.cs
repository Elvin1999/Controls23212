using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value += 5;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            pictureBox1.Location = new Point(pictureBox1.Location.X, vScrollBar1.Value);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(hScrollBar1.Value, pictureBox1.Location.Y);
        }
        Timer timer = new Timer();
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 timer.Start();
        }
    }
}
