using Aplication.Dto;
using Aplication.Process;
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
        List<GameDto>listGamesDto;
        AplicationProcess processInterface = new AplicationProcess();
        GameDto gameDto;

        public FormGameEdit()
        {
            InitializeComponent();
            GetListGames();
        }

        private void CheckedListBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelGame.Text = checkedListBoxGames.SelectedItem.ToString();
            labelGame.Show();
            foreach (var x in listGamesDto)
            {
                if (checkedListBoxGames.SelectedItem.ToString() == x.Name)
                {
                    textBoxInfoGame.Text = x.Info;
                }
            }
        }

        private void ButtonEditGameAndSave_Click(object sender, EventArgs e)
        {
            gameDto = new GameDto();
            foreach (var x in listGamesDto)
            {
                if (checkedListBoxGames.SelectedItem.ToString() == x.Name)
                {
                    CreateGameDto(x);
                    try
                    {
                        processInterface.ModifiedGame(gameDto);
                        checkedListBoxGames.Items.Clear();
                        GetListGames();
                        labelGoodModified.Text = "Se a editado Correctamente";
                        labelGoodModified.Show();
                        break;
                    }
                    catch (Exception exception)
                    {
                        labelGoodModified.Text = "No se guardo correctamente";
                        labelGoodModified.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
        }
        private void CreateGameDto(GameDto gameModified)
        {
            gameDto.Id = gameModified.Id;
            gameDto.Name = gameModified.Name;
            gameDto.GenderId = gameModified.GenderId;
            gameDto.Info = textBoxInfoGame.Text;
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

        public void GetListGames()
        {
            listGamesDto = new List<GameDto>();
            foreach (var x in processInterface.Get_ListGames())
            {
                listGamesDto.Add(x);
                this.checkedListBoxGames.Items.Add(x.Name);
            }
        }

        private void FormGameEdit_Load(object sender, EventArgs e)
        {
            labelGoodModified.Visible = false;
        }
    }
}
