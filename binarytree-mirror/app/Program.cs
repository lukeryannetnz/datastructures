using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int treeDepth = 4;
            var visualiser = new TreeVisualiser(treeDepth);
            var builder = new TreeBuilder(treeDepth);
            var mirror = new TreeMirror(treeDepth);
            
            Console.WriteLine("Buidling a tree!");
            var tree = builder.BuildTree();
            visualiser.VisualiseTree(tree);     

            Console.WriteLine("Now mirroring it!");
            tree = mirror.MirrorTree(tree);
            visualiser.VisualiseTree(tree);          
        }
    }
}
