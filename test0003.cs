/*
you are required to, given a string, replace every letter with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.
"a" = 1, "b" = 2, etc.
Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
*/

using System;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    var inputString = text.ToLower();
    var outValue = "";
    foreach(char symbol in inputString)
    {
        if(!char.IsLetter(symbol)) continue;
        int code = symbol - 'a' + 1;
        outValue += code + " ";
    }
    return outValue.Trim();
  }
}

/* best practice

using System.Linq;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
     return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
  }
}*/
