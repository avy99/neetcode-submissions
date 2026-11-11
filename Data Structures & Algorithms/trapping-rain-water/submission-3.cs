public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int l=0,r=n-1, leftmax=height[0], rightmax=height[n-1];
        int capacity =0;

        while(l<r){
            if(height[l]<height[r]){
                l+=1;
                leftmax = Math.Max(leftmax, height[l]);
                capacity += leftmax-height[l];
            }
            else{
                r-=1;
                rightmax= Math.Max(rightmax, height[r]);
                capacity += rightmax-height[r];
            }
        }

        return capacity;
        
    }
}
