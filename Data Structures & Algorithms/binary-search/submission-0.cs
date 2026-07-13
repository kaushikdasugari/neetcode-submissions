public class Solution {
    public int Search(int[] nums, int target) {
        //In an sorted array, binary search can be used. O(logn)

        int left =0; int right= nums.Length-1;
        int mid =0;

        //if mid > target left =mid + 1 mid<target right -1 else return nums[mid]

        while(left <= right){
            mid = (left + right)/2;

            if(nums[mid] ==  target) {return mid; break;}

            else if(nums[mid] > target) right = mid - 1;

            else { left = mid + 1;}
        }


        return -1;
    }
}
