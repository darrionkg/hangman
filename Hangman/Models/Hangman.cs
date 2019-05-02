using System.Collections.Generic;

namespace Hangman.Models
{
  public class HangmanGame
  {
    private string[] _userWords;
    private string _word;
    private char[] _letters;
    private bool _isRightWord;

    public HangmanGame(string userWord)
    {
      //_userWords.add(userWord);
      _word = randomWord();
      _letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
      _isRightWord = false;
    }


  }
}
