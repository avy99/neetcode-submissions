public class Solution {
    public int MaxArea(int[] heights) {
        int l=0,r=heights.Length-1;
        int max = 0;
        while(l<r){
            max = Math.Max(max, (r-l) * Math.Min(heights[l],heights[r]));
            if(heights[l]<heights[r]) l++;
            else r--; 
        }
        return max;
    }
}
