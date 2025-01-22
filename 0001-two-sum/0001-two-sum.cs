public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int[] result = new int[2];
        for(int i=0;i<nums.Length;i++){
           // Console.WriteLine(num);
           int val = target - nums[i];
           Console.WriteLine(val);
            if(dic.ContainsKey(val)){
                result[0] = dic[val];
                result[1] = i ;
                return result;                
            }             
                dic[nums[i]] = i;
               // Console.WriteLine(num + " " + (target-num));
        }
        return result;
    }
}