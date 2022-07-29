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
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            progressBar1.Maximum = Size;
            progressBar1.Step = Speed;

        }
        public int Size { get; set; } = 225;
        public int Speed { get; set; } = 15;
        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Download completed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
            this.BackColor = Color.FromArgb(0, 0, (int)numericUpDown1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.Width = trackBar2.Value;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
