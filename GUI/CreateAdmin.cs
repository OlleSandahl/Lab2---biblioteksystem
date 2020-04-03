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
using DataLayer1;
using BusinessEntity.ClassModels;

namespace GUI
{
    public partial class CreateAdmin : Form
    {
        //buisness manger ska in här man kan inte tillämpa det!! help
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (password_txtbox.Text == Cpassword_txtbox.Text)
            {
                string username = UserN_txtbox.Text;
                string password = password_txtbox.Text;
                string email = Emai_txtbox.Text;
                string fname = Fname_txtbox.Text;
                string lname = Lname_txtbox.Text;
                string persnumber = Pnr_txtbox.Text;
                string EmployeeNR = EmployeeNR_txtbox.Text;

                Employee employee = new Employee();
                employee.Username = username;
                employee.Password = password;
                employee.Email = email;
                employee.Fname = fname;
                employee.Lname = lname;
                employee.PersonCode = persnumber;
                employee.EmployeeId = EmployeeNR;

                BusinessManger.CreateEmployee(employee);
                DialogResult = DialogResult.OK;
                
                
            }
        }
    }
}
