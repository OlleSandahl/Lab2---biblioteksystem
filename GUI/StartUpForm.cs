using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StartUpForm : Form
    {
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
    }
}
