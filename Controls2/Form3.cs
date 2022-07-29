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

    class Student
    {
        public int No { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
    }
    public partial class Form3 : Form
    {
            UserControl1 userControl1 = new UserControl1();
        UserControl2 userControl2 = new UserControl2();
        public Form3()
        {
            InitializeComponent();

        

            //userControl2.Location = new Point(0, 100);
            //userControl1.Location = new Point(0, 100);
            //this.Controls.Add(userControl1);


            var students = new List<Student>
            {
                new Student
                {
                     No=1,
                      Age=20,
                       Fullname="John Eliyev"
                },
                new Student
                {
                     No=2,
                      Age=25,
                       Fullname="Arif Eliyev"
                },
                new Student
                {
                     No=3,
                      Age=40,
                       Fullname="Aysel Mammadzade"
                },
            };

            int y = 80;
            foreach (var s in students)
            {
                StudentUC userControl = new StudentUC();
                userControl.Location = new Point(userControl.Location.X, y);
                userControl.No = s.No.ToString();
                userControl.Fullname = s.Fullname;
                userControl.Age = s.Age.ToString();

                userControl.Click += UserControl_Click;

                y += 100;
                this.Controls.Add(userControl);
            }


        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            var uc = sender as StudentUC;
            MessageBox.Show(uc.Fullname);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Controls.Remove(userControl1);
            this.Controls.Add(userControl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(userControl2);
            this.Controls.Add(userControl1);
        }
    }
}
