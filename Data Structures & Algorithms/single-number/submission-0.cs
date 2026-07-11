public class Solution {
    public int SingleNumber(int[] nums) {
        //usually if you our solution allows O(N) space then we can use hashset for unique elements.
        //This particular solution requires O(N) time and O(1) space so no Hashset.
        //One interesting learning is XOR (Exclusive OR, in simpler terms 0^0 = 0 and 1^1 = 0 and vice versa)
        // XOR on same integers will give 0, and you already know bit and true/false logic


        int result = 0;

        foreach (int num in nums) {
            result ^= num;
        }

        return result;
        
    }
}
