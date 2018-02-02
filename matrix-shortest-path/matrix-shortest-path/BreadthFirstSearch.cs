namespace MatrixShortestPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// https://en.wikipedia.org/wiki/Breadth-first_search
    /// </summary>
    public class BreadthFirstSearch
    {
        public int Search(char[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);

            var visited = new bool[n, m];
            var start = new Cell(0, 0, 0);

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    // x is not valid
                    if (input[i, j] == 'x')
                    {
                        visited[i, j] = true;
                    }

                    // s is the starting point
                    if (input[i, j] == 's')
                    {
                        start.Row = i;
                        start.Column = j;
                    }
                }
            }

            var q = new Queue<Cell>();
            q.Enqueue(start);

            visited[start.Row, start.Column] = true;

            while (q.Any())
            {
                Cell item = q.Dequeue();

                if (input[item.Row, item.Column] == 'd')
                {
                    return item.DistanceFromStart;
                }

                // move up
                if (item.Row - 1 >= 0 && !visited[item.Row - 1, item.Column])
                {
                    q.Enqueue(new Cell(item.Row - 1, item.Column, item.DistanceFromStart + 1));
                    visited[item.Row - 1, item.Column] = true;
                }

                // move down
                if (item.Row + 1 < n && !visited[item.Row + 1, item.Column])
                {
                    q.Enqueue(new Cell(item.Row + 1, item.Column, item.DistanceFromStart + 1));
                    visited[item.Row + 1, item.Column] = true;
                }

                // move left
                if (item.Column - 1 >= 0 && !visited[item.Row, item.Column - 1])
                {
                    q.Enqueue(new Cell(item.Row, item.Column - 1, item.DistanceFromStart + 1));
                    visited[item.Row, item.Column - 1] = true;
                }

                // move right
                if (item.Column + 1 < m && !visited[item.Row, item.Column + 1])
                {
                    q.Enqueue(new Cell(item.Row, item.Column + 1, item.DistanceFromStart));
                    visited[item.Row, item.Column] = true;
                }
            }

            throw new Exception("Path to destination not found!");
        }
    }
}
