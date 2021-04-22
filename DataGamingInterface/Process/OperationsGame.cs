using Aplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGamingInterface.Process
{
    public class OperationsGame
    {
        GameDto gameDto;
        GenderDto genderDto;
        public void Add_Game(string text)
        {
            gameDto = new GameDto();
            gameDto.Name = text;
        }

        public void Add_Gender(string text)
        {
            genderDto = new GenderDto();
            genderDto.Type = text;
        }

    }
}
