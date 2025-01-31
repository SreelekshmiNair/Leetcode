/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root) {
        int minDpt = Dfs(root);
        Console.WriteLine(minDpt);
        return minDpt;
    }
    int Dfs(TreeNode root){
        if(root == null) return 0;
        // If the left subtree is null, calculate depth of the right subtree
    if (root.left == null) {
        return Dfs(root.right) + 1;
    }

    // If the right subtree is null, calculate depth of the left subtree
    if (root.right == null) {
        return Dfs(root.left) + 1;
    }
        int leftDpth = Dfs(root.left);
        //Console.WriteLine("Left " +leftDpth);
        int rightDpth = Dfs(root.right);
        
        return Math.Min(leftDpth,rightDpth)+1;
    }
}