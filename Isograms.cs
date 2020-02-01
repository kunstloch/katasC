// Solving C# Kata

/*
An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "aba" == false
isIsogram "moOse" == false -- ignore letter case
*/


// My solution - seems much too complicted

using System;

public class Kata
{
  public static bool IsIsogram(string str)
  {
    // Code on you crazy diamond!
    str = str.ToLower();
    int isogram = 0;

    for (int i = 0; i < str.Length; i++)
    {
      for (int j = 0; j < str.Length && j != i; j++)
      {
        if (str[i] == str[j])
        {
          isogram = isogram + 1;

        }
        else
        {
          isogram = isogram + 0;
        }
      }
    }
    if (isogram == 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}


// Better Solutions

/*

using System;
using System.Linq;
public class Kata
{
  public static bool IsIsogram(string str) 
  {
    return str.ToLower().Distinct().Count()==str.Length;
  }
}

*/


// Or

/*
using System.Linq;
public class Kata
{
    public static bool IsIsogram(string str) => str.ToLower().Distinct().Count() == str.Length;
}
*/
