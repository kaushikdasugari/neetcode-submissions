public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int left =0;
        int right = numbers.Length -1;
        while(left<right){
            if((numbers[left] + numbers[right]) > target) right --;
            else if((numbers[left] + numbers[right]) < target) left ++;
            else if((numbers[left] + numbers[right]) == target){
                res = [left+1,right+1];
                break;
            }
        }

        return res;
        
    }
}
