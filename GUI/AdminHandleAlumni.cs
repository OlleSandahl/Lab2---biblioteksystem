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
        

        public Admin_Handle_Alumni(BusinessManager businessManager )
        {
            this.BusinessManager = businessManager;
            InitializeComponent();
            
        }

        public void ShowAlumni()
        {
            UpdateDataGrid(BusinessManager.GetAlumni());
        }

        public void showAktivities()
        {
            UpdateDataGrid(BusinessManager.GetAktivities());
        }

        public void UpdateDataGrid(List<Alumnus> list)
        {
            bindingSource.DataSource = list;
            dataGridView1.DataSource = bindingSource;
        }
        public void UpdateDataGrid(List<Aktivity> list)
        {
            bindingSource.DataSource = list;
            dataGridView1.DataSource = bindingSource;
        }
        public void SearchAlumni()
        {
            string search = TxtBox_SearchName.Text;

        }


        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0 )
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                BusinessManager.DeleteAlumnus((int)selectedRow.Cells[0].Value);
                UpdateDataGrid(BusinessManager.GetAlumni());
            }


        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            SearchAlumni();
        }

        private void btnSkapaAlumn_Click(object sender, EventArgs e)
        {
            if (Cbox.Checked)
            {
                Alumnus alumnus = new Alumnus(
                    TxtBox_username.Text,
                    TxtBoxFirstName.Text,
                    TxtBoxLname.Text,
                    TxtBoxEmail.Text,
                    TxtBoxPassWord.Text);

                BusinessManager.CreateAlumnus(alumnus);

                TxtBox_username.Clear();
                TxtBoxFirstName.Clear();
                TxtBoxLname.Clear();
                TxtBoxEmail.Clear();
                TxtBoxPassWord.Clear();

                ShowAlumni();
            }
            else
            {
                MessageBox.Show("You have not confirmed the information to be saved");
            }
        }
    }
}
