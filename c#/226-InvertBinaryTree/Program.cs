namespace _226_InvertBinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null,
            TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode testCase = new TreeNode(2);
            testCase.left = new TreeNode(1);
            testCase.left.left = new TreeNode(7);
            testCase.left.right = new TreeNode(8);
            testCase.right = new TreeNode(3);
            testCase.right.left = new TreeNode(9);
            testCase.right.right = new TreeNode(4);
            Console.WriteLine(InvertTree(testCase));
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}
