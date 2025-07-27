using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = Int32.Parse(s[0]);
        int a = 0;
        for(int i = 0; i < n; i++)
        {
            a++;
            for(int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}