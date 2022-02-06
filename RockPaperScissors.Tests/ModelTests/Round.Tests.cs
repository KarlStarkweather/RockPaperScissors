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
      int P1 = 1;
      int P2 = 2;
      
      //Act
      Round newRound = new Round(P1,P2);
      
      //Assert
      Assert.AreEqual(typeof(Round), newRound.GetType());


    }
  }
}