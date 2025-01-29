public class Solution {
     // Directions for moving up, down, left, right
    int[] dirX = new int[]{1,-1,0,0};
    int[] dirY = new int[]{0,0,1,-1};
    public int FindMaxFish(int[][] grid) {
        //Dictionary<int,int> dic = new Dictionary<int,int>(); 
        int m = grid.Length,n=grid[0].Length;
        bool[,] visited = new bool[m,n];// To keep track of visited cells
        int maxFish = 0; // To store the maximum number of fish collected
         

         //function to perform DFS and count the fish
        int DepFs(int x,int y){

            // If the current cell is out of bounds or already visited or is a land cell, return 0
            if(x<0||y<0||x>=m||y>=n||visited[x,y]||grid[x][y]==0){
                return 0;
            }
            //Mark the cell as visited
            visited[x,y] = true;

            // Start counting fish in the current cell
            int totalFish = grid[x][y];

            //Ecplore in all 4 directions
            for(int i=0;i<4;i++){
                int newX = x + dirX[i];
                int newY = y + dirY[i];
                // Explore the adjacent cell if it's within bounds and hasn't been visited
                totalFish+=DepFs(newX,newY);
            }
            return totalFish;

        }




         // Loop through all cells and perform DFS
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                // If the current cell hasn't been visited, perform DFS
                if(!visited[i,j]&&grid[i][j]!=0){
                    maxFish = Math.Max(maxFish,DepFs(i,j));// Update max fish collected
                }
            }
        }
        
       
        return maxFish;
    }
}