namespace MatrixShortestPath
{
    public class Cell
    {
        public Cell(int row, int column, int distance)
        {
            Row = row;
            Column = column;
            DistanceFromStart = distance;
        }

        public int Row { get; set; }

        public int Column { get; set; }

        public int DistanceFromStart { get; set; }
    }
}