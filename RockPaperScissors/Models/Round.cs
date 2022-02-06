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
      // int "rock" = 1;
      // int "paper" = 2;
      // int "scissors" = 3;
      
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
                winner = "Player 2 Wins!";
                break;
              }
            case "scissors":
              {
                winner = "Player 1 Wins!";
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
                winner = "Player 1 Wins!";
                break;
              }
            case "paper": 
              {
                winner = "Draw. Try again!";
                break;
              }
            case "scissors":
              {
                winner = "Player 2 Wins!";
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
                winner = "Player 2 Wins!";
                break;
              }
            case "paper": 
              {
                winner = "Player 1 Wins!";
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

      return winner;
    }

    public Round(string player1Move, string player2Move)
    {
      this.Player1Move = player1Move;
      this.Player2Move = player2Move;
    }
  }
}