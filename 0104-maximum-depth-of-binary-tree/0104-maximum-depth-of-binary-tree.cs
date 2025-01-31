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
    //int maxDepth = 0;
    int Dfs(TreeNode root){
            if(root == null) return 0;
            int leftDepth = Dfs(root.left);
            int rightDepth = Dfs(root.right);
            return Math.Max(leftDepth,rightDepth)+1;
         }
    public int MaxDepth(TreeNode root) {
        
        int maxDp = Dfs(root);
        return maxDp;

    }
}