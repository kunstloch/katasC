// My First C# Kata - after learning C# for one day :-)

using System;
using System.Text;
using System.Linq;


/*
The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
Notes

Assertion messages may be unclear about what they display in some languages. If you read "...It Should encode XXX", the "XXX" is the expected result, not the input!
*/



public class Kata
{
  public static string DuplicateEncode(string word)
  {
    StringBuilder newWord = new StringBuilder("");
    var letters = word.ToLower().ToCharArray();
    int duplicate = 0;

    for (int i = 0; i < word.Length; i++)
    {
      for (int j = 0; j < word.Length; j++)
      {
        if (letters[i] == letters[j] && i != j)
        {
          duplicate = duplicate + 1;

        }
        if (letters[i] != letters[j] && i != j)
        {
          duplicate = duplicate + 0;
        }
      }
      if (duplicate == 0)
      {
        newWord.Append("(");
        duplicate = 0;
      }
      if (duplicate > 0)
      {

        newWord.Append(")");
        duplicate = 0;
      }
    }
    return newWord.ToString();

  }
}