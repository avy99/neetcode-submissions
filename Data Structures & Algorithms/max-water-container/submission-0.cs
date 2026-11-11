public class Solution {
    public int MaxArea(int[] heights) {
        int l=0, r = heights.Length-1;
        int capacity =0;
        while(r>l){
            int temp = (r-l)* Math.Min(heights[l],heights[r]);            
            capacity = Math.Max(temp,capacity);
            if(heights[l]<heights[r])l++;
            else r--;
        }
        return capacity;
    }
}
