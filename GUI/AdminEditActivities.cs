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
    public partial class AdminEditActivities : Form
    {
        private BusinessManager BusinessManager = new BusinessManager();

        private Aktivity Aktivity { get; set; }
        public AdminEditActivities(Aktivity aktivity)
        {
            InitializeComponent();
            this.Aktivity = aktivity;
        }

        public void Fillaktivites()
        {
            Txtbox_activitieName.Text = Aktivity.Name;
            Txtbox_description.Text = Aktivity.Description;
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(lblNA.Text, out id) && lblNA.Text !="na")
            {
                Aktivity NewActivity = new Aktivity(Txtbox_activitieName.Text, Txtbox_description.Text);

                BusinessManager.EditActivity(id, NewActivity);

                MessageBox.Show("Edit completed");
            }
            //if (lblNA.Text == "na")
            //{
            //    Aktivity Newaktivity = new Aktivity(Txtbox_activitieName.Text, Txtbox_description.Text);
            //    BusinessManager.CreateActivity(Newaktivity);
            //}
            
            
            
            

            
            
            //Aktivity.Name = Txtbox_activitieName.Text;
            //Aktivity.Description = Txtbox_description.Text;

            //BusinessManager.EditActivity(id, Newaktivity);

            

            
        }
    }
}
