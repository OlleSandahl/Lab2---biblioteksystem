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
    public partial class CreateAlumni : Form
    {
        BusinessManager businessManager = new BusinessManager();
        public CreateAlumni()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_registerAlumn_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text == Cpassword_txtbox.Text)
            {
                string username = UserN_txtbox.Text;
                string password = password_txtbox.Text;
                string email = Emai_txtbox.Text;
                string fName = Fname_txtbox.Text;
                string lName = Lname_txtbox.Text;
                int alumnNumber = int.Parse(Snr_txtbox.Text);
                string persCode = Pnr_txtbox.Text;

                Alumnus alumnus = new Alumnus(username, fName, lName, email, password);
                alumnus.Username = username;
                alumnus.Password = password;
                alumnus.PersonCode = persCode;
                alumnus.AlumnusId = alumnNumber;
                alumnus.Fname = fName;
                alumnus.Lname = lName;
                alumnus.Email = email;

                businessManager.CreateAlumnus(alumnus);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
