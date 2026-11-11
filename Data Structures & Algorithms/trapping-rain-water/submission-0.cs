public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int l=0,r=n-1;
        int leftmax=height[l], rightmax=height[n-1];
        int capacity =0;
        while(l<r){            
            if(leftmax<rightmax){
                l++;
                leftmax= Math.Max(leftmax,height[l]);
                capacity= capacity+leftmax-height[l];
            }
            else{
                r--;
                rightmax= Math.Max(rightmax,height[r]);
                capacity= capacity+rightmax-height[r];
            }
        }
        return capacity;
    }
}
