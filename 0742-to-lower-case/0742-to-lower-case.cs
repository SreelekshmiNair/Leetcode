public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder str = new StringBuilder();
        for(int i=0;i<s.Length;i++){
            if(s[i]>=65 && s[i]<=90){
                //char ele = s[i]+32;
                str.Append((char)(s[i]+32));
            }
            else{
                str.Append(s[i]);
            }
        }
        return str.ToString();
    }
}