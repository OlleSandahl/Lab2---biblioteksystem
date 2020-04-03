namespace GUI
{
    partial class StartUpForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_createnewAlumni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_createNewAdmin = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Txt_select = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogInAlumniPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginaAlumni = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Create new Alumni";
            // 
            // Btn_createnewAlumni
            // 
            this.Btn_createnewAlumni.Location = new System.Drawing.Point(743, 515);
            this.Btn_createnewAlumni.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_createnewAlumni.Name = "Btn_createnewAlumni";
            this.Btn_createnewAlumni.Size = new System.Drawing.Size(121, 44);
            this.Btn_createnewAlumni.TabIndex = 22;
            this.Btn_createnewAlumni.Text = "Create new";
            this.Btn_createnewAlumni.UseVisualStyleBackColor = true;
            this.Btn_createnewAlumni.Click += new System.EventHandler(this.Btn_createnewAlumni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Create new admin";
            // 
            // Btn_createNewAdmin
            // 
            this.Btn_createNewAdmin.Location = new System.Drawing.Point(201, 515);
            this.Btn_createNewAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_createNewAdmin.Name = "Btn_createNewAdmin";
            this.Btn_createNewAdmin.Size = new System.Drawing.Size(121, 44);
            this.Btn_createNewAdmin.TabIndex = 20;
            this.Btn_createNewAdmin.Text = "Create new";
            this.Btn_createNewAdmin.UseVisualStyleBackColor = true;
            this.Btn_createNewAdmin.Click += new System.EventHandler(this.Btn_createNewAdmin_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(965, 531);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 28);
            this.Exit_btn.TabIndex = 19;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Txt_select
            // 
            this.Txt_select.AutoSize = true;
            this.Txt_select.Location = new System.Drawing.Point(413, 73);
            this.Txt_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_select.Name = "Txt_select";
            this.Txt_select.Size = new System.Drawing.Size(236, 17);
            this.Txt_select.TabIndex = 18;
            this.Txt_select.Text = "please select one of the alternatives";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(397, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome to the program!";
            // 
            // textBoxLogInAlumniPassword
            // 
            this.textBoxLogInAlumniPassword.Location = new System.Drawing.Point(440, 232);
            this.textBoxLogInAlumniPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogInAlumniPassword.Name = "textBoxLogInAlumniPassword";
            this.textBoxLogInAlumniPassword.Size = new System.Drawing.Size(211, 22);
            this.textBoxLogInAlumniPassword.TabIndex = 34;
            this.textBoxLogInAlumniPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginaAlumni
            // 
            this.textBoxLoginaAlumni.Location = new System.Drawing.Point(440, 168);
            this.textBoxLoginaAlumni.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginaAlumni.Name = "textBoxLoginaAlumni";
            this.textBoxLoginaAlumni.Size = new System.Drawing.Size(211, 22);
            this.textBoxLoginaAlumni.TabIndex = 33;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(338, 232);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(91, 20);
            this.txt_password.TabIndex = 32;
            this.txt_password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.AutoSize = true;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(338, 168);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(94, 20);
            this.txt_Username.TabIndex = 31;
            this.txt_Username.Text = "Username";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(440, 279);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(212, 75);
            this.btn_LogIn.TabIndex = 30;
            this.btn_LogIn.Text = "Log in";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 579);
            this.Controls.Add(this.textBoxLogInAlumniPassword);
            this.Controls.Add(this.textBoxLoginaAlumni);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_createnewAlumni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_createNewAdmin);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Txt_select);
            this.Controls.Add(this.label1);
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Up Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_createnewAlumni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_createNewAdmin;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label Txt_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogInAlumniPassword;
        private System.Windows.Forms.TextBox textBoxLoginaAlumni;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Label txt_Username;
        private System.Windows.Forms.Button btn_LogIn;
    }
}

