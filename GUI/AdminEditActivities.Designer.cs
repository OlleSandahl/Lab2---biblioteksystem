namespace GUI
{
    partial class AdminEditActivities
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
            this.Btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbox_description = new System.Windows.Forms.TextBox();
            this.Txtbox_activitieName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Location = new System.Drawing.Point(463, 341);
            this.Btn_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(100, 28);
            this.Btn_Previous.TabIndex = 5;
            this.Btn_Previous.Text = "Previous";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(318, 341);
            this.Btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(100, 28);
            this.Btn_save.TabIndex = 4;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txtbox_description);
            this.groupBox1.Controls.Add(this.Txtbox_activitieName);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(540, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit activitie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activitie description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activitie name";
            // 
            // Txtbox_description
            // 
            this.Txtbox_description.Location = new System.Drawing.Point(144, 97);
            this.Txtbox_description.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbox_description.Multiline = true;
            this.Txtbox_description.Name = "Txtbox_description";
            this.Txtbox_description.Size = new System.Drawing.Size(387, 184);
            this.Txtbox_description.TabIndex = 1;
            // 
            // Txtbox_activitieName
            // 
            this.Txtbox_activitieName.Location = new System.Drawing.Point(144, 54);
            this.Txtbox_activitieName.Margin = new System.Windows.Forms.Padding(4);
            this.Txtbox_activitieName.Name = "Txtbox_activitieName";
            this.Txtbox_activitieName.Size = new System.Drawing.Size(347, 22);
            this.Txtbox_activitieName.TabIndex = 0;
            // 
            // EditActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 433);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditActivities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Activities";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Previous;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbox_description;
        private System.Windows.Forms.TextBox Txtbox_activitieName;
    }
}