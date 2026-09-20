using System;
using System.Windows.Forms;

namespace AirlineManagementApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); // Simply close the About dialog
        }
    }
}
