
public class Program
{
    public static void Main()
    {
        char[] txt = "ABAAABCD".ToCharArray();
        char[] pat = "ABC".ToCharArray();
        BoyerMoore.search(txt, pat);
    }

}
