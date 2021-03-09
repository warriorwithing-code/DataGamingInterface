using DataGamingInterface.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGamingInterface
{
    public partial class FormWelcome : Form
    {
        FormHome formHome;
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            formHome = new FormHome();
            this.Hide();
            formHome.ShowDialog();
            this.Close();
        }
    }
}
