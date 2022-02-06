using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Enter either 'rock', 'paper' or 'scissors' as the move for Player 1:");
      string P1 = Console.ReadLine();
      P1 = P1.ToLower();
      if(P1 == "rock" || P1 == "paper" || P1 == "scissors")
      {
        Console.WriteLine("Enter either 'rock', 'paper' or 'scissors' as the move for Player 2:");
        string P2 = Console.ReadLine();
        if(P2 == "rock" || P2 == "paper" || P2 == "scissors")
        {
          Round newRound = new Round(P1,P2);
          Console.WriteLine(newRound.DeclareWinner());
        }
        else
        {
          Console.WriteLine("invalid entry, please try again");
        }
      }
      else
      {
        Console.WriteLine("invalid entry, please try again");
      }
    }
  }
}