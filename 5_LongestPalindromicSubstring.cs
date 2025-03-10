public class Solution {
    public string LongestPalindrome(string s) {
        double index = 0;
        var stepsFromIndex = 0;
        var longestCount = 1;
        var start = 0;
        var end = 0;
        if(s.Length == 1){
            return s;
        }
        for(var i = 0.5; i< (double)s.Length; i = i + 0.5){
            var steps = 0;

            for(double j=1; j < s.Length; j++){
                if(i%1 == 0){
                    if(i-j >= 0 && i+j < s.Length){
                        if(s[(int)(i-j)] == s[(int)(i+j)]){
                            steps = (int)j;
                            if((steps * 2) + 1 > longestCount){
                                longestCount = (steps * 2) + 1;
                                index = i;
                                stepsFromIndex = steps;
                            }
                        }
                        else{
                            break;
                        }
                    }
                    else{
                        break;
                    }
                }
                else{   
                    var jj = j - 0.5;
                    if(i-jj >= 0 && i+jj < s.Length){
                        if(s[(int)(i-jj)] == s[(int)(i+jj)]){
                            steps = (int)(jj + 0.5);
                            if(steps * 2 > longestCount){
                                longestCount = steps * 2;
                                index = i;
                                stepsFromIndex = steps;
                            }
                        }
                        else{
                            break;
                        }
                    }
                    else{
                        break;
                    }
                }
            }
            if(longestCount > ((s.Length - i) * 2 )+1){
                break;
            }
        }


        if(index % 1 == 0){
            start = (int)index - stepsFromIndex;
            end = (int)index + stepsFromIndex;
        }
        else{
            start = (int)(index - 0.5) - (stepsFromIndex - 1);
            end = (int)(index + 0.5) + (stepsFromIndex - 1);
        }
        return s.Substring(start, (end - start) + 1);
    }
}
