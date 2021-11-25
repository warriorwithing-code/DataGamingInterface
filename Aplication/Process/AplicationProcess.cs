using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.Dto;
using Aplication.Maps;
using BBDD.Repositories;
using Domain;
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
        List<GenderDto> listGenderDto;
        SelectGameLogic selectGameLogic= new SelectGameLogic();

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

        public List<GameDto> Get_ListGames()
        {
            List<GameDto> ListGamesDto = new List<GameDto>();
            foreach (var x in repositoryGames.GetGamesList())
            {
                ListGamesDto.Add(map.Game_MapEntitieToDto(x));
            }
            return ListGamesDto;
        }

        public void DeleteGame(GameDto gameDto)
        {
            game = new Game();
            game = map.Game_Map(gameDto);
            repositoryGames.delete(game);
        }

        public void DeleteGender(GenderDto genderDto)
        {
            gender = new Gender();
            gender = map.Gender_MapDtoIntoEntitie(genderDto);
            repositoryGender.delete(gender);
        }

        public void ModifiedGame(GameDto gameDto)
        {
            game = new Game();
            game = map.Game_MapDtoIntoEntitie(gameDto);
            repositoryGames.EditGame(game);
        }

        public string Roll_Dice(List<string> listGamesPrepared)
        {
            return selectGameLogic.Roll_Dice(listGamesPrepared);
        }
    }
}
