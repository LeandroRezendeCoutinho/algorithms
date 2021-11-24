using System;

class Naive
{

    public static void search(String txt, String pat)
    {
        int M = pat.Length;
        int N = txt.Length;

        for (int i = 0; i <= N - M; i++)
        {
            int j;

            for (j = 0; j < M; j++)
                if (txt[i + j] != pat[j])
                    break;

            if (j == M)
                Console.WriteLine("Pattern found at index " + i);
        }
    }
}