using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls2
{
    public partial class StudentUC : UserControl
    {
        public string No
        {
            get
            {
                return noLbl.Text;
            }
            set
            {
                noLbl.Text = value;
            }
        }

        public string Fullname
        {
            get
            {
                return fullnameLbl.Text;
            }
            set
            {
                fullnameLbl.Text = value;
            }
        }

        public string Age
        {
            get
            {
                return ageLbl.Text;
            }
            set
            {
                ageLbl.Text = value;
            }
        }

        public StudentUC()
        {
            InitializeComponent();



        }

 

        private void ageLbl_Click(object sender, EventArgs e)
        {

        }

        private void fullnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void noLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
