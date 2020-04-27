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
    public partial class AlumniActivities : Form
    {
        BindingSource bindingSource = new BindingSource();
        BusinessManager businessManager = new BusinessManager();
        public AlumniActivities(BusinessManager businessManager)
        {
            this.businessManager = businessManager;
            InitializeComponent();
        }

        private void Btn_MyActivities_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            AlumniMyInfo alumniMyActivities = new AlumniMyInfo();
            if (alumniMyActivities.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        public void UpdateActivityGrid (List<Aktivity> list)
        {
            bindingSource.DataSource = list;
            dataGridView1.DataSource = bindingSource;
        }
        public void ShowActivities ()
        {
            UpdateActivityGrid(businessManager.GetAktivities());
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount =
            dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                int id = (int)selectedRow.Cells[0].Value;
                var aktivities = businessManager.GetAktivity(id);
                businessManager.CreateActivity(aktivities);
                MessageBox.Show($" You are registred at: {aktivities.Name}");
                this.Close();
            }
        }
    }
}
