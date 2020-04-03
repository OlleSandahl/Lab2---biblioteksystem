namespace GUI
{
    partial class LogInAlumni
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
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_previous = new System.Windows.Forms.Button();
            this.textBoxLogInAlumniPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginaAlumni = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_AlumniID = new System.Windows.Forms.Label();
            this.btn_LogInAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(14, 414);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(100, 28);
            this.Btn_exit.TabIndex = 31;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(949, 414);
            this.Btn_previous.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(100, 28);
            this.Btn_previous.TabIndex = 30;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // textBoxLogInAlumniPassword
            // 
            this.textBoxLogInAlumniPassword.Location = new System.Drawing.Point(239, 96);
            this.textBoxLogInAlumniPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogInAlumniPassword.Name = "textBoxLogInAlumniPassword";
            this.textBoxLogInAlumniPassword.Size = new System.Drawing.Size(211, 22);
            this.textBoxLogInAlumniPassword.TabIndex = 29;
            this.textBoxLogInAlumniPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginaAlumni
            // 
            this.textBoxLoginaAlumni.Location = new System.Drawing.Point(239, 32);
            this.textBoxLoginaAlumni.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginaAlumni.Name = "textBoxLoginaAlumni";
            this.textBoxLoginaAlumni.Size = new System.Drawing.Size(211, 22);
            this.textBoxLoginaAlumni.TabIndex = 28;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(134, 96);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(91, 20);
            this.txt_password.TabIndex = 27;
            this.txt_password.Text = "Password";
            // 
            // txt_AlumniID
            // 
            this.txt_AlumniID.AutoSize = true;
            this.txt_AlumniID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AlumniID.Location = new System.Drawing.Point(143, 32);
            this.txt_AlumniID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_AlumniID.Name = "txt_AlumniID";
            this.txt_AlumniID.Size = new System.Drawing.Size(85, 20);
            this.txt_AlumniID.TabIndex = 26;
            this.txt_AlumniID.Text = "AlumniID";
            // 
            // btn_LogInAdmin
            // 
            this.btn_LogInAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogInAdmin.Location = new System.Drawing.Point(239, 143);
            this.btn_LogInAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogInAdmin.Name = "btn_LogInAdmin";
            this.btn_LogInAdmin.Size = new System.Drawing.Size(212, 75);
            this.btn_LogInAdmin.TabIndex = 25;
            this.btn_LogInAdmin.Text = "Log in";
            this.btn_LogInAdmin.UseVisualStyleBackColor = true;
            // 
            // LogInAlumni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 454);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.textBoxLogInAlumniPassword);
            this.Controls.Add(this.textBoxLoginaAlumni);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_AlumniID);
            this.Controls.Add(this.btn_LogInAdmin);
            this.Name = "LogInAlumni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in Alumni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.TextBox textBoxLogInAlumniPassword;
        private System.Windows.Forms.TextBox textBoxLoginaAlumni;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Label txt_AlumniID;
        private System.Windows.Forms.Button btn_LogInAdmin;
    }
}