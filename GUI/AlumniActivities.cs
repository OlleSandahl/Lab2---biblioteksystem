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
    public partial class AlumniActivities : Form
    {
        BusinessManager businessManager = new BusinessManager();

        public AlumniActivities()
        {
        }

        public AlumniActivities(BusinessManager businessManager)
        {
            this.businessManager = businessManager;
            InitializeComponent();
        }

        private void Btn_MyActivities_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            AlumniMyActivities alumniMyActivities = new AlumniMyActivities();
            if (alumniMyActivities.ShowDialog() == DialogResult.OK)
                this.Visible = !this.Visible;
        }
    }
}
