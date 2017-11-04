namespace app
{
    public class TreeItem
    {
        int Depth;
        char Side;
        public TreeItem(TreeItem leftChild, TreeItem rightChild, int depth, char side)
        {
            LeftChild = leftChild;
            RightChild = rightChild;
            Depth = depth;
            Side = side;
        }

        public TreeItem LeftChild {get;set;}

        public TreeItem RightChild {get;set;}

        public override string ToString()
        {
            return Side.ToString();
        }
    }
}