namespace Tree
{
    internal class Classes
    {
        // Leetcode : 94 - Binary Tree Inorder Traversal
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            public int val = val;
            public TreeNode left = left;
            public TreeNode right = right;
        }

        List<int> result = [];
        public void Inorder(TreeNode root)
        {
            if (root == null)
                return;
            Inorder(root.left);
            result.Add(root.val);
            Inorder(root.right);
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            Inorder(root);
            return result;
        }
    }
}
