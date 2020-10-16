using System;

namespace MatrixApp
{
    class Matrix
    {
        static void Main(string[] args)
        {


            int[,] a = new int[4, 4] {
                                       {0, 1, 2, 3} ,   
                                       {4, 5, 6, 7} ,   
                                       {8, 9, 10, 11},
                                       {12,13,14,15}
                                    };

            /* output each array element's value */
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                        Console.Write(a[i, j] + "\t");
                    else
                        Console.Write(Convert.ToString(a[i, j], 2) + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}