namespace GUI
{
    partial class AlumniMeny
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Btn_Activities = new System.Windows.Forms.Button();
            this.Btn_MyProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(944, 468);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 34);
            this.btnLogOut.TabIndex = 21;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Btn_Activities
            // 
            this.Btn_Activities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Activities.Location = new System.Drawing.Point(643, 165);
            this.Btn_Activities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Activities.Name = "Btn_Activities";
            this.Btn_Activities.Size = new System.Drawing.Size(289, 126);
            this.Btn_Activities.TabIndex = 20;
            this.Btn_Activities.Text = "Activities";
            this.Btn_Activities.UseVisualStyleBackColor = true;
            this.Btn_Activities.Click += new System.EventHandler(this.Btn_Activities_Click);
            // 
            // Btn_MyProfile
            // 
            this.Btn_MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MyProfile.Location = new System.Drawing.Point(105, 165);
            this.Btn_MyProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_MyProfile.Name = "Btn_MyProfile";
            this.Btn_MyProfile.Size = new System.Drawing.Size(289, 126);
            this.Btn_MyProfile.TabIndex = 19;
            this.Btn_MyProfile.Text = "My profile";
            this.Btn_MyProfile.UseVisualStyleBackColor = true;
            this.Btn_MyProfile.Click += new System.EventHandler(this.Btn_MyProfile_Click);
            // 
            // AlumniMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 516);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.Btn_Activities);
            this.Controls.Add(this.Btn_MyProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlumniMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumni Meny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button Btn_Activities;
        private System.Windows.Forms.Button Btn_MyProfile;
    }
}