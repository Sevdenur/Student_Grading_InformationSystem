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
    public partial class Student_Login_Form : Form
    {
        public Student_Login_Form()
        {
            InitializeComponent();
        }

        private void button_student_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DKOFA8;Initial Catalog=Grade_Information_Db;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "select name, lastname, number, exam1, exam2, exam3, average, status from students";
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (maskedTextBox_student_number.Text == dr["number"].ToString() && textBox_student_name.Text == dr["name"].ToString() &&
                    textBox_student_lastname.Text == dr["lastname"].ToString())
                {
                    Student_Grading_Information_Form grading_Information_Form = new Student_Grading_Information_Form();
                    grading_Information_Form.textBox_name_lastname.Text = dr["name"].ToString() + " " + dr["lastname"].ToString();
                    grading_Information_Form.label_exam1.Text = dr["exam1"].ToString();
                    grading_Information_Form.label_exam2.Text = dr["exam2"].ToString();
                    grading_Information_Form.label_exam3.Text = dr["exam3"].ToString();
                    grading_Information_Form.label_average.Text = dr["average"].ToString();
                    if (dr["average"].ToString() != "" && Convert.ToDouble(grading_Information_Form.label_average.Text) >= 50)
                    {
                        grading_Information_Form.label_status.Text = "Başarılı";
                    }
                    else if (dr["average"].ToString() == "")
                    {
                        MessageBox.Show("Sınav Notlarınız Henüz Sisteme Yüklenmemiştir!");
                    }
                    else
                    {
                        grading_Information_Form.label_status.Text = "Başarısız";
                    }
                    grading_Information_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.");
                }
            }
        }
    }
}
