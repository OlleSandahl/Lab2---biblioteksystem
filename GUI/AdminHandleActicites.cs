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
    public partial class AdminHandleActicites : Form
    {
        BindingSource BindingSource = new BindingSource();
        BusinessManager BusinessManager = new BusinessManager();


        public AdminHandleActicites( BusinessManager businessManager)
        {
            this.BusinessManager = businessManager;
            InitializeComponent();
            
        }

        public AdminHandleActicites()
        {
        }

        public void GetActivites()
        {
            
        }
        public void UpdateDataGrid(List<Aktivity> aktivities)
        {
            BindingSource.DataSource = aktivities;
            dataGridView1.DataSource = BindingSource;
            
        }


        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_createNew_Click(object sender, EventArgs e)
        {
            //Aktivity aktivity = new Aktivity(
            //    Txtbox_activitieName.Text,
            //    TxtBox_description.Text);

            //BusinessManager.c

        }
    }
}
