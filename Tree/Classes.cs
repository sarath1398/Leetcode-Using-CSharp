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
            public int MaxDepth(TreeNode root)
            {
                // recursive
                // if(root == null)
                // {
                //     return 0;
                // }
                // return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));  

                // iterative BFS

                // Base case
                if(root == null)
                    return 0;

                // Initialize queue
                Queue<TreeNode> queue = new();
                queue.Enqueue(root);
                int depth = 0;
                // Process queue level by level
                while(queue.Count > 0)
                {
                    int size = queue.Count;
                    while(size > 0)
                    {
                        TreeNode cur = queue.Dequeue();
                        if(cur.left != null)
                        {
                            queue.Enqueue(cur.left);
                        }
                        if(cur.right != null)
                        {
                            queue.Enqueue(cur.right);
                        }
                        size--;
                    }
                    // Increment depth after processing each level
                    depth++;
                }
                return depth;
            }
        }

        // Leetcode : 543 - Diameter of Binary Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class DiameterOfBinaryTreeLC543 {

            public int result = 0;

            public int PostOrderTraversal(TreeNode root)
            {
                if(root == null)
                {
                    return 0;
                }

                int lHeight = PostOrderTraversal(root.left);
                int rHeight = PostOrderTraversal(root.right);                
                result = Math.Max(result,lHeight + rHeight);
                // parent's height
                return 1 + Math.Max(lHeight , rHeight);
            }

            public int DiameterOfBinaryTree(TreeNode root) {
                PostOrderTraversal(root);
                return result;
            }
        }

        // Leetcode : 110 - Balanced Binary Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class BalancedBinaryTreeLC110 {
            public bool flag = true;

            public int PostOrder(TreeNode root)
            {
                if(root == null)
                    return 0;

                int lHeight = PostOrder(root.left);
                int rHeight = PostOrder(root.right);
                // Check if the tree is height balanced
                int diff = Math.Abs(lHeight - rHeight);
                if(diff > 1)
                {
                    flag = false;
                    return -1;
                }
                // Return height of the tree
                return 1 + Math.Max(lHeight,rHeight);
            }

            public bool IsBalanced(TreeNode root) {
                // Call the recursive function
                PostOrder(root);
                return flag;
            }
        }

        // Leetcode : 100 - Same Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class SameTreeLC100 {
            public bool IsSameTree(TreeNode p, TreeNode q) {
                // Base case
                if(p == null && q == null)
                {
                    return true;
                }
                // Check if the tree is same
                if(p != null && q != null && p.val == q.val)
                {
                    // Check left and right subtrees
                    return IsSameTree(p.left,q.left) && IsSameTree(p.right,q.right);
                }
                // Return false if the tree is not same
                return false;
            }
        }

        // Leetcode : 572 - Subtree of Another Tree
        // Approach : BFS and DFS
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class SubtreeOfAnotherTreeLC572
        {
            public bool IsSubtree(TreeNode root, TreeNode subRoot)
            {
                Queue<TreeNode> queue = new();
                // Lent the Same tree logic from Leetcode - 100 solution
                SameTreeLC100 sameTree = new();
                if (root == null && subRoot == null)
                    return true;
                if (root == null)
                    return false;
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    root = queue.Dequeue();
                    // check if the current node can be the root of the subtree
                    if (root.val == subRoot.val && sameTree.IsSameTree(root, subRoot))
                    {
                        return true;
                    }
                    // Add left and right children to the queue
                    if (root.left != null)
                        queue.Enqueue(root.left);
                    if (root.right != null)
                        queue.Enqueue(root.right);
                }
                // Return false if the subtree is not found
                return false;
            }
        }

        // Leetcode : 235 - Lowest Common Ancestor of a Binary Search Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(h)
        // Type: Easy
        public class LowestCommonAncestorOfABinarySearchTreeLC235 {
            public TreeNode PreOrder(TreeNode root,TreeNode p, TreeNode q)
            {
                // Return root if it is either null or if it is our ancestor
                if(root == null || (root != null && root.val >= p.val && root.val <= q.val))
                    return root;
                // If both p and q are greater than root, then LCA is in the right subtree
                else if(root.val > q.val)
                {
                    return PreOrder(root.left,p,q);
                }
                // If both p and q are smaller than root, then LCA is in the left subtree
                else
                {
                    return PreOrder(root.right,p,q);
                }

            }
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
                // Swap p and q if p is greater than q
                if(p.val > q.val)
                {
                    (p,q) = (q,p);
                }
                // Call the recursive function
                return PreOrder(root,p,q);
            }
        }

        // Leetcode : 701 - Insert into a Binary Search Tree
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(h)
        // Type: Medium
        public class InsertIntoBinarySearchTreeLC701 {
            public TreeNode InsertIntoBST(TreeNode root, int val) {
                // Return new node if the root is null
                if(root == null)
                    return new TreeNode(val);
                else
                {
                    // If val is greater than root, then insert in the right subtree
                    if(val > root.val)
                    {
                        root.right = InsertIntoBST(root.right,val);
                    }
                    // If val is smaller than root, then insert in the left subtree
                    else
                    {
                        root.left = InsertIntoBST(root.left,val);
                    }
                }
                // Return root
                return root;
            }
        }

        // Leetcode : 450 - Delete Node in a BST
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(h)
        // Type: Medium
        public class DeleteNodeInABSTLC450 {
            public TreeNode DeleteNode(TreeNode root, int key) {
                // Return root if it is null
                if(root == null)
                {
                    return root;
                }
                // If key is greater than root, then delete in the right subtree
                if(key > root.val)
                {
                    root.right = DeleteNode(root.right,key);
                }
                // If key is smaller than root, then delete in the left subtree
                else if(key < root.val)
                {
                    root.left = DeleteNode(root.left,key);
                }
                else
                {
                    // in case of no children or 1 child
                    if(root.left == null)
                    {
                        return root.right;
                    }
                    if(root.right == null)
                    {
                        return root.left;
                    }
                    // in case of two children,
                    // find the smallest value in the rightmost tree
                    TreeNode ioSuccessor = root.right;
                    while(ioSuccessor.left != null)
                    {
                        ioSuccessor = ioSuccessor.left;
                    }
                    // Update the root with the InOrderSuccessor value
                    root.val = ioSuccessor.val;
                    // Delete the original InOrderSuccessor node from the tree
                    root.right = DeleteNode(root.right, root.val);
                }
                // Return root
                return root;
            }
        }

        // Leetcode : 1022 - Sum of Root To Leaf Binary Numbers
        // Approach : DFS
        // Time Complexity : O(n)
        // Space Complexity : O(h)
        // Type: Easy
        public class SumOfRootToLeafBinaryNumbersLC1022 {
            public int sum = 0;
            public void PreOrder(TreeNode root, string binary)
            {
                // In case of empty node, return
                if(root == null)
                {
                    return;
                }
                // Append the current node value to the binary string
                string currentPath = binary + root.val.ToString();
                // if we hit the child node then add it to our global sum
                // based on the currentPath
                if(root.left == null && root.right == null)
                {
                    sum += Convert.ToInt32(currentPath, 2);
                    return;
                }
                // Call the recursive function for left and right subtrees
                PreOrder(root.left,currentPath); 
                PreOrder(root.right,currentPath);
            }
            public int SumRootToLeaf(TreeNode root) {
                // Return 0 if the root is null
                if(root == null)
                {
                    return 0;
                }
                // Call the recursive function
                PreOrder(root,"");
                // Return the sum
                return sum;
            }
        }

        // Leetcode : 102 - Binary Tree Level Order Traversal
        // Approach : BFS
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class BinaryTreeLevelOrderTraversalLC102 {
            public IList<IList<int>> LevelOrder(TreeNode root) {
                // Queue for BFS
                Queue<TreeNode> queue = new();
                // Result list
                List<IList<int>> result = new();
                // Return empty list if the root is null
                if(root == null)
                {
                    return result;
                }
                // Enqueue the root
                queue.Enqueue(root);
                // While the queue is not empty
                while(queue.Count > 0)
                {
                    // Create a list for the current level
                    List<int> level = new();
                    // Get the size of the current level
                    int size = queue.Count;
                    // For each node in the current level
                    for(int i = 0; i < size; i++)
                    {
                        // Dequeue the node
                        TreeNode node = queue.Dequeue();
                        // Add the node value to the current level list
                        level.Add(node.val);
                        // Enqueue the left child if it exists
                        if(node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        // Enqueue the right child if it exists
                        if(node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                    // Add the current level list to the result
                    result.Add(level);
                }
                // Return the result
                return result;
            }
        }

        // Leetcode : 199 - Binary Tree Right Side View
        // Approach : BFS
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class BinaryTreeRightSideViewLC199 {
            public IList<int> RightSideView(TreeNode root) {
                // Queue for BFS
                Queue<TreeNode> queue = new();
                // Result list
                List<int> result = new();
                // Return empty list if the root is null
                if(root == null)
                {
                    return result;
                }
                // Enqueue the root
                queue.Enqueue(root);
                // While the queue is not empty
                while(queue.Count > 0)
                {
                    // Get the size of the current level
                    int size = queue.Count;
                    // For each node in the current level
                    for(int i = 0; i < size; i++)
                    {
                        // Dequeue the node
                        TreeNode node = queue.Dequeue();
                        // If the current node is the last node in the current level
                        if(i == size - 1)
                        {
                            // Add the node value to the result
                            result.Add(node.val);
                        }
                        // Enqueue the left child if it exists
                        if(node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        // Enqueue the right child if it exists
                        if(node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                }
                // Return the result
                return result;
            }
        }
    }
}
