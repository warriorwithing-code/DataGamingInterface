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
    public partial class FormHome : Form
    {
        SelectGame formSelectGame;
        FormGameEdit formGameEdit= new FormGameEdit();
        public FormHome()
        {
            InitializeComponent();
        }

        private void ButtonSelectGame_Click(object sender, EventArgs e)
        {
            formSelectGame = new SelectGame();
            this.Hide();
            formSelectGame.ShowDialog();
            this.Close();
        }

        private void ButtonGameEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGameEdit.ShowDialog();
            this.Close();
        }
    }
}
