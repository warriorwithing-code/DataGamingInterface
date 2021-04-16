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
        GenderDto genderDto;
        GameDto gameDto;
        List<GenderDto> listGender;
        public FormAddGame()
        {
            InitializeComponent();
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
                processInterface.SaveGame(gameDto);
            }
        }

        private void ButtonAddGender_Click(object sender, EventArgs e)
        {

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
            //listGender = new List<GenderDto>();
            //foreach (var x in processInterface.Get_ListGender())
            //{
            //    listGender.Add(x);
            //    this.comboBoxSelectGender.Items.Add(x.Type);
            //}
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
    }
}
