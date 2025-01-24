public class Solution {
    public int HammingWeight(int n) {
        int cnt = 0;
       //For a given integer n, n&(n-1) will clear the lowest set bit (1) in n. 
       //In other    words, it sets the rightmost 1 bit of n to 0. If we cnt this until 
       //n becomes 0, meaning all set bits are changed to 0, it gives the number of setbits(1).
       
        while(n>0){
            n=n&(n-1);
            cnt++;
        }
        return cnt;  
          }
}