using System; 

namespace app
{
    /// <summary>
    /// Crude console visualiser for binary trees.
    /// </summary>
    public class TreeVisualiser
    {
        private int Depth;

        private string[] Buffer;

        public TreeVisualiser(int depth)
        {
            Depth = depth;
        }

        private void InitialiseBuffer()
        {
            Buffer = new string[Depth];
        }

        public void VisualiseTree(TreeItem root)
        {
            InitialiseBuffer();

            Buffer[Depth - 1] = root.ToString();
            VisualiseTreeNode(root, Depth - 1);

            for(int i=Depth - 1; i >= 0; i--)
            {
                Console.WriteLine(Buffer[i]);
            }
        }

        private void VisualiseTreeNode(TreeItem node, int depth)
        {
            depth--;
            if(node.LeftChild != null)
            {
                Buffer[depth] += node.LeftChild.ToString();
                VisualiseTreeNode(node.LeftChild, depth);
            }
            if(node.RightChild != null)
            {
                Buffer[depth] += node.RightChild.ToString();
                VisualiseTreeNode(node.RightChild, depth);
            }

            return;
        }
    }
}