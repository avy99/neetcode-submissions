public class Solution {
    public int[] TwoSum(int[] n, int target) {
        int l=0, r = n.Length-1;

        while(r>l){
            if(n[l]+n[r] == target)
                return new int[]{l+1,r+1};
            else if(n[l]+n[r] > target)
                r--;
            else
                l++;
        }
        return new int[]{};
    }
}
