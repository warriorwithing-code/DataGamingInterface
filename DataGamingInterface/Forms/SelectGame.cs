using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGamingInterface.Forms
{
    public partial class SelectGame : Form
    {
        public SelectGame()
        {
            InitializeComponent();
        }

        private void CheckedListBoxSelectGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            //items = checkedListBoxSelectGame.Items;
            //checkedListBoxSelectGame.Items.Add("Warhammer2 Total war");
            //checkedListBoxSelectGame.CheckOnClick = true;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
