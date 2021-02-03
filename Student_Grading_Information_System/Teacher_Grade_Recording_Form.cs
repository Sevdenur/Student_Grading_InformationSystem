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
    public partial class Teacher_Grade_Recording_Form : Form
    {
        public Teacher_Grade_Recording_Form()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2DKOFA8;Initial Catalog=Grade_Information_Db;Integrated Security=True");

        private void Teacher_Grade_Recording_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grade_Information_DbDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.grade_Information_DbDataSet.Students);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            maskedTextBox_number.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            textBox_lastname.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            textBox_exam1.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            textBox_exam2.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            textBox_exam3.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            textBox_average.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(textBox_exam1.Text);
            s2 = Convert.ToDouble(textBox_exam2.Text);
            s3 = Convert.ToDouble(textBox_exam3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            textBox_average.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            connection.Open();
            SqlCommand command = new SqlCommand("update students set exam1=@P1, exam2=@P2, exam3=@P3, average=@P4, status=@P5 WHERE number=@P6", connection);
            command.Parameters.AddWithValue("@P1", textBox_exam1.Text);
            command.Parameters.AddWithValue("@P2", textBox_exam2.Text);
            command.Parameters.AddWithValue("@P3", textBox_exam3.Text);
            command.Parameters.AddWithValue("@P4", decimal.Parse(textBox_average.Text));
            command.Parameters.AddWithValue("@P5", durum);
            command.Parameters.AddWithValue("@P6", maskedTextBox_number.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.studentsTableAdapter.Fill(this.grade_Information_DbDataSet.Students);
        }
    }
}
