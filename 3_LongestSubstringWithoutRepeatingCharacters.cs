public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> chars = [];
        int longestSubstring = 0;
        foreach(char i in s){
            if(!chars.Contains(i)){
                chars.Add(i);
            }
            else {
                var index = chars.FindIndex(x => x == i);
                chars.RemoveRange(0,index+1);
                chars.Add(i);
            }
            if(chars.Count > longestSubstring){
                longestSubstring = chars.Count;
            }
        }
        return longestSubstring;
    }
}
