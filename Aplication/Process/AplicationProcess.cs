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
        GameDto gameDto;
        GenderDto genderDto;

        public void SaveGame(GameDto gameDto)
        {
            game = new Game();
            game = map.Game_Map(gameDto);
            repositoryGames.add(game);
        }

        public List<string> Get_ListGender()
        {
             return repositoryGender.Get_List();
        }

        public void ConstructDto(string name, string gender)
        {
            gameDto = new GameDto();
            genderDto = new GenderDto();
            gameDto.Name = name;
            genderDto.Type = gender;
        }
    }
}
