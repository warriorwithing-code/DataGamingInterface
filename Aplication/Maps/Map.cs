using Aplication.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Maps
{
    public class Map
    {
        public Game Game_Map(GameDto gameDto)
        {
            Game gameEntity = new Game();
            gameEntity.setName(gameDto.Name);
            gameEntity.setInfo((gameDto.Info == null) ? "":gameDto.Info);
            return gameEntity;
        }

        public void Gender_Map(GenderDto genderDto)
        {

        }
    }
}
