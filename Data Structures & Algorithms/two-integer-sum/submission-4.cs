public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] res = new int[2];

        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            int complement = target - currentNum;

            // Check if the complement is already in the dictionary
            if (seenNumbers.ContainsKey(complement))
            {
                // Return the index of the complement and the current index
                return new int[] { seenNumbers[complement], i };
            }

            // Store the current number and its index, handling potential duplicates
            if (!seenNumbers.ContainsKey(currentNum))
            {
                seenNumbers.Add(currentNum, i);
            }
        }

        // Return empty array if no solution is found
        return new int[0];

    }
}
