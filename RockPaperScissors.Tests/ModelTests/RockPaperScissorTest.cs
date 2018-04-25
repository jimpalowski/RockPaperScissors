using Microsoft.VisualStudio.TestTools.UnitTesting;
//using xunit;
using RockPaperScissor.Models;
using System.Collections.Generic;


namespace RockPaperScissor.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void RockPaperScissor_userInputRockScissors_ReturnPlayer1()
    {
      //Arrange
      string expectedResult = "Player 1";

      //Act
      Game game = new Game("rock", "scissors");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void RockPaperScissor_userInputRockPaper_returnPlayer2()
    {
      //Arrange
      string expectedResult = "Player 2";

      //Act
      Game game = new Game("rock","paper");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void RockPaperScissor_userInputScissorsPaper_returnPlayer1()
    {
      //Arrange
      string expectedResult = "Player 1";

      //Act
      Game game = new Game("scissors","paper");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void RockPaperScissor_userInputScissorsScissors_returnDraw()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("scissors","scissors");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void RockPaperScissor_userInputPaperPaper_returnDraw()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("paper", "paper");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void RockPaperScissor_userInputRockRock_returnDraw()
    {
      //Arrange
      string expectedResult = "Draw";

      //Act
      Game game = new Game("rock", "rock");
      string result = game.Play();

      //Assert
      Assert.AreEqual(expectedResult, result);
    }
  }
}
