public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;

        int left = 0;
        int right = heights.Length -1;

        while(left<right){
            int area = ( right -left ) * Math.Min(heights[left],heights[right]);
            maxWater =  Math.Max(area, maxWater);

            if(heights[left] < heights[right]) left++;

            else{right--;} 
        }

        return maxWater;
    }
}
