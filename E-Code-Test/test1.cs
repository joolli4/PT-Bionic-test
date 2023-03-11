using System;

public class SoalPertama
{
    public static void Main(string[] args)
    {
		Console.WriteLine("input nilai: ");
		string input = Console.ReadLine();
        int n = 0; //input nilai pada konsol (silahkan input 4 dan 5)
		Int32.TryParse(input, out n);

        for (int i=1; i<=n ; i++)
        {
            for (int j=1; j<=n+3; j++)
            {
                Console.Write(j);
                if (i == j)
                {
                    Console.Write("**");
                    j+=2;
                }
            }
            Console.WriteLine( );
        }
    }
}