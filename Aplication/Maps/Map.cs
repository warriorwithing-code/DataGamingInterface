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
            gameEntity.setGenderId(gameDto.GenderId);
            return gameEntity;
        }

        public Gender Gender_MapDtoIntoEntitie(GenderDto genderDto)
        {
            Gender genderEntity = new Gender();
            genderEntity.Type = genderDto.Type;
            return genderEntity;
        }

        public GenderDto Gender_MapEntitieToDto(Gender gender)
        {
            GenderDto genderDto = new GenderDto();
            AssignAttributes(gender, genderDto);
            return genderDto;
        }

        private static void AssignAttributes(Gender gender, GenderDto genderDto)
        {
            genderDto.Id = gender.Id;
            genderDto.Type = gender.Type;
        }
    }
}
