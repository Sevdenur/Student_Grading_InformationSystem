namespace Student_Grading_Information_System
{
    partial class Login_Form
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
            this.teacher_login_button = new System.Windows.Forms.Button();
            this.student_login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacher_login_button
            // 
            this.teacher_login_button.BackColor = System.Drawing.Color.White;
            this.teacher_login_button.ForeColor = System.Drawing.Color.Maroon;
            this.teacher_login_button.Location = new System.Drawing.Point(109, 138);
            this.teacher_login_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.teacher_login_button.Name = "teacher_login_button";
            this.teacher_login_button.Size = new System.Drawing.Size(237, 50);
            this.teacher_login_button.TabIndex = 3;
            this.teacher_login_button.Text = "ÖĞRETMEN GİRİŞİ";
            this.teacher_login_button.UseVisualStyleBackColor = false;
            this.teacher_login_button.Click += new System.EventHandler(this.teacher_login_button_Click);
            // 
            // student_login_button
            // 
            this.student_login_button.BackColor = System.Drawing.Color.White;
            this.student_login_button.ForeColor = System.Drawing.Color.Maroon;
            this.student_login_button.Location = new System.Drawing.Point(109, 59);
            this.student_login_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.student_login_button.Name = "student_login_button";
            this.student_login_button.Size = new System.Drawing.Size(237, 50);
            this.student_login_button.TabIndex = 2;
            this.student_login_button.Text = "ÖĞRENCİ GİRİŞİ";
            this.student_login_button.UseVisualStyleBackColor = false;
            this.student_login_button.Click += new System.EventHandler(this.student_login_button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(460, 277);
            this.Controls.Add(this.teacher_login_button);
            this.Controls.Add(this.student_login_button);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacher_login_button;
        private System.Windows.Forms.Button student_login_button;
    }
}

