public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0) {
            return 0;
        }
        
        int[] leftmax = new int[n];
        int[] rightmax = new int[n];

        leftmax[0]=height[0];
        for(int i =1;i<n;i++){
            leftmax[i]=Math.Max(leftmax[i-1],height[i]);
        }

        rightmax[n-1]=height[n-1];
        for(int i =n-2;i>=0;i--){
            rightmax[i]=Math.Max(rightmax[i+1],height[i]);
        }

        int capacity =0;
        for(int i=0; i<n; i++){
            capacity += Math.Min(leftmax[i], rightmax[i])-height[i];
        }

        return capacity;
    }
}
