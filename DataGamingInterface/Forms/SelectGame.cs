using DataGamingInterface.Process;
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
        List<string> ListGamesSelects = new List<string>();
        CheckBoxListOperations heckBoxListOperations = new CheckBoxListOperations();
        public SelectGame()
        {
            InitializeComponent();
        }

        private void CheckedListBoxSelectGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBoxSelectGame.CheckOnClick = true;
            for (int i = 0; i < checkedListBoxSelectGame.Items.Count; i++)
            {
                if (checkedListBoxSelectGame.GetItemChecked(i))
                {
                   ListGamesSelects.Add(checkedListBoxSelectGame.Items[i].ToString());
                    checkedListBoxSelectGame.SetItemChecked(i, false);
                }
            };

            foreach(var game in ListGamesSelects) this.CheckedListBoxGamesPrepared.Items.Add(game);
            ListGamesSelects.Clear();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            this.checkedListBoxSelectGame.Items.Add(textBoxResult.Text);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            RellenarItems();
        }

        private void ButtonSearchGame_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBoxGamesPrepared_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CheckedListBoxGamesPrepared.CheckOnClick = true;
            for (int i = 0; i < CheckedListBoxGamesPrepared.Items.Count; i++)
            {
                if (CheckedListBoxGamesPrepared.GetItemChecked(i))
                {
                    CheckedListBoxGamesPrepared.Items.RemoveAt(i);
                }
            }
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            var gamePlay = heckBoxListOperations.Roll_Dice(CheckedListBoxGamesPrepared.Items);
            textBoxShowGame.Text = gamePlay;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            CheckedListBoxGamesPrepared.Items.Clear();
        }
    }
}
