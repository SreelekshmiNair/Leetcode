public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int pnt1 = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=val){
                nums[pnt1]=nums[i];
                pnt1++;

            }
        }
        return pnt1;
       
    }
}