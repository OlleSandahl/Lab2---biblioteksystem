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
using BusinessEntity.ClassModels;

namespace GUI
{
    public partial class Admin_Handle_Alumni : Form
    {
        BindingSource bindingSource = new BindingSource();
        BusinessManager BusinessManager;
        

        public Admin_Handle_Alumni(BusinessManager businessManager  )
        {
            this.BusinessManager = businessManager;
            InitializeComponent();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
