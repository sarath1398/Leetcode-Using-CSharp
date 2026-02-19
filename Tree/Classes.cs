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

        // Leetcode : 145 - Binary Tree Postorder Traversal
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class PostOrderClass {
            List<int> result = new();

            public void PostOrder(TreeNode root)
            {   
                if(root == null)
                {
                    return;
                }
                PostOrder(root.left);
                PostOrder(root.right);
                result.Add(root.val);
            }

            public IList<int> PostorderTraversal(TreeNode root) {
                
                // Initial Iterative approach - UnOptimized

                // Dictionary<TreeNode,int> map = new();
                // Stack<TreeNode> stack = new();
                // List<int> result = new();
                // TreeNode cur = root;
                // if(root == null) 
                //     return result;
                // stack.Push(cur);
                // while(stack.Count > 0)
                // {
                //     cur = stack.Peek();
                //     // handle leaf nodes
                //     if(cur != null && cur.right == null && cur.left == null)
                //     {
                //         cur = stack.Pop();
                //         result.Add(cur.val);
                //         map.Add(cur,1);
                //     }
                //     // handle parent nodes with visited children  
                //     else if(cur != null && (cur.left != null && map.ContainsKey(cur.left)) ||
                //      (cur.right != null && map.ContainsKey(cur.right)))
                //     {
                //         cur = stack.Pop();
                //         result.Add(cur.val);
                //         map.Add(cur,1);
                //     }
                //     // add right and left nodes to the stack
                //     else
                //     {
                //         if(cur.right != null)
                //         {
                //             stack.Push(cur.right);
                //         }
                //         if(cur.left != null)
                //         {
                //             stack.Push(cur.left);
                //         }
                //     }
                // }
                // return result;

                // Recursive Approach
                PostOrder(root);
                return result;
            }
        }

        // Leetcode : 226 - Invert Binary Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class InvertTreeClass
        {
            public void InOrder(TreeNode root)
            {
                if(root == null)
                    return;
                // swap left and right elements
                (root.left,root.right) = (root.right,root.left);
                // swap for left subtree
                InOrder(root.left);
                // swap for right subtree
                InOrder(root.right);

            }

            public TreeNode InvertTree(TreeNode root) {
                // // iterative -> BFS

                // if(root == null)
                //     return root;

                // Queue<TreeNode> queue = new();
                // TreeNode cur = root;
                // // Add root to the queue
                // queue.Enqueue(cur);
                // while(queue.Count > 0)
                // {
                //     cur = queue.Dequeue();
                //     (cur.left,cur.right) = (cur.right,cur.left);
                //     // Add the left and right elements of the current parent
                //     // and continue the same process
                //     if(cur.left != null) 
                //         queue.Enqueue(cur.left);
                //     if(cur.right != null)
                //         queue.Enqueue(cur.right);
                // }
                // return root;

                // Recursive -> DFS (InOrder traversal)
                InOrder(root);
                return root;
            }
        }

        // Leetcode : 104 - Maximum Depth of Binary Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class MaxDepthOfBinaryTree {
            public int MaxDepth(TreeNode root) {
                if(root == null)
                {
                    return 0;
                }
                return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
            }
        }
    }
}
