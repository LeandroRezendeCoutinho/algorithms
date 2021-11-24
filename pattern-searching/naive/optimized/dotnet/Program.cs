
public class Program
{
    static void Main()
    {
        string txt = "ABCEABCDABCEABCD";
        string pat = "ABCD";
        NaiveOptimized.search(pat, txt);
    }

}