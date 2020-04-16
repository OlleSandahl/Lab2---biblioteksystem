using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer1;

namespace GUI
{
    public partial class StartUpForm : Form
    {
        
        BusinessManager businessManager = new BusinessManager();
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Btn_alumni_Click(object sender, EventArgs e)
        {

        }

        private void Btn_createNewAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            CreateAdmin createAdmin = new CreateAdmin();
            if (createAdmin.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Btn_createnewAlumni_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            CreateAlumni createAlumni = new CreateAlumni();
            if (createAlumni.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            var CorrectPassword = businessManager.VerifyLogIn(textBoxLogin.Text, textBoxLogInAlumniPassword.Text);
            if (CorrectPassword)
            {
                MessageBox.Show("you successfully logged in");
                if (businessManager.AlumnLogIn())
                {
                    AlumniMeny alumniMeny = new AlumniMeny(businessManager);
                    alumniMeny.ShowDialog();
                }
                else
                {
                    AdminMeny adminMeny = new AdminMeny(businessManager);
                    adminMeny.ShowDialog();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Username or password are incorrect", "Try again",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                
            }

            //Lisa","Karlsson","lisa@karlsson.com","karlsson

            //Global.CurrentUser = businessManager.GetUser(textBoxLogin.Text, textBoxLogInAlumniPassword.Text);

            //if (Global.CurrentUser == null)
            //{
            //    MessageBox.Show("Try again");
            //}
            //else
            //{
            //      if(businessManager.IsEmployee(Global.CurrentUser))
            //    {
            //        this.Visible = !this.Visible;
            //        AdminMeny adminMeny = new AdminMeny();
            //        if (adminMeny.ShowDialog() == DialogResult.OK)
            //            this.Visible = !this.Visible;
            //    }
            //      if(businessManager.IsAlumnus(Global.CurrentUser))
            //    {
            //        this.Visible = !this.Visible;
            //        AlumniMeny alumniMeny = new AlumniMeny();
            //        if (alumniMeny.ShowDialog() == DialogResult.OK)
            //            this.Visible = !this.Visible;
            //    }
        }
    }
        
    }

