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

        }
    }
}
