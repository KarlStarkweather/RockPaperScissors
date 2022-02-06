using System;

namespace RockPaperScissors.Models
{
  public class Round
  {
    public int Player1Move {get; set;}
    public int Player2Move {get; set;}

    public string DeclareWinner()
    {
      string winner = "";
      int rock = 1;
      int paper = 2;
      int scissors = 3;
      
      if(this.Player1Move == rock && this.Player2Move == paper)
      {
        winner = "Player 2 Wins!";
      }

      return winner;
    }

    public Round(int player1Move, int player2Move)
    {
      this.Player1Move = player1Move;
      this.Player2Move = player2Move;
    }
  }
}