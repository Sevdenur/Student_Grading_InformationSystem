namespace Student_Grading_Information_System
{
    partial class Teacher_Login_Form
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
            this.textBox_teacher_password = new System.Windows.Forms.TextBox();
            this.textBox_teacher_lastname = new System.Windows.Forms.TextBox();
            this.textBox_teacher_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_teacher_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_teacher_password
            // 
            this.textBox_teacher_password.Location = new System.Drawing.Point(144, 188);
            this.textBox_teacher_password.Name = "textBox_teacher_password";
            this.textBox_teacher_password.Size = new System.Drawing.Size(142, 20);
            this.textBox_teacher_password.TabIndex = 23;
            // 
            // textBox_teacher_lastname
            // 
            this.textBox_teacher_lastname.Location = new System.Drawing.Point(144, 136);
            this.textBox_teacher_lastname.Name = "textBox_teacher_lastname";
            this.textBox_teacher_lastname.Size = new System.Drawing.Size(142, 20);
            this.textBox_teacher_lastname.TabIndex = 22;
            // 
            // textBox_teacher_name
            // 
            this.textBox_teacher_name.Location = new System.Drawing.Point(144, 81);
            this.textBox_teacher_name.Name = "textBox_teacher_name";
            this.textBox_teacher_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_teacher_name.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "SOYİSİM";
            // 
            // button_teacher_login
            // 
            this.button_teacher_login.BackColor = System.Drawing.Color.White;
            this.button_teacher_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_teacher_login.ForeColor = System.Drawing.Color.Maroon;
            this.button_teacher_login.Location = new System.Drawing.Point(144, 234);
            this.button_teacher_login.Name = "button_teacher_login";
            this.button_teacher_login.Size = new System.Drawing.Size(142, 25);
            this.button_teacher_login.TabIndex = 19;
            this.button_teacher_login.Text = "GİRİŞ";
            this.button_teacher_login.UseVisualStyleBackColor = false;
            this.button_teacher_login.Click += new System.EventHandler(this.button_teacher_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "İSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "ŞİFRE";
            // 
            // Teacher_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(386, 346);
            this.Controls.Add(this.textBox_teacher_password);
            this.Controls.Add(this.textBox_teacher_lastname);
            this.Controls.Add(this.textBox_teacher_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_teacher_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teacher_Login_Form";
            this.Text = "Teacher_Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_teacher_password;
        private System.Windows.Forms.TextBox textBox_teacher_lastname;
        private System.Windows.Forms.TextBox textBox_teacher_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_teacher_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}