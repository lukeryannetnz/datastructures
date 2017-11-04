namespace app
{
    /// <summary>
    /// Mirrors or reverses a binary tree.
    /// </summary>
    public class TreeMirror
    {
        private int Depth;

        public TreeMirror(int depth)
        {
            this.Depth = depth;
        }

        public TreeItem MirrorTree(TreeItem item)
        {
            return MirrorTree(item, Depth);
        }

        private TreeItem MirrorTree(TreeItem item, int depth)
        {
            if(depth == 0)
            {
                return item;
            }

            depth--;

            var temp = item.LeftChild;
            item.LeftChild = item.RightChild;
            item.RightChild = temp;

            MirrorTree(item.LeftChild, depth);
            MirrorTree(item.RightChild, depth);

            return item;
        }
    }
}