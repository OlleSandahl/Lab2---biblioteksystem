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
    public partial class AdminMeny : Form
    {
        BusinessManager businessManager = new BusinessManager();
        public AdminMeny(BusinessManager businessManager)
        {
            this.businessManager = businessManager;
            InitializeComponent();
        }


        private void Btn_HandleAlumni_Click(object sender, EventArgs e)
        {
                      
            Admin_Handle_Alumni admin_Handle_Alumni = new Admin_Handle_Alumni(businessManager);
            this.Visible = !this.Visible;
            if (admin_Handle_Alumni.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Btn_handleactivities_Click(object sender, EventArgs e)
        {
            AdminHandleActicites adminHandleActicites = new AdminHandleActicites();
            this.Visible = !this.Visible;
            if (adminHandleActicites.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sections_Click(object sender, EventArgs e)
        {

        }
    }
}
