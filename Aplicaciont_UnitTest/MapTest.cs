using System;
using Aplication.Dto;
using Aplication.Maps;
using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aplicaciont_UnitTest
{
    [TestClass]
    public class MapTest
    {
        Map mapClassTest = new Map();
        GameDto gamedto;
        GenderDto genderDto;
        Gender gender;
        Game game;

        [TestMethod]
        public void TestMethodGameMap()
        {
            //Arrange
            gamedto = new GameDto();
            IntializeGameDto();

            //Act
            var resultado = mapClassTest.Game_Map(gamedto);

            //Assert
            Assert.AreEqual(gamedto.Id, resultado.Id);
            Assert.AreEqual(gamedto.Name, resultado.Name);
            Assert.AreEqual(gamedto.GenderId, resultado.GenderId);
            Assert.AreEqual(gamedto.Info, resultado.Info);
        }

        [TestMethod]
        public void TestGender_MapDtoIntoEntitie()
        {
            //Arrange
            genderDto = new GenderDto();
            IntializeGenderDto();

            //Act
            var resultado = mapClassTest.Gender_MapDtoIntoEntitie(genderDto);

            //Assert
            Assert.AreEqual(genderDto.Id,resultado.Id);
            Assert.AreEqual(genderDto.Type, genderDto.Type);
        }

        [TestMethod]
        public void TestGender_MapEntitieToDto()
        {
            //Arrange
            gender = new Gender();
            InitializeGender();

            //Act
            var resultado = mapClassTest.Gender_MapEntitieToDto(gender);

            //Assert
            Assert.AreEqual(gender.Id, resultado.Id);
            Assert.AreEqual(gender.Type, resultado.Type);
        }

        [TestMethod]
        public void TestGame_MapEntitieToDto()
        {
            //Arrange
            game = new Game();
            InitializeGame();

            //Act
            var resultado = mapClassTest.Game_MapEntitieToDto(game);

            //Assert
            Assert.AreEqual(game.Id, resultado.Id);
            Assert.AreEqual(game.Name, resultado.Name);
            Assert.AreEqual(game.GenderId, game.GenderId);
        }

        private void IntializeGameDto()
        {
            gamedto.Id = 1;
            gamedto.Name = "Cod";
            gamedto.GenderId = 1;
            gamedto.Info = "call of duty";
        }

        private void IntializeGenderDto()
        {
            genderDto.Id = 1;
            genderDto.Type = "Horror";
            genderDto.Subtype = "";
        }

        private void InitializeGender()
        {
            gender.Id = 1;
            gender.Type = "Horror";
            gender.Subtype = "";
        }

        private void InitializeGame()
        {
            game.Id = 1;
            game.Name = "Cod";
            game.GenderId= 1;
            game.Info = "call of duty";
        }
    }
}
