using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity.ClassModels;
using BuisnessLayer1;

namespace GUI
{
    public partial class AlumniMyInfo : Form
    {
        BusinessManager businessManager;
        public AlumniMyInfo()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void AlumniMyInfo_Load(object sender, EventArgs e)
        {

        }
        public AlumniMyInfo(BusinessManager businessManager)
        {
            this.businessManager = businessManager;
            InitializeComponent();

            Person inlogged = businessManager.GetLogIn();
            textBox_Username.Text = inlogged.Username;
            textBox_fName.Text = inlogged.Fname;
            textBox_lName.Text = inlogged.Lname;
            textBox_Email.Text = inlogged.Email;
            textBox_Password.Text = inlogged.Password;
            cb_gdpr.Text = "I have read the personal data policy\r\n and agree to the General Terms and Conditions.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_gdpr.Checked)
                {
                Alumnus newAlumn = new Alumnus(
                textBox_Username.Text,
                textBox_fName.Text,
                textBox_lName.Text,
                textBox_Email.Text,
                textBox_Password.Text);
                businessManager.UpdateAlumn(newAlumn);
                MessageBox.Show("Your personal information is updated");
                this.Close();
                }
                else
                    MessageBox.Show("You must agree to the General Terms and Conditions");
            

        }
    }
}
