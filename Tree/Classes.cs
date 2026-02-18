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

        public class InorderClass {
            List<int> result = new();
            // Recursive

            // public void Inorder(TreeNode root)
            // {
            //     if(root == null)
            //         return;
            //     Inorder(root.left);
            //     result.Add(root.val);
            //     Inorder(root.right);
            // }

            // Iterative
            Stack<TreeNode> stack = new();
            public void Inorder(TreeNode root)
            {
                TreeNode cur = root;
                // Go to the farthest left
                while(stack.Count > 0 || cur != null)
                {
                    while(cur != null)
                    {
                        stack.Push(cur);
                        cur = cur.left;
                    }
                    // reset current back to last root and process it
                    cur = stack.Pop();
                    result.Add(cur.val);
                    // move to the right node
                    cur = cur.right;
                }
            }
            
            public List<int> InorderTraversal(TreeNode root) {
                Inorder(root);
                return result;
            }
        }

        // Leetcode : 144 - Binary Tree Preorder Traversal
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class PreOrderClass {
            public List<int> result = new();
            public void PreOrder(TreeNode root)
            {
                if(root == null)
                    return;
                // Add root element to result
                result.Add(root.val);
                // Solve for left subtree
                PreOrder(root.left);
                // Solve for right subtree
                PreOrder(root.right);
            }

            public IList<int> PreorderTraversal(TreeNode root) {
                
                // Iterative
                
                // Stack<TreeNode> stack = new();
                // List<int> result = new();
                // stack.Push(root);
                // TreeNode curr = new();
                // while(stack.Count > 0)
                // {
                //     curr = stack.Pop();
                //     if(curr != null)
                //     {
                //         result.Add(curr.val);
                //         // Push right child to stack so that left child is processed
                //         // before right child (LIFO)
                //         if(curr.right != null)
                //             stack.Push(curr.right);
                //         if(curr.left != null)
                //             stack.Push(curr.left);
                //     }
                // }
                // return result;

                // recursive

                PreOrder(root);
                return result;
            }
        }
    }
}
