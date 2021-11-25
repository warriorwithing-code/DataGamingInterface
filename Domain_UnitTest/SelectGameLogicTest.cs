using System;
using System.Collections.Generic;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain_UnitTest
{
    [TestClass]
    public class SelectGameLogicTest
    {
        SelectGameLogic selectGameLogicTest = new SelectGameLogic();
        List<string> listElements;

        [TestMethod]
        public void TestMethod_Roll_Dice()
        {

            //Arrange
            listElements = new List<string>();
            Fill_List();

            //Act
            var result = selectGameLogicTest.Roll_Dice(listElements);
            //Assert
            Assert.IsTrue(result == "Sea Of Thieves" || result == "Vermintide" || result == "The Forest");
        }

        [TestMethod]
        public void TestMethod_Roll_Dice_Fail()
        {

            //Arrange
            listElements = new List<string>();

            //Act
            var result = selectGameLogicTest.Roll_Dice(listElements);

            //Assert
            Assert.IsTrue(result == "Error");
        }

        private void Fill_List()
        {
            listElements.Add("Sea Of Thieves");
            listElements.Add("Vermintide");
            listElements.Add("The Forest");
        }
    }
}
