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
            buttonEnter.BackgroundImage = Properties.Resources.button;
            formHome = new FormHome();
            buttonEnter.BackgroundImage = Properties.Resources.button2;
            this.Hide();
            formHome.ShowDialog();
            this.Close();
        }
    }
}
