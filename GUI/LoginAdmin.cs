using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Log_in_Admin : Form
    {
        public Log_in_Admin()
        {
            InitializeComponent();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
