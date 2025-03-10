public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int? lastNum;
        int? num = null;
        double totalLength = nums1.Length + nums2.Length;
        var i1 = 0;
        var i2 = 0;
        double median = 1;
        for(var i = 0;i< (totalLength/2)+1;i++){
            lastNum = num ?? null;
            if(i1 < nums1.Length && (i2 >= nums2.Length || nums1[i1] < nums2[i2])){
                num = nums1[i1];
                i1++;
            }
            else{
                num = nums2[i2];
                i2++;
            }

            if(i+1 == ((double)totalLength/2)+0.5){
                median = (double)num!;
                break;
            }

            if(i+1 > (totalLength/2)+0.5){
                median = ((double)lastNum + (double)num)/2;
                break;
            }
        }

        return median;
    }
}
