namespace Student_Grading_Information_System
{
    partial class Student_Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_no = new System.Windows.Forms.Label();
            this.textBox_student_lastname = new System.Windows.Forms.TextBox();
            this.textBox_student_name = new System.Windows.Forms.TextBox();
            this.maskedTextBox_student_number = new System.Windows.Forms.MaskedTextBox();
            this.label_soyisim = new System.Windows.Forms.Label();
            this.label_isim = new System.Windows.Forms.Label();
            this.button_student_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_no.ForeColor = System.Drawing.Color.White;
            this.label_no.Location = new System.Drawing.Point(67, 214);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(73, 19);
            this.label_no.TabIndex = 20;
            this.label_no.Text = "NUMARA";
            // 
            // textBox_student_lastname
            // 
            this.textBox_student_lastname.Location = new System.Drawing.Point(171, 147);
            this.textBox_student_lastname.Name = "textBox_student_lastname";
            this.textBox_student_lastname.Size = new System.Drawing.Size(149, 20);
            this.textBox_student_lastname.TabIndex = 19;
            // 
            // textBox_student_name
            // 
            this.textBox_student_name.Location = new System.Drawing.Point(171, 86);
            this.textBox_student_name.Name = "textBox_student_name";
            this.textBox_student_name.Size = new System.Drawing.Size(149, 20);
            this.textBox_student_name.TabIndex = 18;
            // 
            // maskedTextBox_student_number
            // 
            this.maskedTextBox_student_number.Location = new System.Drawing.Point(171, 213);
            this.maskedTextBox_student_number.Name = "maskedTextBox_student_number";
            this.maskedTextBox_student_number.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBox_student_number.TabIndex = 17;
            // 
            // label_soyisim
            // 
            this.label_soyisim.AutoSize = true;
            this.label_soyisim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_soyisim.ForeColor = System.Drawing.Color.White;
            this.label_soyisim.Location = new System.Drawing.Point(67, 148);
            this.label_soyisim.Name = "label_soyisim";
            this.label_soyisim.Size = new System.Drawing.Size(65, 19);
            this.label_soyisim.TabIndex = 16;
            this.label_soyisim.Text = "SOYİSİM";
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_isim.ForeColor = System.Drawing.Color.White;
            this.label_isim.Location = new System.Drawing.Point(67, 87);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(39, 19);
            this.label_isim.TabIndex = 15;
            this.label_isim.Text = "İSİM";
            // 
            // button_student_login
            // 
            this.button_student_login.BackColor = System.Drawing.Color.White;
            this.button_student_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_student_login.ForeColor = System.Drawing.Color.Maroon;
            this.button_student_login.Location = new System.Drawing.Point(171, 259);
            this.button_student_login.Name = "button_student_login";
            this.button_student_login.Size = new System.Drawing.Size(149, 25);
            this.button_student_login.TabIndex = 14;
            this.button_student_login.Text = "GİRİŞ";
            this.button_student_login.UseVisualStyleBackColor = false;
            this.button_student_login.Click += new System.EventHandler(this.button_student_login_Click);
            // 
            // Student_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(429, 379);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.textBox_student_lastname);
            this.Controls.Add(this.textBox_student_name);
            this.Controls.Add(this.maskedTextBox_student_number);
            this.Controls.Add(this.label_soyisim);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.button_student_login);
            this.Name = "Student_Login_Form";
            this.Text = "Student_Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_no;
        public System.Windows.Forms.TextBox textBox_student_lastname;
        public System.Windows.Forms.TextBox textBox_student_name;
        public System.Windows.Forms.MaskedTextBox maskedTextBox_student_number;
        private System.Windows.Forms.Label label_soyisim;
        private System.Windows.Forms.Label label_isim;
        public System.Windows.Forms.Button button_student_login;
    }
}