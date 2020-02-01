// solving Mumbling in C#

/*
Examples:

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
*/


// My solution

using System;
using System.Text;


public class Accumul
{
  public static String Accum(string s)
  {
    StringBuilder result = new StringBuilder("");
    for (int i = 0; i < s.Length; i++)
    {
      result.Append(char.ToUpper(s[i]));
      for (int j = 0; j < i; j++)
      {
        result.Append(char.ToLower(s[i]));
      }
      result.Append("-");

    }

    return result.ToString().Remove(result.Length - 1);
  }
}



// Best solution: 
/*
using System;
using System.Text;

public class Accumul 
{
  public static string Accum(string s) 
  {
    if(s.Length < 1) return "";

    StringBuilder sb = new StringBuilder();
    int count = 1;
    foreach(char c in s.ToLower())
      sb.Append(Char.ToUpper(c), 1)
        .Append(c, count++ - 1)
        .Append('-');
     
    return sb.ToString().TrimEnd('-');
  }
}
*/
