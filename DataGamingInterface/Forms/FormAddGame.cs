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
    public partial class FormAddGame : Form
    {
        AplicationProcess processInterface = new AplicationProcess();
        GameDto gameDto;
        List<GenderDto> listGender;
        List<GameDto> listGamesDto = new List<GameDto>();
        GenderDto genderDto;
        public FormAddGame()
        {
            InitializeComponent();
            GetListGender();
            GetListGames();
        }

        public void TransferDates(List<GameDto> listGamesDtoTrnasfered)
        {
            foreach (var x in listGamesDtoTrnasfered)
            {
                listGamesDto.Add(x);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectGender.Text == "Seleccione genero")
            {
                LabelErrorGender.Show();
            }
            else
            {
                CreateGameDto();
                if (listGamesDto.Any())
                    gameDto.Id = listGamesDto.Last().Id + 1;
                processInterface.SaveGame(gameDto);
                listGamesDto.Add(gameDto);
                labelCorrectSave.Show();
            }
        }

        private void ButtonAddGender_Click(object sender, EventArgs e)
        {
            if (textBoxAddGender.Text == "" || textBoxAddGender.Text== "Introduzca Genero" || textBoxAddGender.Text == null)
            {
                labelErrorAddGender.Show();
            }
            else
            {
                genderDto = new GenderDto();
                if (listGender.Any())
                    genderDto.Id = listGender.Last().Id + 1;

                genderDto.Type = textBoxAddGender.Text;
                processInterface.SaveGender(genderDto);
                labelCorrectSave.Show();
            }
        }

        public void TextBoxAddGender_Click(object sender, EventArgs e)
        {
            if (textBoxAddGender.Text == "Introduzca Genero")
                textBoxAddGender.Clear();
        }

        private void TextBoxAddGame_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxAddGame_Click(object sender, EventArgs e)
        {
            if(textBoxAddGame.Text == "Introduzca nombre")
                textBoxAddGame.Clear();
        }

        private void ComboBoxSelectGender_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private int SelectGender()
        {
            foreach (var x in listGender)
            {
                if (x.Type == comboBoxSelectGender.SelectedItem.ToString())
                    return x.Id;
            };
            return 1;
        }

        private void CreateGameDto()
        {
            gameDto = new GameDto();
            gameDto.Name = textBoxAddGame.Text;
            gameDto.GenderId = SelectGender();
        }

        private void ButtonDeleteGame_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteGame.Text == "Seleccione juego")
            {
                LabelErrorGender.Text = "Seleccione un Juego";
                LabelErrorGender.Show();
            }
            else if (comboBoxDeleteGame.Items.Count==0)
            {
                LabelErrorGender.Text = "No existen Juegos";
                LabelErrorGender.Show();
            }
            else
            {
                foreach (var x in processInterface.Get_ListGames())
                {
                    if (x.Name == comboBoxDeleteGame.Text)
                    {
                        processInterface.DeleteGame(x);
                        listGamesDto.Remove(x);
                        comboBoxDeleteGame.Items.Remove(x.Name);
                    }
                }
            }
        }

        private void ButtonDeleteGender_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteGender.Text == "Seleccione Genero")
            {
                LabelErrorGender.Text = "Seleccione un Genero";
                LabelErrorGender.Show();
            }
            else if (comboBoxDeleteGender.Items.Count == 0)
            {
                LabelErrorGender.Text = "No existen Generos";
                LabelErrorGender.Show();
            }
            else
            {
                foreach (var x in processInterface.Get_ListGender())
                {
                    if (x.Type == comboBoxDeleteGender.Text)
                    {
                        processInterface.DeleteGender(x);
                        listGender.Remove(x);
                        comboBoxDeleteGender.Items.Remove(x.Type);
                    }
                }
                
            }
        }

        public void GetListGender()
        {
            listGender = new List<GenderDto>();
            foreach (var x in processInterface.Get_ListGender())
            {
                listGender.Add(x);
                this.comboBoxSelectGender.Items.Add(x.Type);
                this.comboBoxDeleteGender.Items.Add(x.Type);
            }
        }

        public void GetListGames()
        {
            listGamesDto = new List<GameDto>();
            foreach (var x in processInterface.Get_ListGames())
            {
                listGamesDto.Add(x);
                this.comboBoxDeleteGame.Items.Add(x.Name);
            }
        }
    }
}
