namespace GUI
{
    partial class AlumniActivities
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
            this.Btn_Previous = new System.Windows.Forms.Button();
            this.Btn_MyActivities = new System.Windows.Forms.Button();
            this.Btn_Unregister = new System.Windows.Forms.Button();
            this.Activites = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Location = new System.Drawing.Point(711, 396);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.Btn_Previous.TabIndex = 21;
            this.Btn_Previous.Text = "Previous";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // Btn_MyActivities
            // 
            this.Btn_MyActivities.Location = new System.Drawing.Point(616, 159);
            this.Btn_MyActivities.Name = "Btn_MyActivities";
            this.Btn_MyActivities.Size = new System.Drawing.Size(180, 52);
            this.Btn_MyActivities.TabIndex = 20;
            this.Btn_MyActivities.Text = "My Activities";
            this.Btn_MyActivities.UseVisualStyleBackColor = true;
            this.Btn_MyActivities.Click += new System.EventHandler(this.Btn_MyActivities_Click);
            // 
            // Btn_Unregister
            // 
            this.Btn_Unregister.Location = new System.Drawing.Point(711, 88);
            this.Btn_Unregister.Name = "Btn_Unregister";
            this.Btn_Unregister.Size = new System.Drawing.Size(75, 23);
            this.Btn_Unregister.TabIndex = 19;
            this.Btn_Unregister.Text = "Unregister";
            this.Btn_Unregister.UseVisualStyleBackColor = true;
            // 
            // Activites
            // 
            this.Activites.AutoSize = true;
            this.Activites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activites.Location = new System.Drawing.Point(10, 10);
            this.Activites.Name = "Activites";
            this.Activites.Size = new System.Drawing.Size(71, 16);
            this.Activites.TabIndex = 18;
            this.Activites.Text = "Activities";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(590, 391);
            this.dataGridView1.TabIndex = 17;
            // 
            // Btn_register
            // 
            this.Btn_register.Location = new System.Drawing.Point(711, 29);
            this.Btn_register.Name = "Btn_register";
            this.Btn_register.Size = new System.Drawing.Size(75, 23);
            this.Btn_register.TabIndex = 16;
            this.Btn_register.Text = "Register ";
            this.Btn_register.UseVisualStyleBackColor = true;
            // 
            // AlumniActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 448);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_MyActivities);
            this.Controls.Add(this.Btn_Unregister);
            this.Controls.Add(this.Activites);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_register);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlumniActivities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumni Activities";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_MyActivities;
        private System.Windows.Forms.Button Btn_Unregister;
        private System.Windows.Forms.Label Activites;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_register;
    }
}