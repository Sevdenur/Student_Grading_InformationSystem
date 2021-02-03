using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grading_Information_System
{
    public partial class Teacher_Login_Form : Form
    {
        public Teacher_Login_Form()
        {
            InitializeComponent();
        }

        private void button_teacher_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DKOFA8;Initial Catalog=Grade_Information_Db;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "select name, lastname, password from teachers";
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (textBox_teacher_password.Text == dr["password"].ToString() &&
                    textBox_teacher_name.Text == dr["name"].ToString() &&
                    textBox_teacher_lastname.Text == dr["lastname"].ToString())
                {
                    Teacher_Grade_Recording_Form teacher_Grade_Recording_Form = new Teacher_Grade_Recording_Form();
                    teacher_Grade_Recording_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz");
                }
            }
        }
    }
}
