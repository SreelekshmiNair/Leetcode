public class Solution {
    public bool IsPalindrome(int x) {
        int res = x,rem=0;
        if(x<0) return false;
        while(res!=0){
           rem=(rem*10) + (res%10);
           res=res/10;
       }
       Console.WriteLine(rem);
       if(rem==x)return true;
       else return false;
    }
}