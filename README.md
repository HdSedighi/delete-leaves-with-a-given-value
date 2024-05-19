# Intuition

The initial thought for solving this problem involves recursively traversing the tree to identify and remove leaf nodes that match the target value. The key insight is that after removing a leaf node, its parent might become a leaf and need to be checked for the target value again. Therefore, a post-order traversal is suitable as it allows us to handle children before their parents.

# Approach

1. Perform a post-order traversal of the binary tree. This means we visit the left and right children of a node before the node itself.
2. For each node, recursively process its left and right children.
3. After processing the children, check if the current node is a leaf node (both left and right children are null) and if its value matches the target.
4. If the current node is a leaf and its value matches the target, remove it by returning null.
5. Return the potentially updated node, which either remains unchanged or is set to null if it was removed.
# Complexity
- Time complexity:

The time complexity of this approach is O(n), where n is the number of nodes in the tree. This is because each node is visited once during the traversal.

- Space complexity:

The space complexity is O(h), where h is the height of the tree. This space is used by the call stack during the recursive traversal. In the worst case, the height of the tree could be O(n) (for a skewed tree), but for a balanced tree, it would be O(logn).
