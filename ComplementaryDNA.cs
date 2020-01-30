// Complementary DNA

/*
eoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.

If you want to know more http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here http://rosalind.info/problems/list-view/ (source)

MakeComplement("ATTGC") => "TAACG"

MakeComplement("GTAT") => "CATA"

*/

using System;
using System.Text;
using System.Linq;

public class DnaStrand
{
  public static string MakeComplement(string dna)
  {
    StringBuilder dnaComplementary = new StringBuilder("");
    var symbols = dna.ToCharArray();

    for (int i = 0; i < dna.Length; i++)
    {
      if (symbols[i].Equals('T'))
      { dnaComplementary.Append("A"); }
      if (symbols[i].Equals('A'))
      { dnaComplementary.Append("T"); }
      if (symbols[i].Equals('C'))
      { dnaComplementary.Append("G"); }
      if (symbols[i].Equals('G'))
      { dnaComplementary.Append("C"); }
    }
    return dnaComplementary.ToString();
  }
}