namespace RockPaperScissors.Models
{
  public class Round
  {
    public int Player1Move {get; set;}
    public int Player2Move {get; set;}

    public string DeclareWinner()
    {
      string winner = "";
      return winner;
    }

    public Round(int player1Move, int player2Move)
    {
      this.Player1Move = player1Move;
      this.Player2Move = player2Move;
    }
  }
}