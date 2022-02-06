using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RoundTests
  {
    
    [TestMethod]
    public void RoundConstructor_CreateInstanceOfRound_Round()
    {
      //Arrange
      string P1 = "rock";
      string P2 = "paper";
      
      //Act
      Round newRound = new Round(P1,P2);
      
      //Assert
      Assert.AreEqual(typeof(Round), newRound.GetType());
    }

    [TestMethod]
    public void RoundConstructor_SetMoves_1()
    {
      //Arrange
      string P1 = "rock";
      string P2 = "paper";
      
      //Act
      Round newRound = new Round(P1,P2);
      
      //Assert
      Assert.AreEqual(newRound.Player1Move, "rock");
    }

    [TestMethod]
    public void DeclareWinner_CalculateWinner_Player2Wins()
    {
      //Arrange
      string P1 = "rock";
      string P2 = "paper";
      
      //Act
      Round newRound = new Round(P1,P2);
      
      //Assert
      Assert.AreEqual(newRound.DeclareWinner(), "Player 2 Wins!");
    }

    [TestMethod]
    public void DeclareWinner_CalculateWinner_Player1Wins()
    {
      //Arrange
      string P1 = "scissors";
      string P2 = "paper";
      
      //Act
      Round newRound = new Round(P1,P2);
      
      //Assert
      Assert.AreEqual(newRound.DeclareWinner(), "Player 1 Wins!");
    }    

  }
}