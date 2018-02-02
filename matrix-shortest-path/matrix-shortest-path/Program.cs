using System;

namespace MatrixShortestPath
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a matrix of N * M order, find the shortest distance from a starting cell to a destination cell, traversing through valid cells only.");
            Console.WriteLine("You may move only up, down, left and right.");
            Console.WriteLine("If found, output the number of cells traversed.");
            Console.WriteLine("'s' represents the starting position");
            Console.WriteLine("'d' represents the destination");
            Console.WriteLine("'*' represents a valid cell you can traverse");
            Console.WriteLine("'x' represents an invalid cell you can not traverse");

            char[,] input = {
                {'*', '*', '*', '*', 's'},
                {'*', '*', 'x', 'x', '*'},
                {'*', '*', 'x', 'x', '*'},
                {'*', 'd', '*', 'x', '*'},
                {'*', '*', '*', '*', '*'}
            };

            PrintMatrix(input);

            var algorithm = new BreadthFirstSearch();
            var distance = algorithm.Search(input);

            Console.ReadKey();

            Console.WriteLine(distance);

            Console.ReadKey();
        }

        private static void PrintMatrix(char[,] input)
        {
            Console.WriteLine("-----------");

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write('|');
                    Console.Write(input[i,j]);
                }

                Console.Write('|');
                Console.WriteLine();
            }

            Console.WriteLine("-----------");
        }
    }
}
