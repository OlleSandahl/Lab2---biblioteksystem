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
        BusinessManager BusinessManager;
        
        

        public AdminHandleActicites()
        {
            
            InitializeComponent();
            ShowActivities();
            
        }
        public void ShowActivities()
        {
            UpdateDataGrid(BusinessManager.GetAktivity());
        }

       

        public void GetActivites()
        {
            UpdateDataGrid(BusinessManager.GetAktivity());
        }
        public void UpdateDataGrid(List<Aktivity> aktivities)
        {
            BindingSource.DataSource = aktivities;
            dataGridView1.DataSource = BindingSource;
            
        }


        private void Btn_edit_Click(object sender, EventArgs e)
        {
            AdminEditActivities adminEditActivities = new AdminEditActivities((Aktivity)dataGridView1.CurrentRow.DataBoundItem);
            this.Visible = !this.Visible;
            if (adminEditActivities.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
            GetActivites();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_createNew_Click(object sender, EventArgs e)
        {
            Aktivity newactivity = new Aktivity(
                Txtbox_activitieName.Text,
                TxtBox_description.Text);

            BusinessManager.CreateActivity(newactivity);

            Txtbox_activitieName.Clear();
            TxtBox_description.Clear();

            GetActivites();
            

        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                BusinessManager.DeleteAktivity((int)selectedRow.Cells[0].Value);
                UpdateDataGrid(BusinessManager.GetAktivity());

            }
        }
    }
}
