using System;
public class TrianglePattren
{
    public static void Main(String[] args)
    {
        int noOfRows;
        Console.WriteLine("Enter the number of rows :");
        noOfRows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= noOfRows; i++)
        {
            for (int j = 1; j <= 2 * noOfRows; j++)

            {

                if (j == noOfRows + 1)
                {
                    continue;
                }
                int k = (j < noOfRows + 1) ? j : 2 * noOfRows - j + 1;
                if (k >= noOfRows + 1 - i)
                {
                    int x = (int)Math.Pow(2, (i + k - noOfRows - 1));

                    Console.Write(x);
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
