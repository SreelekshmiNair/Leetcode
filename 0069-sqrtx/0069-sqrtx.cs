public class Solution {
    public int MySqrt(int x) {
        if(x==0||x==1) return x;
        int low = 1,high=x/2;
        
        while(low<=high){
            int mid = low+(high-low)/2;
            //To avoid overflow while using mid*mid
            int sqrt = x/mid;
            if(sqrt==mid) return mid;
            else if(sqrt>mid) low=mid+1;
            else high = mid-1;
        }
        return high;
    }
}