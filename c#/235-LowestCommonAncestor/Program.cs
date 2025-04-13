namespace _235_LowestCommonAncestor
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static TreeNode LowestCommonAncestor(
            TreeNode root, TreeNode p, TreeNode q)
        {
            while (root != null)
            {
                if (root.val > p.val && root.val > q.val)
                {
                    root = root.left;
                }
                else if (root.val < p.val && root.val < q.val)
                {
                    root = root.right;
                }
                else
                {
                    return root;
                }
            }
            return root;
        }
    }
}
