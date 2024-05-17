using System;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public TreeNode RemoveLeafNodes(TreeNode root, int target) {
        if (root == null) return null;

        // Perform post-order traversal
        root.left = RemoveLeafNodes(root.left, target);
        root.right = RemoveLeafNodes(root.right, target);

        // Check if current node is a leaf and has the target value
        if (root.left == null && root.right == null && root.val == target) {
            return null; // Remove the leaf node
        }

        return root; // Return the potentially updated subtree
    }
    
    public static void Main(string[] args) {
        var root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(2),
                null),
            new TreeNode(3,
                new TreeNode(2),
                new TreeNode(4)));

        int target = 2;
        var solution = new Solution();
        var newRoot = solution.RemoveLeafNodes(root, target);

        PrintTree(newRoot);
    }

    // Helper method to print the tree in a level-order fashion
    public static void PrintTree(TreeNode root) {
        if (root == null) {
            Console.WriteLine("[]");
            return;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++) {
                var node = queue.Dequeue();
                if (node != null) {
                    Console.Write(node.val + " ");
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                } else {
                    Console.Write("null ");
                }
            }
            Console.WriteLine();
        }
    }
}
