namespace GUI
{
    partial class Log_in_Admin
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
            this.textBoxLogInAdminPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginadmin = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_adminId = new System.Windows.Forms.Label();
            this.btn_LogInAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(12, 496);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(100, 28);
            this.Btn_exit.TabIndex = 32;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(947, 496);
            this.Btn_previous.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(100, 28);
            this.Btn_previous.TabIndex = 31;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // textBoxLogInAdminPassword
            // 
            this.textBoxLogInAdminPassword.Location = new System.Drawing.Point(231, 163);
            this.textBoxLogInAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogInAdminPassword.Name = "textBoxLogInAdminPassword";
            this.textBoxLogInAdminPassword.Size = new System.Drawing.Size(211, 22);
            this.textBoxLogInAdminPassword.TabIndex = 30;
            this.textBoxLogInAdminPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginadmin
            // 
            this.textBoxLoginadmin.Location = new System.Drawing.Point(231, 99);
            this.textBoxLoginadmin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginadmin.Name = "textBoxLoginadmin";
            this.textBoxLoginadmin.Size = new System.Drawing.Size(211, 22);
            this.textBoxLoginadmin.TabIndex = 29;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(125, 163);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(91, 20);
            this.txt_password.TabIndex = 28;
            this.txt_password.Text = "Password";
            // 
            // txt_adminId
            // 
            this.txt_adminId.AutoSize = true;
            this.txt_adminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adminId.Location = new System.Drawing.Point(135, 99);
            this.txt_adminId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_adminId.Name = "txt_adminId";
            this.txt_adminId.Size = new System.Drawing.Size(80, 20);
            this.txt_adminId.TabIndex = 27;
            this.txt_adminId.Text = "AdminID";
            // 
            // btn_LogInAdmin
            // 
            this.btn_LogInAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogInAdmin.Location = new System.Drawing.Point(231, 210);
            this.btn_LogInAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogInAdmin.Name = "btn_LogInAdmin";
            this.btn_LogInAdmin.Size = new System.Drawing.Size(212, 75);
            this.btn_LogInAdmin.TabIndex = 26;
            this.btn_LogInAdmin.Text = "Log in";
            this.btn_LogInAdmin.UseVisualStyleBackColor = true;
            // 
            // Log_in_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 536);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.textBoxLogInAdminPassword);
            this.Controls.Add(this.textBoxLoginadmin);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_adminId);
            this.Controls.Add(this.btn_LogInAdmin);
            this.Name = "Log_in_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.TextBox textBoxLogInAdminPassword;
        private System.Windows.Forms.TextBox textBoxLoginadmin;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Label txt_adminId;
        private System.Windows.Forms.Button btn_LogInAdmin;
    }
}