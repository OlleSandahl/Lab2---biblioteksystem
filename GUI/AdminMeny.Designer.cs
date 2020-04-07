namespace GUI
{
    partial class AdminMeny
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
            this.Btn_programs = new System.Windows.Forms.Button();
            this.Btn_sections = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.Btn_HandleAlumni = new System.Windows.Forms.Button();
            this.Btn_handleactivities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_programs
            // 
            this.Btn_programs.Location = new System.Drawing.Point(157, 9);
            this.Btn_programs.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_programs.Name = "Btn_programs";
            this.Btn_programs.Size = new System.Drawing.Size(141, 46);
            this.Btn_programs.TabIndex = 22;
            this.Btn_programs.Text = "Show Programs";
            this.Btn_programs.UseVisualStyleBackColor = true;
            // 
            // Btn_sections
            // 
            this.Btn_sections.Location = new System.Drawing.Point(8, 9);
            this.Btn_sections.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sections.Name = "Btn_sections";
            this.Btn_sections.Size = new System.Drawing.Size(141, 46);
            this.Btn_sections.TabIndex = 21;
            this.Btn_sections.Text = "Show Sections";
            this.Btn_sections.UseVisualStyleBackColor = true;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(929, 499);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(113, 34);
            this.BtnLogOut.TabIndex = 20;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            // 
            // Btn_HandleAlumni
            // 
            this.Btn_HandleAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HandleAlumni.Location = new System.Drawing.Point(649, 196);
            this.Btn_HandleAlumni.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_HandleAlumni.Name = "Btn_HandleAlumni";
            this.Btn_HandleAlumni.Size = new System.Drawing.Size(289, 126);
            this.Btn_HandleAlumni.TabIndex = 19;
            this.Btn_HandleAlumni.Text = "Handle alumni";
            this.Btn_HandleAlumni.UseVisualStyleBackColor = true;
            this.Btn_HandleAlumni.Click += new System.EventHandler(this.Btn_HandleAlumni_Click);
            // 
            // Btn_handleactivities
            // 
            this.Btn_handleactivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_handleactivities.Location = new System.Drawing.Point(91, 196);
            this.Btn_handleactivities.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_handleactivities.Name = "Btn_handleactivities";
            this.Btn_handleactivities.Size = new System.Drawing.Size(289, 126);
            this.Btn_handleactivities.TabIndex = 18;
            this.Btn_handleactivities.Text = "Handle activities";
            this.Btn_handleactivities.UseVisualStyleBackColor = true;
            // 
            // AdminMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 546);
            this.Controls.Add(this.Btn_programs);
            this.Controls.Add(this.Btn_sections);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.Btn_HandleAlumni);
            this.Controls.Add(this.Btn_handleactivities);
            this.Name = "AdminMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Meny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_programs;
        private System.Windows.Forms.Button Btn_sections;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button Btn_HandleAlumni;
        private System.Windows.Forms.Button Btn_handleactivities;
    }
}