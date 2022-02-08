using System;

namespace RockPaperScissors.Models
{
  public class Round
  {
    public string Player1Move {get; set;}
    public string Player2Move {get; set;}

    public string DeclareWinner()
    {
      string winner = "";
      try
      {        
        switch(this.Player1Move)
        {
          case "rock":
          {
            switch(this.Player2Move)
            {
              case "rock":
                {
                  winner = "Draw. Try again!";
                  break;
                }
              case "paper": 
                {
                  winner = "Paper covers Rock, Player 2 Wins!";
                  break;
                }
              case "scissors":
                {
                  winner = "Rock crushes Scissors, Player 1 Wins!";
                  break;
                }
            }
            break;
          }
          case "paper":
          {
            switch(this.Player2Move)
            {
              case "rock":
                {
                  winner = "Paper covers Rock, Player 1 Wins!";
                  break;
                }
              case "paper": 
                {
                  winner = "Draw. Try again!";
                  break;
                }
              case "scissors":
                {
                  winner = "Scissors cut Paper, Player 2 Wins!";
                  break;
                }
            }
            break;
          }
          case "scissors":
          {
            switch(this.Player2Move)
            {
              case "rock":
                {
                  winner = "Rock crushes Scissors, Player 2 Wins!";
                  break;
                }
              case "paper": 
                {
                  winner = "Scissors cut Paper, Player 1 Wins!";
                  break;
                }
              case "scissors":
                {
                  winner = "Draw. Try again!";
                  break;
                }
            }
            break;
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
      return winner;
    }

    public Round(string player1Move, string player2Move)
    {
      try
      {
        this.Player1Move = player1Move;
        this.Player2Move = player2Move;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
    }
  }
}