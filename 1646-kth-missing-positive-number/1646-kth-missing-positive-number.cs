public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int left = 0, right = arr.Length-1;
        while(left<=right){
            
            int mid = left+(right-left)/2;
           // Console.WriteLine("Mid is " + mid);
            //We can deduce how many numbers are missing by looking at the position and the
            //number at that position since the actual number which was supposed to take that
            //position was position + 1 (since 0 based index).

             /*If the number of missing integers before mid is less than k, then we update the left pointer to mid + 1; otherwise, we update the right pointer to mid - 1. We continue this process until the left pointer crosses the right pointer, at which point the left pointer will be the index of the first missing integer. Finally, we add k to the left pointer to get the k-th missing integer.*/

            int missingNum = arr[mid]-mid-1;
           // Console.WriteLine("Missing num is "+missingNum);
            if(missingNum<k) left= mid+1;
           // Console.WriteLine("New Left is :"+left);}
            else  right=mid-1;
           // Console.WriteLine("New right is " + right);
            
        }
        //Console.WriteLine("final left is " + left);
        return left+k;
    }
}