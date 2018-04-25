using System.Collections.Generic;
using System;

namespace RockPaperScissor.Models
{
  public class Game
  {
    private string _player1;
    private string _player2;

    public Game(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string Play()
    {
      string result = "";
      if ((_player1=="rock" && _player2=="scissors") || (_player1=="scissors"&&_player2=="paper") || (_player1=="paper"&&_player2=="rock"))
      {
        result = "Player 1";
      }
      else if ((_player2=="rock" && _player1=="scissors") || (_player2=="scissors"&&_player1=="paper") || (_player2=="paper"&&_player1=="rock"))
      {
        result = "Player 2";
      }
      else if ((_player1 == _player2))
      {
        result = "Draw";
      }
      else
      {
        result = "Invalid game!";
      }
      return result;
    }
  }
}
