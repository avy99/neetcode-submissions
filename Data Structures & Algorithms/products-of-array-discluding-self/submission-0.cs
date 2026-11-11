public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] previous=new int[nums.Length];
        int[] next=new int[nums.Length];
        int starter =1;
        previous[0]=1;
        for(int i=1; i<nums.Length;i++){
            previous[i]= nums[i-1]* starter;
            starter=previous[i];
        }

        starter =1;
        next[nums.Length-1]=1;
        for(int i=nums.Length-2; i>=0;i--){
            next[i]= nums[i+1]* starter;
            starter=next[i];
        }

        int[] result=new int[nums.Length];
        for(int i=0; i<nums.Length;i++){
            result[i]= previous[i]* next[i];
        }
        return result;
    }
}
