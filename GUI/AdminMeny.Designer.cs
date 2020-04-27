using System;

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
            this.Btn_programs.Location = new System.Drawing.Point(118, 7);
            this.Btn_programs.Name = "Btn_programs";
            this.Btn_programs.Size = new System.Drawing.Size(106, 37);
            this.Btn_programs.TabIndex = 22;
            this.Btn_programs.Text = "Show Programs";
            this.Btn_programs.UseVisualStyleBackColor = true;
            this.Btn_programs.Click += new System.EventHandler(this.Btn_programs_Click);
            // 
            // Btn_sections
            // 
            this.Btn_sections.Location = new System.Drawing.Point(6, 7);
            this.Btn_sections.Name = "Btn_sections";
            this.Btn_sections.Size = new System.Drawing.Size(106, 37);
            this.Btn_sections.TabIndex = 21;
            this.Btn_sections.Text = "Show Sections";
            this.Btn_sections.UseVisualStyleBackColor = true;
            this.Btn_sections.Click += new System.EventHandler(this.Btn_sections_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(697, 405);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(85, 28);
            this.BtnLogOut.TabIndex = 20;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // Btn_HandleAlumni
            // 
            this.Btn_HandleAlumni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HandleAlumni.Location = new System.Drawing.Point(487, 159);
            this.Btn_HandleAlumni.Name = "Btn_HandleAlumni";
            this.Btn_HandleAlumni.Size = new System.Drawing.Size(217, 102);
            this.Btn_HandleAlumni.TabIndex = 19;
            this.Btn_HandleAlumni.Text = "Handle alumni";
            this.Btn_HandleAlumni.UseVisualStyleBackColor = true;
            this.Btn_HandleAlumni.Click += new System.EventHandler(this.Btn_HandleAlumni_Click);
            // 
            // Btn_handleactivities
            // 
            this.Btn_handleactivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_handleactivities.Location = new System.Drawing.Point(68, 159);
            this.Btn_handleactivities.Name = "Btn_handleactivities";
            this.Btn_handleactivities.Size = new System.Drawing.Size(217, 102);
            this.Btn_handleactivities.TabIndex = 18;
            this.Btn_handleactivities.Text = "Handle activities";
            this.Btn_handleactivities.UseVisualStyleBackColor = true;
            this.Btn_handleactivities.Click += new System.EventHandler(this.Btn_handleactivities_Click);
            // 
            // AdminMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.Btn_programs);
            this.Controls.Add(this.Btn_sections);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.Btn_HandleAlumni);
            this.Controls.Add(this.Btn_handleactivities);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Meny";
            this.ResumeLayout(false);

        }

        private void Btn_programs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Btn_programs;
        private System.Windows.Forms.Button Btn_sections;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button Btn_HandleAlumni;
        private System.Windows.Forms.Button Btn_handleactivities;
    }
}