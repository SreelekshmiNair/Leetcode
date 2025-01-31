public class Solution {
    public int FindComplement(int num) {
        //Initialize mask as 1
        
        int mask = 1;
        //Create a mask with bits set to 1 which has the same bit length as the num
        while(mask<num){
            mask = (mask<<1)|1;
        }
        //Console.WriteLine(result);
        return num^mask;
        
        
    }
}