using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.Dto;
using Aplication.Maps;
using BBDD.Repositories;
using Domain.Entities;

namespace Aplication.Process
{
    public class AplicationProcess
    {
        Map map = new Map();
        GamesRepository repositoryGames = new GamesRepository();
        GenderRepository repositoryGender = new GenderRepository();
        Game game;
        Gender gender;
        GameDto gameDto;
        GenderDto genderDto;
        List<GenderDto> listGenderDto;

        public void SaveGame(GameDto gameDto)
        {
            game = new Game();
            game = map.Game_Map(gameDto);
            repositoryGames.add(game);
        }
        public void SaveGender(GenderDto genderDto)
        {
            gender = new Gender();
            gender = map.Gender_MapDtoIntoEntitie(genderDto);
            repositoryGender.add(gender);
        }

        public List<GenderDto> Get_ListGender()
        {
            listGenderDto = new List<GenderDto>();
            foreach (var x in repositoryGender.Get_List())
            {
               listGenderDto.Add(map.Gender_MapEntitieToDto(x));
            }
            return listGenderDto;
        }

        public void ConstructDto(string nameGame, string nameGender)
        {
            gameDto = new GameDto();
            genderDto = new GenderDto();
            gameDto.Name = nameGame;
            genderDto.Type = nameGender;
        }
    }
}
