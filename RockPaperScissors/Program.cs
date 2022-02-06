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
      Console.WriteLine("Enter either 'rock', 'paper' or 'scissors' as the move for Player 2:");
      string P2 = Console.ReadLine();
      Round newRound = new Round(P1,P2);
      Console.WriteLine(newRound.DeclareWinner());

    }
  }
}