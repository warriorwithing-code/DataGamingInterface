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
            gameEntity.setId(gameDto.Id);
            gameEntity.setName(gameDto.Name);
            gameEntity.setInfo((gameDto.Info == null) ? "":gameDto.Info);
            gameEntity.setGenderId(gameDto.GenderId);
            return gameEntity;
        }

        public Gender Gender_MapDtoIntoEntitie(GenderDto genderDto)
        {
            Gender genderEntity = new Gender();
            genderEntity.Type = genderDto.Type;
            genderEntity.Id = genderDto.Id;
            return genderEntity;
        }

        public GenderDto Gender_MapEntitieToDto(Gender gender)
        {
            GenderDto genderDto = new GenderDto();
            AssignAttributes(gender, genderDto);
            return genderDto;
        }

        public Game Game_MapDtoIntoEntitie(GameDto gameDto)
        {
            Game gameEntity = new Game();
            MapGameDto(gameDto, gameEntity);
            return gameEntity;
        }

        private static void MapGameDto(GameDto gameDto, Game gameEntity)
        {
            gameEntity.Id = gameDto.Id;
            gameEntity.Name = gameDto.Name;
            gameEntity.GenderId = gameDto.GenderId;
            gameEntity.Info = gameDto.Info;
        }

        private static void MapGameEntitie(GameDto gameDto, Game gameEntity)
        {
            gameDto.Id = gameEntity.Id;
            gameDto.Name = gameEntity.Name;
            gameDto.GenderId = gameEntity.GenderId;
            gameDto.Info = gameEntity.Info;
        }

        public GameDto Game_MapEntitieToDto(Game gameEntity)
        {
            GameDto gameDto = new GameDto();
            MapGameEntitie(gameDto, gameEntity);
            return gameDto;
        }

        private static void AssignAttributes(Gender gender, GenderDto genderDto)
        {
            genderDto.Id = gender.Id;
            genderDto.Type = gender.Type;
        }
    }
}
