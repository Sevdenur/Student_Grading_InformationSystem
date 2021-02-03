using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grading_Information_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void student_login_button_Click(object sender, EventArgs e)
        {
            Student_Login_Form student_Login_Form = new Student_Login_Form();
            student_Login_Form.Show();
        }

        private void teacher_login_button_Click(object sender, EventArgs e)
        {
            Teacher_Login_Form teacher_Login_Form = new Teacher_Login_Form();
            teacher_Login_Form.Show();
        }
    }
}
