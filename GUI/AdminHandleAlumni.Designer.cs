namespace GUI
{
    partial class Admin_Handle_Alumni
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.Btn_search = new System.Windows.Forms.Button();
            this.TxtBox_SearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_previous = new System.Windows.Forms.Button();
            this.btnSkapaAlumn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxLname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxFirstName = new System.Windows.Forms.TextBox();
            this.Txtbox_Program = new System.Windows.Forms.Label();
            this.TxtBox_username = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxPassWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAlumnArbetsgivare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Delete one selected activitie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // Btn_delete
            // 
            this.Btn_delete.Location = new System.Drawing.Point(12, 410);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_delete.TabIndex = 17;
            this.Btn_delete.Text = "Delete";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(280, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 13);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search for name";
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(545, 6);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(75, 23);
            this.Btn_search.TabIndex = 15;
            this.Btn_search.Text = "Search";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // TxtBox_SearchName
            // 
            this.TxtBox_SearchName.Location = new System.Drawing.Point(371, 8);
            this.TxtBox_SearchName.Name = "TxtBox_SearchName";
            this.TxtBox_SearchName.Size = new System.Drawing.Size(168, 20);
            this.TxtBox_SearchName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "List of registered alumni";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(612, 339);
            this.dataGridView1.TabIndex = 12;
            // 
            // Btn_previous
            // 
            this.Btn_previous.Location = new System.Drawing.Point(848, 410);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(106, 23);
            this.Btn_previous.TabIndex = 20;
            this.Btn_previous.Text = "Previous";
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // btnSkapaAlumn
            // 
            this.btnSkapaAlumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkapaAlumn.Location = new System.Drawing.Point(848, 325);
            this.btnSkapaAlumn.Name = "btnSkapaAlumn";
            this.btnSkapaAlumn.Size = new System.Drawing.Size(110, 27);
            this.btnSkapaAlumn.TabIndex = 21;
            this.btnSkapaAlumn.Text = "Skapa Alumn";
            this.btnSkapaAlumn.UseVisualStyleBackColor = true;
            this.btnSkapaAlumn.Click += new System.EventHandler(this.btnSkapaAlumn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email";
            // 
            // TxtBoxLname
            // 
            this.TxtBoxLname.Location = new System.Drawing.Point(150, 99);
            this.TxtBoxLname.Multiline = true;
            this.TxtBoxLname.Name = "TxtBoxLname";
            this.TxtBoxLname.Size = new System.Drawing.Size(127, 20);
            this.TxtBoxLname.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // TxtBoxFirstName
            // 
            this.TxtBoxFirstName.Location = new System.Drawing.Point(150, 66);
            this.TxtBoxFirstName.Name = "TxtBoxFirstName";
            this.TxtBoxFirstName.Size = new System.Drawing.Size(127, 20);
            this.TxtBoxFirstName.TabIndex = 11;
            // 
            // Txtbox_Program
            // 
            this.Txtbox_Program.AutoSize = true;
            this.Txtbox_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_Program.Location = new System.Drawing.Point(38, 192);
            this.Txtbox_Program.Name = "Txtbox_Program";
            this.Txtbox_Program.Size = new System.Drawing.Size(46, 13);
            this.Txtbox_Program.TabIndex = 16;
            this.Txtbox_Program.Text = "Program";
            // 
            // TxtBox_username
            // 
            this.TxtBox_username.Location = new System.Drawing.Point(150, 34);
            this.TxtBox_username.Name = "TxtBox_username";
            this.TxtBox_username.Size = new System.Drawing.Size(127, 20);
            this.TxtBox_username.TabIndex = 9;
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(150, 129);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(127, 20);
            this.TxtBoxEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last name";
            // 
            // TxtBoxPassWord
            // 
            this.TxtBoxPassWord.Location = new System.Drawing.Point(150, 161);
            this.TxtBoxPassWord.Name = "TxtBoxPassWord";
            this.TxtBoxPassWord.Size = new System.Drawing.Size(127, 20);
            this.TxtBoxPassWord.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "First name";
            // 
            // textBoxAlumnArbetsgivare
            // 
            this.textBoxAlumnArbetsgivare.Location = new System.Drawing.Point(150, 192);
            this.textBoxAlumnArbetsgivare.Name = "textBoxAlumnArbetsgivare";
            this.textBoxAlumnArbetsgivare.Size = new System.Drawing.Size(127, 20);
            this.textBoxAlumnArbetsgivare.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // Cbox
            // 
            this.Cbox.AutoSize = true;
            this.Cbox.Location = new System.Drawing.Point(62, 228);
            this.Cbox.Name = "Cbox";
            this.Cbox.Size = new System.Drawing.Size(215, 17);
            this.Cbox.TabIndex = 20;
            this.Cbox.Text = "Alumn har godkänt att information lagras";
            this.Cbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAlumnArbetsgivare);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBoxPassWord);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtBoxEmail);
            this.groupBox1.Controls.Add(this.TxtBox_username);
            this.groupBox1.Controls.Add(this.Txtbox_Program);
            this.groupBox1.Controls.Add(this.TxtBoxFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtBoxLname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(652, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 258);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa ny alumn";
            // 
            // Admin_Handle_Alumni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSkapaAlumn);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.TxtBox_SearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_Handle_Alumni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Handle Alumni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.TextBox TxtBox_SearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.Button btnSkapaAlumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBoxLname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxFirstName;
        private System.Windows.Forms.Label Txtbox_Program;
        private System.Windows.Forms.TextBox TxtBox_username;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBoxPassWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAlumnArbetsgivare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Cbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}