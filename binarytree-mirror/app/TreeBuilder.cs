namespace app
{
    /// <summary>
    /// Creates a binary tree of the given size with arbitrary char data in it.
    /// </summary>
    public class TreeBuilder
    {
        private int Depth;
        public TreeBuilder(int depth)
        {
            this.Depth = depth;
        }

        public TreeItem BuildTree()
        {
            return BuildTree(new TreeItem(null, null, Depth, 'I'), Depth - 1);
        }

        private TreeItem BuildTree(TreeItem item, int depth)
        { 
            if(depth == 0)
            {
                return item;
            }

            depth--;

            item.LeftChild = new TreeItem(null,  null, depth, 'L');
            item.RightChild = new TreeItem(null,  null, depth, 'R');

            BuildTree(item.LeftChild, depth);
            BuildTree(item.RightChild, depth);

            return item;
        }
    }
}