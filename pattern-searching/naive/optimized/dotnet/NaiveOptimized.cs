
/* C# program for A modified Naive Pattern Searching
algorithm that is optimized for the cases when all
characters of pattern are different */
class NaiveOptimized
{
    /* A modified Naive Pattern Searching
    algorithm that is optimized for the
    cases when all characters of pattern are different */
    public static void search(string pattern, string text)
    {
        int pattern_length = pattern.Length;
        int text_length = text.Length;
        int i = 0;

        while (i <= text_length - pattern_length)
        {
            int j;
            /* For current index i, check for pattern match */
            for (j = 0; j < pattern_length; j++)
                if (text[i + j] != pattern[j])
                    break;

            if (j == pattern_length) // if pat[0...M-1] = txt[i, i+1, ...i+M-1]
            {
                Console.WriteLine("Pattern found at index " + i);
                i = i + pattern_length;
            }
            else if (j == 0)
                i = i + 1;
            else
                i = i + j; // slide the pattern by j
        }
    }
}
