namespace path_sum
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }
            int newTargetSum = targetSum - root.val;
            return HasPathSum(root.left, newTargetSum) || HasPathSum(root.right, newTargetSum);
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(1);

            int targetSum = 22;
            bool result = solution.HasPathSum(root, targetSum);
            Console.WriteLine($"Существует путь с суммой {targetSum}: {result}"); 
        }
    }
}
