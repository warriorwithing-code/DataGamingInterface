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
    public partial class FormGameEdit : Form
    {
        FormAddGame formAddGame;
        FormHome formHome;

        public FormGameEdit()
        {
            InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEditGameAndSave_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddNewGame_Click(object sender, EventArgs e)
        {
            formAddGame = new FormAddGame();
            formAddGame.ShowDialog();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            formHome = new FormHome();
            this.Hide();
            formHome.ShowDialog();
            this.Close();
        }
    }
}
