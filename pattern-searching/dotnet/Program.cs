using System;

class Program
{
  public static void Main()
  {
    String txt = "AABAACAADAABAAABAA";
    String pat = "AABA";
    Naive.search(txt, pat);
  }
}
